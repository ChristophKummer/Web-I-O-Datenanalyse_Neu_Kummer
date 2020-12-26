using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Web_IO_Datenanalyse_Neu_Kummer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new webclient
            WebClient client = new WebClient();

            //Optional: Set user agent - to pretend we are a google chrome browser
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
            
            // Download data as string from given address (http: ....)
            string InPutWebsite = client.DownloadString("https://www.innsbruck.gv.at/data.cfm?vpath=diverse/ogd/statistik9/wetter/monatsmitteltemperaturen-seit-1906csv");

            // Print data loaded from website
            Console.WriteLine(InPutWebsite);

            Console.ReadKey();

        }
    }
}
