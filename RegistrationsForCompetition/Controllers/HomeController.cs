using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationsForCompetition.Models;

namespace RegistrationsForCompetition.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.SiteName = "Регистрацию";



            return View();
        }

        [HttpPost]
        public ViewResult Index(Player player)
        {
            ViewBag.SiteName = "Регистрацию";

            if (ModelState.IsValid)
            {
                Repositories.AddResponses(player);

                return View("Completed", player);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListPlayers()
        {
            return View(Repositories.Players.OrderBy(r => r.CountPP));
        }
    }
}
