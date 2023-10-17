using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsetting.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Enter zip:");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";

            Console.WriteLine();

            Console.WriteLine($"The temperature is currently {WeatherMap.GetTemp(apiCall)} degrees in {WeatherMap.GetCity(apiCall)}");

        }
    }
}