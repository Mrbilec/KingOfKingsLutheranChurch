using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KingOfKingsLutheranChurch.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult DevotionalThought()
        {
            return View();
        }

        public IActionResult GriefSupport()
        {
            return View();
        }

        public IActionResult Links()
        {
            return View();
        }
    }
}
