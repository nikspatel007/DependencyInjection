using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Implementations;
using DependencyInjection.Implementations.Events;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenerator _generator;
        private readonly IConfigProvider _configProvider;

        public HomeController(IGenerator generator, IConfigProvider configProvider)
        {
            _generator = generator;
            _configProvider = configProvider;
        }

        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Counts(int start = 1, int end = 100)
        //{
        //    var records = _generator.Generate(start, end);
        //    return PartialView("_Counts", records);
        //}

        [HttpGet]
        public ActionResult Counts(int start = 1, int end = 100)
        {
            var factory = new EventFactory(_configProvider);
            IGenerator generator = new Generator(factory.CreateEvent());
            var records = generator.Generate(start, end);                
            return PartialView("_Counts", records);
        }

    }
}