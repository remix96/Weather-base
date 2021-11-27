from dotenv import load_dotenv
import os
from flask import request, make_response
from my_db import MyDb
from custom_error import EmptySpaceError, UrlError, DbQueryError
import weather_helper

load_dotenv()
API_KEY = os.getenv("API_KEY")
DB_NAME = os.getenv("DB_NAME")
db = MyDb(DB_NAME)

class Weather:

    @staticmethod
    def current_weather():  # Meteo corrente
        try:
            # Recupero location/country da parametry GET
            location = request.args["location"]
            country = request.args["country"]
            weather_helper.check_empty_and_number(location, country)  # Appositi controlli su location/country
            response = weather_helper.get_json(f"http://api.openweathermap.org/data/2.5/weather?q={location},{country}&lang=it&units=metric&appid={API_KEY}")  # Aggiunto "http://" per renderlo accettabile da requests
            temperature = weather_helper.remove_round_and_zero(response["main"]["temp"]) + " °C"  # Temperatura corrente in Celsius
            description = response["weather"][0]["description"].capitalize()  # Condizione climatica
            icon_code = response["weather"][0]["icon"]  # Codice icona da risposta json
            base64_icon = weather_helper.get_and_convert_icon_to_base64(icon_code)  # Recupero e conversione icona in base64, tramite codice icona
            current_weather_data = {  # Dizionario
                "temperature": temperature,
                "description": description,
                "base64_icon": base64_icon
            }
        except ValueError:
            return make_response({"description": "Errore. Formattazione location/country errata."}, 400)
        except EmptySpaceError as err:
            return make_response({"description": str(err)}, 400)
        except UrlError as err:
            return make_response({"description": str(err)}, 404)
        except:
            return make_response({"description": "Errore generico."}, 404)
        else:
            return current_weather_data

    @staticmethod
    def more_current_details():  # Più informazioni su meteo corrente
        try:
            location = request.args["location"]
            country = request.args["country"]
            weather_helper.check_empty_and_number(location, country)
            response = weather_helper.get_json(f"http://api.openweathermap.org/data/2.5/weather?q={location},{country}&lang=it&units=metric&appid={API_KEY}")
            feels_like_temperature = weather_helper.remove_round_and_zero(response["main"]["feels_like"]) + " °C"  # Temperatura percepita
            pressure = str(response["main"]["pressure"]) + " hPa"  # Pressione atmosferica
            humidity = str(response["main"]["humidity"]) + "%"  # Umidità
            cloudiness = str(response["clouds"]["all"]) + "%"  # Nuvolosità
            wind_speed = str(response["wind"]["speed"]) + " m/s"  # Velocità vento, metri/secondo
            more_current_details_data = {
                "feels_like_temperature": feels_like_temperature,
                "pressure": pressure,
                "humidity": humidity,
                "cloudiness": cloudiness,
                "wind_speed": wind_speed
            }
        except ValueError:
            return make_response({"description": "Errore. Formattazione location/country errata."}, 400)
        except EmptySpaceError as err:
            return make_response({"description": str(err)}, 400)
        except UrlError as err:
            return make_response({"description": str(err)}, 404)
        except:
            return make_response({"description": "Errore generico."}, 404)
        else:
            return more_current_details_data

    @staticmethod
    def week_forecast():  # 7 giorni non compreso oggi
        try:
            location = request.args["location"]
            country = request.args["country"]
            weather_helper.check_empty_and_number(location, country)
            response = weather_helper.get_json(f"http://api.openweathermap.org/data/2.5/forecast/daily?q={location},{country}&cnt=8&lang=it&units=metric&appid={API_KEY}")
            # cnt 8 perché il primo giorno è il corrente che appunto poi è escluso in range
            week_forecast_data = {}
            for i in range(1, 8):  # Per ognuno dei prossimi 7 giorni
                min_temperature = response["list"][i]["temp"]["min"]
                max_temperature = response["list"][i]["temp"]["max"]
                mean_temperature= weather_helper.remove_mean_round_and_zero(min_temperature, max_temperature) + " °C"  # Temperatura media
                description = response["list"][i]["weather"][0]["description"].capitalize()
                icon_code = response["list"][i]["weather"][0]["icon"]
                base64_icon = weather_helper.get_and_convert_icon_to_base64(icon_code)
                day_forecast_data = {
                    "day" + str(i): {
                        "temperature": mean_temperature,
                        "description": description,
                        "base64_icon": base64_icon
                    }
                }
                week_forecast_data.update(day_forecast_data)  # Aggiunta sottodizionari di ogni giorno a questo per avere settimana
            db.add_week_forecast(location, country, week_forecast_data)  # Inserimento dei dati recuperati, sui prossimi 7 giorni, in db
        except ValueError:
            return make_response({"description": "Errore. Formattazione location/country errata."}, 400)
        except EmptySpaceError as err:
            return make_response({"description": str(err)}, 400)
        except UrlError as err:
            return make_response({"description": str(err)}, 404)
        except DbQueryError as err:
            return make_response({"description": str(err)}, 500)
        except:
            return make_response({"description": "Errore generico."}, 404)
        else:
            return week_forecast_data

    @staticmethod
    def year_aggregation():  # Statistica annuale 
        try:
            location = request.args["location"]
            country = request.args["country"]
            weather_helper.check_empty_and_number(location, country)
            year_aggregation_data = {}
            for month_number in range(1, 13):
                response = weather_helper.get_json(f"http://history.openweathermap.org/data/2.5/aggregated/month?q={location},{country}&month={month_number}&appid={API_KEY}")
                temperature = weather_helper.convert_celsius_and_round(response["result"]["temp"]["mean"])
                humidity = response["result"]["humidity"]["mean"]  # %
                precipitation = response["result"]["precipitation"]["mean"]  # Precipitazione, mm
                month_aggregation_data = {
                    month_number: {
                        "temperature": temperature,
                        "humidity": humidity,
                        "precipitation": precipitation
                    }
                }
                year_aggregation_data.update(month_aggregation_data)
        except ValueError:
            return make_response({"description": "Errore. Formattazione location/country errata."}, 400)
        except EmptySpaceError as err:
            return make_response({"description": str(err)}, 400)
        except UrlError as err:
            return make_response({"description": str(err)}, 404)
        except:
            return make_response({"description": "Errore generico."}, 404)
        else:
            return year_aggregation_data