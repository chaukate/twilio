using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace UI.Controllers
{
    public class VoiceController : TwilioController
    {
        [HttpPost]
        public IActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("Thank you for calling! Have a great day.");

            return TwiML(response);
        }
    }
}
