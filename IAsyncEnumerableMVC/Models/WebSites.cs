using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAsyncEnumerableMVC.Models
{
    public static class WebSites
    {

        public static IEnumerable<string> GetListOfWebSites()
        {
            return new List<string>()
            {
                "https://google.com",
                "https://microsoft.com",
                "https://www.salesforce.com"
            };

        }



    }
}
