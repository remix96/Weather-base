using System.Net.Http;
using System.Net.Http.Headers;

namespace Client
{
    // Creazione classe per i bisogni di base di una chiamata API
    public class APIHelper // Non statica perché poi istanziata per chiamare InitializeClient
    {
        // Proprietà static in modo che sia aperto un solo HttpClient per ogni applicazione
        public static HttpClient ApiClient { get; set; }

        // Impostazione ApiClient
        public static void InitializeClient() // Il metodo, facente parte dei membri, essendo statico è accessibile direttamente cioè senza nemmeno creare un oggetto
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Aggiunto header per richiedere json
        }
    }
}