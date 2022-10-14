using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleProgram
{
    public class DataObject
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Completed { get; set; }
    }

    public class Program
    {
        private const string URL = "https://jsonplaceholder.typicode.com/todos/";
        //private string urlParameters = "?api_key=123";

        static void Main(string[] args)
        {
            Func();
        }

        public static void Func()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            var response = client.GetAsync("").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsAsync<IList<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll

                //var dataObjects = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(dataObjects);

                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", d.UserId, d.Id, d.Title, d.Completed);

                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int) response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
        }
    }
}