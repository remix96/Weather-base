library(stringr)
library(httr)
library(DBI)
# Recupero valori inseriti da linea di comando 
args <- commandArgs(trailingOnly = TRUE) # Character
# Prima args è convertito in un'unica stringa, mantenendo gli eventuali spazi, e poi questa è divisa per virgola e assegnata a un vettore
commaArgs <- unlist(strsplit((paste(args, collapse = " ")), ","))
setwd("C:/Users/remo9/Desktop/ProgettoMeteo/Server/") # Impostazione working directory, in cui c'è il db
# Associo gli argomenti ricevuti a location, country e modalità (plot desiderato) scelta
location <- str_to_title(commaArgs[1])
country <- toupper(commaArgs[2])
mode <- commaArgs[3]
week <- format(seq((Sys.Date() + 1), (Sys.Date() + 7), 1), "%d/%m/%Y") # Creazione dato per label coi prossimi 7 giorni
month <- format(seq(as.Date(Sys.Date() - 350), length.out = 12, by = "1 month"), "%m/%Y")
tryCatch(
  expr = {
    switch(mode, # switch effettuato sulla base del valore di mode
           "1" = {
             conn <- dbConnect(RSQLite::SQLite(), "weatherbase") # Connessione al db
             locationReform = str_replace_all(location, " ", "") # Formattazione location per query RSQLite
             forecast <- dbGetQuery(conn,
                                   "SELECT day1_temperature,
                                           day2_temperature,
                                           day3_temperature,
                                           day4_temperature,
                                           day5_temperature,
                                           day6_temperature,
                                           day7_temperature
                                    FROM week_forecast_weather
                                    WHERE location = ? AND country = ?", params = c(locationReform, country)) # Invio query
             if(dim(forecast)[1] == 0) # Se il data frame tornato ha 0 righe, allora non esistono dati nel db per location/country
               # Rilancio eccezione
               error()
             dbDisconnect(conn) # Disconnessione dal db
             forecast <- str_sub(forecast, 1, str_length(forecast) - 3) # Rimozione " °C" dalle varie temperature ottenute
             png(file = "C:/Users/remo9/Desktop/ProgettoMeteo/plot.png", width = 1000, height = 1000) # Impostazione grafico, con path e dimensione
             plot(forecast, type = "l", col = "red", axes = FALSE, ann = FALSE, lwd = 2, xaxs = "i", panel.first = # plot di forecast, mettendo la linea delle temperature in primo piano
                  c(abline(h = forecast, lty = 3, col = "gray50", lwd = 2),
                    abline(v = 1:7, lty = 3, col = "gray50", lwd = 2)))
             title(xlab = "Data", ylab = "Temperatura (°C)") # Impostazione titoli assi
             axis(1, at = 1:7, labels = week) # Impostazione valori asse
             axis(2, at = forecast, labels = forecast, las = 1)
           },
           "2" = {
             r <- GET("http://localhost:54000/yearaggregation", # url da cui prendere i dati chiedendoli al server
                      query = list(location = location, country = country)) # Parametri per la richiesta GET
             if(lengths(content(r)) == 1) # Se nella lista tornata è contenuto solo 1 elemento, cioè la stringa di errore
               # Contiene descrizione description inviata dal server
               error()
             monthly_data <- content(r) # Creazione dato contenente la risposta del server
             temperature <- c(monthly_data$"11"$temperature,
                             monthly_data$"12"$temperature,
                             monthly_data$"1"$temperature,
                             monthly_data$"2"$temperature,
                             monthly_data$"3"$temperature,
                             monthly_data$"4"$temperature,
                             monthly_data$"5"$temperature,
                             monthly_data$"6"$temperature,
                             monthly_data$"7"$temperature,
                             monthly_data$"8"$temperature,
                             monthly_data$"9"$temperature,
                             monthly_data$"10"$temperature)
             png(file = "C:/Users/remo9/Desktop/ProgettoMeteo/plot.png", width = 1920, height = 2400)
             plot(temperature, type = "l", col = "goldenrod1", axes = FALSE, ann = FALSE, lwd = 7.5, xaxs = "i", panel.first =
                  c(abline(h = temperature, lty = 3, col = "gray50", lwd = 2),
                    abline(v = 1:12, lty = 3, col = "gray50", lwd = 2)))
             title(xlab = "Mese", ylab = "Temperatura (°C)")
             axis(1, at = 1:12, labels = month)
             axis(2, at = temperature, labels = temperature, las = 1)
           },
           "3" = {
             r <- GET("http://localhost:54000/yearaggregation",
                      query = list(location = location, country = country))
             if(lengths(content(r)) == 1)
               error()
             monthly_data <- content(r)
             humidity <- c(monthly_data$"11"$humidity,
                          monthly_data$"12"$humidity,
                          monthly_data$"1"$humidity,
                          monthly_data$"2"$humidity,
                          monthly_data$"3"$humidity,
                          monthly_data$"4"$humidity,
                          monthly_data$"5"$humidity,
                          monthly_data$"6"$humidity,
                          monthly_data$"7"$humidity,
                          monthly_data$"8"$humidity,
                          monthly_data$"9"$humidity,
                          monthly_data$"10"$humidity)
             png(file = "C:/Users/remo9/Desktop/ProgettoMeteo/plot.png", width = 1920, height = 2400)
             barplot(height = humidity, names = month, xlab = "Mese", ylim = c(0, 100), yaxt = "n", ylab = "Umidità (%)", col = "burlywood", border = "black", lwd = 5)
             abline(h = humidity, lty = 3, col = "gray50", lwd = 2)
             axis(2, at = humidity, labels = humidity, las = 1)
           },
           "4" = {
             r <- GET("http://localhost:54000/yearaggregation",
                      query = list(location = location, country = country))
             if(lengths(content(r)) == 1)
               error()
             monthly_data <- content(r)
             precipitation <- c(monthly_data$"11"$precipitation,
                               monthly_data$"12"$precipitation,
                               monthly_data$"1"$precipitation,
                               monthly_data$"2"$precipitation,
                               monthly_data$"3"$precipitation,
                               monthly_data$"4"$precipitation,
                               monthly_data$"5"$precipitation,
                               monthly_data$"6"$precipitation,
                               monthly_data$"7"$precipitation,
                               monthly_data$"8"$precipitation,
                               monthly_data$"9"$precipitation,
                               monthly_data$"10"$precipitation)
             png(file = "C:/Users/remo9/Desktop/ProgettoMeteo/plot.png", width = 1920, height = 2400)
             plot(precipitation, type = "l", col = "gray50", axes = FALSE, ann = FALSE, lwd = 7.5, xaxs = "i", yaxs = "i")
             polygon(c(1, 1:12, 12),
                     c(min(precipitation), precipitation, min(precipitation)),
                     col = "skyblue", border = FALSE)
             title(xlab = "Mese", ylab = "Precipitazione (mm)")
             axis(1, at = 1:12, labels = month)
             axis(2, at = precipitation, labels = precipitation, las = 1)
           }
    )
  },
  error = function(e) { # Se si verifica errore in una delle 4 modalità
    png(file = "C:/Users/remo9/Desktop/ProgettoMeteo/plot.png") # Inizio creazione plot di errore
    par(mar = c(0, 0, 0, 0)) # Rimozione margini
    plot(0:10, 0:10, col = "#FFFFFF", axes = FALSE, ann = FALSE, xaxs = "i", yaxs = "i")
    text(x = 5, y = 5, "N/A", col = "red", cex = 3) # Scrittura testo in plot
  },
  finally = { 
    box() # Aggiunta bordi al plot
    dev.off() # Disattivazione dispositivo usato per creare il plot
  }
)