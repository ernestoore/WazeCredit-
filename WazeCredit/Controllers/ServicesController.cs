using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WazeCredit.Service.LifetTimeServces;

namespace WazeCredit.Controllers
{
    public class ServicesController : Controller
    {
        private readonly TransientService _transientService;
        private readonly ScopedService _scopedService;
        private readonly SingletonService _singletonService;

        public ServicesController(TransientService transientService, ScopedService scopedService, SingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
            
        }

        public IActionResult Index()
        {

            var messages = new List<String>
            {
                HttpContext.Items["CustomMiddlewareTransient"].ToString(),
                $"Transient Controller - {_transientService.getGuid}",
                HttpContext.Items["CustomMiddlewareScoped"].ToString(),
                $"Scoped Controller - {_scopedService.getGuid}",
                HttpContext.Items["CustomMiddlewareSingleton"].ToString(),
                $"Singleton Controller - {_singletonService.getGuid}",
            };

            return View(messages);

        }

    }
}
