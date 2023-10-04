using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Creiamo un'istanza di HttpClient per effettuare una richiesta HTTP asincrona
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                // Definiamo l'URL del sito web da cui vogliamo ottenere dati
                string url = "https://www.example.com";

                // Utilizziamo il metodo GetAsync per inviare una richiesta HTTP GET asincrona
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Verifichiamo se la richiesta ha avuto successo
                if (response.IsSuccessStatusCode)
                {
                    // Leggiamo il contenuto della risposta come stringa
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Contenuto della pagina web:");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Errore nella richiesta HTTP: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }
        }
    }
}
