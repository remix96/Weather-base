from dotenv import load_dotenv
import os
from flask import Flask, make_response
from weather import Weather
from custom_error import DbConnectionError

load_dotenv()
HOST = os.getenv("HOST")
PORT = os.getenv("PORT")

try:
    app = Flask("Weather server")
except DbConnectionError as err:
    make_response({"description": str(err)}, 500)  # Se c'è errore di connessione al db, ritorna json con descrizione errore e status 500

# Impostazione delle varie route con rispettivi path url, funzione eseguita, richiesta metodo HTTP accettata
app.add_url_rule("/currentweather", view_func=Weather.current_weather, methods=["GET"])
app.add_url_rule("/morecurrentdetails", view_func=Weather.more_current_details, methods=["GET"])
app.add_url_rule("/weekforecast", view_func=Weather.week_forecast, methods=["GET"])
app.add_url_rule("/yearaggregation", view_func=Weather.year_aggregation, methods=["GET"])

if __name__ == "__main__":
    app.run(debug=False, host=HOST, port=PORT)  # Avvio server, non in modalità debug, su host e porta selezionati