using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingOfKingsLutheranChurch.Controllers
{
    public class NewsAndEventsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }

        public IActionResult PorchLightGroup()
        {
            return View();
        }

        public IActionResult CalendarOfEvents()
        {
            return View();
        }
    }
}
