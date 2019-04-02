using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mylocation.Models;
using RestSharp;

namespace mylocation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GetLocation()
        {
            // Call service to get location information based on IP address
            var client = new RestClient("locationms");
            var response = client.Get(new RestRequest());
            ViewData["LocationJSON"] = response.Content;

            return View();
        }
public string GetReleases(string url)
{
    var client = new RestClient(url);
 
    var response = client.Execute(new RestRequest());
 
    return response.Content;
}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
