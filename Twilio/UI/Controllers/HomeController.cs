using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            TwilioClient.Init("", "");

            var to = new PhoneNumber(""); // Registered Physical Number
            var from = new PhoneNumber(""); // Registered Virtual Number
            var call = CallResource.Create(to, from, url: new Uri("http://demo.twilio.com/docs/voice.xml"));

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}