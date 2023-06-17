using System.IO;

using Newtonsoft.Json.Linq;

var apiKeyObj = File.ReadAllText("appsettings.json");

var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

var zip = 55420;

var url = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";

var client  = new HttpClient();

var response  = client.GetStringAsync(url).Result;

var weatherObj = JObject.Parse(response);

Console.WriteLine( $"Temp:{weatherObj["main"]["temp"]}");