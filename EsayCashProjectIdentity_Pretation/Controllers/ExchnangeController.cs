using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    public class ExchnangeController : Controller
    {
        public async Task< IActionResult> Index()
        {
            #region
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/listquotes"),
                Headers =
    {
        { "X-RapidAPI-Key", "510caf2efcmsh23d0a7d14ba49e3p18901fjsn525b4c361249" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                ViewBag.UsdToTry = body;    
            }
            #endregion

            #region
            var client1 = new HttpClient();
            var request1 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/listquotes"),
                Headers =
    {
        { "X-RapidAPI-Key", "510caf2efcmsh23d0a7d14ba49e3p18901fjsn525b4c361249" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response1 = await client.SendAsync(request1))
            {
                response1.EnsureSuccessStatusCode();
                var body1 = await response1.Content.ReadAsStringAsync();
                Console.WriteLine(body1);
                ViewBag.UsdToTry = body1;
            }
            #endregion

            #region
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/listquotes"),
                Headers =
    {
        { "X-RapidAPI-Key", "510caf2efcmsh23d0a7d14ba49e3p18901fjsn525b4c361249" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                Console.WriteLine(body3);
                ViewBag.UsdToTry = body3;
            }
            #endregion
            return View();


        }
    }
}
