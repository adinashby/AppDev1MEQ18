
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Handlers;
using System.Net.Http.Headers;

namespace API_Csharp
{
    public class DataObject
    {
        public String UserID { get; set; }
        public String ID { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }

    }

    // A sample example of an API call from openweathermap API website.
    // https://openweathermap.org/api/one-call-3 //Website
    // https://api.openweathermap.org/data/3.0/onecall?lat={lat}&lon={lon}&exclude={part}&appid={API key}  //API call

    // https://openweathermap.org/current // website
    // https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key}   // API call

    public class Program
    {
        private const String URL = "https://jsonplaceholder.typicode.com/posts";
        //private String urlParameters = "?api_key=123";

        static void Main(string[] args)
        {
            Func();
            //Console.WriteLine("Hello, World!");
        }

        public static void Func()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response
            var response = client.GetAsync(URL).Result; // Blocking call! program will wait here until a response is received or a timeout occurs.

            if (response.IsSuccessStatusCode)
            {
                //Console.WriteLine(response.StatusCode.ToString()); // Display OK

                //parse the response body.
                
                //option 1:
                 var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  // Make sure to add a reference to System.Net.formatting.dll
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}",d.Title);
                }


                // option 2:
               // var dataObjects = response.Content.ReadAsStringAsync().Result; // returning HTML page
                //Console.WriteLine(dataObjects);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})",(int) response.StatusCode, response.ReasonPhrase);
            }

            //Make any other calls using httpclient here.



            // Dispose once all HttpClient calls are completed. This is not necessary if the containing object will be desposed of,
            // for example: in this case the Httpclient instance will be disposed automatically when the application terminates,
            // so, the following call is superfluous.

            client.Dispose();

        }
    }
}