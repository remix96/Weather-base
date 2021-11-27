import urllib.request, requests, base64, statistics
from custom_error import UrlError, EmptySpaceError

def get_json(url):
    json_response = requests.get(url).json()  # Invio richiesta get all'url, e la risposta viene convertita in json per accedere agli attributi individuali
    if json_response["cod"] == "404":  # Se non è stato possibile recuperare il dato corretto da OpenWeather
        raise UrlError("404")
    return json_response

def get_and_convert_icon_to_base64(icon_code):  # Conversione icona da binario verso stringa base64
    url = f"http://openweathermap.org/img/wn/{icon_code}@4x.png"  # url per icona da OpenWeather, tramite icon_code passato
    icon = urllib.request.urlretrieve(url)  # Recupero immagine icona come tupla 
    try:
        with open(icon[0], "rb") as img:
            base64_data = base64.b64encode(img.read()).decode('utf-8')  # Conversione icona ottenuta verso base64
    except:
        raise Exception
    return base64_data

def remove_round_and_zero(vanilla_temperature): 
    temperature = str(round(vanilla_temperature, 1))  # Arrotondamento con 1 cifra decimale da stringa contenente temperatura
    if temperature[-1] == "0":  # Rimozione .0
	    temperature = temperature.replace(".0", "")
    return temperature

def remove_mean_round_and_zero(vanilla_min_temperature, vanilla_max_temperature):  # Come roundAndZeroRemover ma con calcolo temperatura media
    vanilla_temperature = statistics.mean([vanilla_min_temperature, vanilla_max_temperature])
    temperature = remove_round_and_zero(vanilla_temperature)  # Temperatura media, da min e max
    return temperature

def convert_celsius_and_round(vanilla_temperature):
    temperature = round(vanilla_temperature - 273.15, 1)  # Conversione da K a °C e arrotondamento
    return temperature

def check_numeric(dot, comma):  # Controllo che nessuna parte di location/string contenta solo numeri
    work_tuple = (dot, comma)
    for item in work_tuple:
        for part in item:
            if part.isnumeric():  # True se tutti i caratteri sono caratteri numerici
                raise ValueError

def check_empty_and_number(location, country):  # Divisione di stringhe location e country in base a , e . per vedere se sono convertibili in int o float
    if not location or not country:  # Se location o country sono vuote o con soli spazi
        raise EmptySpaceError
    elif not any(c.isalpha() for c in location) or not any(c.isalpha() for c in country):  # Condizione True se location o country non hanno neanche 1 elemento che è una lettera dell'alfabeto
        raise ValueError   # Rilanciata perché può contenere solo numeri/trattini/spazi/punti
    else:  # Parte per controllo che nè location e nè country contengono solo numeri tra . o ,
        location_dot = location.replace(" ", "").split(".")  # Inizialmente c'è rimozione spazi in ogni parte della stringa
        location_comma = location.replace(" ", "").split(",")
        check_numeric(location_dot, location_comma)
        country_dot = country.replace(" ", "").split(".")
        country_comma = country.replace(" ", "").split(",")
        check_numeric(country_dot, country_comma)