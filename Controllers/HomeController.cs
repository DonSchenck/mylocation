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
        public class ipaddress
        {
            public string ip {get;set;}
        }
        public IActionResult Index()
        {
            ipaddress addr = new ipaddress();
            addr.ip = "75.33.55.88";
            return View(addr);
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

        public IActionResult GetLocation(ipaddress ipaddr)
        {
            // Call service to get location information based on IP address
            // URL is stored in an environment variable
            string url = Environment.GetEnvironmentVariable("LOCATION_SERVICE_URI");
            Console.WriteLine("LOCATION_SERVICE_URI: " + url);
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(url + ipaddr);
            var response = client.Get(request);
            var content = response.Content; // raw content as string           
            ViewData["LocationJSON"] = content;

            return View();
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
