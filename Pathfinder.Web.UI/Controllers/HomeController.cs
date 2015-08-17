using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Pathfinder.Generators.Background;
using Pathfinder.Web.UI.Models;

namespace Pathfinder.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id = null)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Background(string race = "")
        {
            BaseBackgroundBuilder backgroundBuilder;
            switch (race.ToLower())
            {
                case "human": backgroundBuilder = new HumanBackgroundBuilder(); break;
                case "elf": backgroundBuilder = new ElfBackgroundBuilder(); break;
                case "dwarf":
                default: backgroundBuilder = new DwarfBackgroundBuilder(); break;
            }
            CharacterInformationModel cs = new CharacterInformationModel(backgroundBuilder.CreateBackground());

            if (Request.IsAjaxRequest())
                return PartialView("_CharacterInformation", cs);
            else
                return View(cs);
        }
    }
}