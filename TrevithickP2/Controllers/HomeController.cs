using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrevithickP2.Models;

namespace TrevithickP2.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View(new InvestmentCalc());
        }




        [HttpPost]
        public IActionResult Summary(InvestmentCalc inv)
        {
            //ViewBag.Principle = inv.Principle;
            return View();
        }
    }
}
