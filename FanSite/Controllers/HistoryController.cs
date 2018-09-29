using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HistoryController : Controller
    {
        // GET: /<controller>/
        public ViewResult History()
        {
            return View();
        }
    }
}
