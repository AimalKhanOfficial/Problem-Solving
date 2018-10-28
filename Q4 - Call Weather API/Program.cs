using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InfluenceHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            getTemperature("Atlanta");
            Console.ReadLine();
        }

        public static void getTemperature(string cityName)
        {
            try
            {
                var http = (HttpWebRequest)WebRequest.Create(@"http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&units=metric&APPID=42f5601f29d6bf51df7411a340a84e89");
                var sr = new StreamReader(http.GetResponse().GetResponseStream());
                dynamic json = JsonConvert.DeserializeObject(sr.ReadToEnd());
                Console.WriteLine(json.main.temp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
