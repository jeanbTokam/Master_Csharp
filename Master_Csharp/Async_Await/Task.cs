using System;
using System.Threading.Tasks;

namespace Master_Csharp.Async_Await
{
    class Program
    {


      



        static async Task<string> GetApiResponseAsync(string url)
        {



            using (HttpClient client = new HttpClient()) { 
            
            HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();


                return await response.Content.ReadAsStringAsync();
            
            
            }
        }

        static async Task Main(string[] args)
        {

            string url = "https://jsonplaceholder.typicode.com/posts/";


            string response = await GetApiResponseAsync(url);   


            Console.WriteLine(response);

        }
    }
}