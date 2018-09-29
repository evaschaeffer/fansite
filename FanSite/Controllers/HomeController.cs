using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        
            // GET: /<controller>/
            public ViewResult History()
            {
                return View();
            }
        
        
            public ViewResult Sources()
            {
                return View();
            }
        
        public ViewResult ListResponses()
        {
            return View(StoryRepository.Stories);
        }
        // GET: /<controller>/
        public ViewResult Stories()
        {
            return View();
        }
        [HttpGet]
        public ViewResult StoryForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult StoryForm(Stories storyForm)
        {
            if (ModelState.IsValid)
            {
                StoryRepository.AddStory(storyForm);
                return View("SubmittedStory", storyForm);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}
