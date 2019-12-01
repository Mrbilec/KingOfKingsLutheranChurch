using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KingOfKingsLutheranChurch.Controllers
{
    public class AtKingOfKingsController : Controller
    {
        public IActionResult WhatWeBelieve()
        {
            return View();
        }

        public IActionResult WorshipService()
        {
            return View();
        }

        public IActionResult HolyCommunion()
        {
            return View();
        }
    }
}