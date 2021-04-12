using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WazeCredit.Models;
using WazeCredit.Models.ViewModels;
using WazeCredit.Service;
using WazeCredit.Utility.AppSettings;

namespace WazeCredit.Controllers
{
    public class HomeController : Controller
    {
        public HomeVM _homeVM { get; set; }
        private readonly IMarketForecaster _marketForecaster;
        private readonly SendGridSettings _sendGridSettings;
        private readonly StripeSettings _stripeSettings;
        private readonly TwilioSettings _twilioSettings;
        private readonly WazeForecastSettings _wazeSettings;


        public HomeController(IMarketForecaster marketForecaster,
            IOptions<SendGridSettings> sendGridOptions,
            IOptions<StripeSettings> stripeSettings,
            IOptions<TwilioSettings> twilioSettings,
            IOptions<WazeForecastSettings> wazeSettings
            )
        {
            _homeVM = new HomeVM();
            _marketForecaster = marketForecaster;

            _sendGridSettings = sendGridOptions.Value;
            _stripeSettings = stripeSettings.Value;
            _twilioSettings = twilioSettings.Value;
            _wazeSettings = wazeSettings.Value;
        }

        public IActionResult Index()
        {
            MarketResult marketResult = _marketForecaster.GetMarketPrediction();

            switch (marketResult.MarketCondition)
            {
                case MarketCondition.StableUp:
                    _homeVM.MarketForecast = "Market shows going up";

                    break;
                case MarketCondition.StableDown:
                    _homeVM.MarketForecast = "Market shows going down";
                    break;
                case MarketCondition.Volatile:
                    _homeVM.MarketForecast = "Market shows being volatile";
                    break;
                default:
                    _homeVM.MarketForecast = "Not returning data";
                    break;
            }

            return View(_homeVM);
        }

        public IActionResult AllConfigSettings()
        {
            List<string> messages = new List<string>();

            messages.Add($"Waze Config - Forecast Tracker: " + _wazeSettings.ForecastTrackerEnabled);
            messages.Add($"Stripe Config - Stripe Publishable Key: " + _stripeSettings.PublishableKey);
            messages.Add($"Stripe Config - Stripe Secret Key: " + _stripeSettings.SecretKey);
            messages.Add($"SendGrid Config - SendGrid Key: " + _sendGridSettings.SendGridKey);
            messages.Add($"Twilio Phone: " + _twilioSettings.PhoneNumber);
            messages.Add($"Twilio SID: " + _twilioSettings.AccountSid);
            messages.Add($"Twilio Token: " + _twilioSettings.AuthToken);

            return View(messages);

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
