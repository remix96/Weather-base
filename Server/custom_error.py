class EmptySpaceError(Exception):  # Eccezione per quando la stringa è vuota o composta da soli spazi
    def __str__(self):
        return "Errore. Riempire location/country."


class UrlError(Exception):  # Eccezione per quando non è possibile recuperare nulla da OpenWeather
    def __str__(self):
        return "Errore. Non è stato possibile trovare dati per il posto indicato, cambiare location/country."


class DbConnectionError(Exception):  # Eccezione per quando non è possibile effettuare connessione al db
    def __str__(self):
        return "Errore. Non è stato possibile effettuare la connessione al database indicato."


class DbQueryError(Exception):  # Eccezione per quando non è possibile eseguire la query sul db
    def __str__(self):
        return "Errore. Non è stato possibile eseguire la query."