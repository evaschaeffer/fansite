﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
    }
}
