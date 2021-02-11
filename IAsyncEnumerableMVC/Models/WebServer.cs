using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IAsyncEnumerableMVC.Models
{
    public static class WebServer
    {
     
        public static async IAsyncEnumerable<string> GetWebsiteContent()
        {
            var httpClient = new HttpClient();

            foreach(var website in WebSites.GetListOfWebSites())
            {
               var response =  await httpClient.GetAsync(website);
                yield return await response.Content.ReadAsStringAsync() ;

            }

        }


    }
}
