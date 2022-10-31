using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace yt_JsonInCsharp
{
    public class Program
    {
        static async Task Main(string[] args)

        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            // an http clientf to send the get request
            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                // read the string from the response´s content
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                // print the jsonResponse
                Console.WriteLine(jsonResponse);

                // Deserialize the json response into a C# array of type Post[]
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                //print the array objects using a foreach loop
                foreach (var post in myPosts)
                {
                    //print the id and the title of each post
                    Console.WriteLine($"{post.Id}{post.Title}");
                }
            }
            catch (Exception e)
            {
                // print the exception message
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Dispose of the httpClient - OTHERWISE THIS WOULD CONTINUE TO BE OPEN
                httpClient.Dispose();
            }

        }
    }

}
