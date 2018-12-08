using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExemploSiteMiddleware.Models;

namespace ExemploSiteMiddleware.Controllers
{
    [MiddlewareFilter(typeof(IndisponibilidadePipeline))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[MiddlewareFilter(typeof(IndisponibilidadePipeline))]
        public IActionResult Testar()
        {
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