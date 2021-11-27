import sqlite3
from custom_error import DbConnectionError, DbQueryError

class MyDb:
    # query per creare la tabella nel db
    query_create_table = """
    CREATE TABLE IF NOT EXISTS week_forecast_weather (
    location TEXT NOT NULL,
    country TEXT NOT NULL CHECK(country<>''),
    day1_temperature NUMERIC NOT NULL,
    day1_description TEXT NOT NULL,
    day1_base64_icon TEXT NOT NULL,
    day2_temperature NUMERIC NOT NULL,
    day2_description TEXT NOT NULL,
    day2_base64_icon TEXT NOT NULL,
    day3_temperature NUMERIC NOT NULL,
    day3_description TEXT NOT NULL,
    day3_base64_icon TEXT NOT NULL,
    day4_temperature NUMERIC NOT NULL,
    day4_description TEXT NOT NULL,
    day4_base64_icon TEXT NOT NULL,
    day5_temperature NUMERIC NOT NULL,
    day5_description TEXT NOT NULL,
    day5_base64_icon TEXT NOT NULL,
    day6_temperature NUMERIC NOT NULL,
    day6_description TEXT NOT NULL,
    day6_base64_icon TEXT NOT NULL,
    day7_temperature NUMERIC NOT NULL,
    day7_description TEXT NOT NULL,
    day7_base64_icon TEXT NOT NULL,
    PRIMARY KEY (location, country))
    """

    def __init__(self, database_name):
        try:
            self.conn = sqlite3.connect(database_name, check_same_thread=False)  # Connesione al db
            self.cur = self.conn.cursor()  # Creazione cursore
        except sqlite3.error:
            raise DbConnectionError
        else:
            self.cur.execute(self.query_create_table)  # Esecuzione query creazione tabella db
            
    def execute(self, query, data):
        try:
            self.cur.execute(query, data)  # Esecuzione query generica
            self.conn.commit()  # commit della query
        except:
            raise DbQueryError
        else:
            return self.cur

    def add_week_forecast(self, vanilla_location, vanilla_country, week_forecast_data):
        location = vanilla_location.title().replace(" ", "")  # Rimozione spazi da tutto, per agevolare esecuzione script R che non può fare query su valori con spazi nel mezzo
        country = vanilla_country.replace(" ", "").upper()  # upper, a differenza di title che rende maiuscola la prima lettera di ogni parola, rende tutto maiuscolo
        week_forecast_list = []
        for day in week_forecast_data.values():  # Iterazione di tutti gli elementi dei 7 giorni di previsione
            week_forecast_list.extend([day["temperature"], day["description"], day["base64_icon"]])  # Aggiunta come singoli elementi
        params = ((location, country) + tuple(week_forecast_list))  # Concatenazione di tuple con operatore +
        return self.execute("INSERT OR REPLACE INTO week_forecast_weather VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", params)  # Inserimento dati in db