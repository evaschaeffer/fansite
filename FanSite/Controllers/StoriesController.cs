using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FanSite.Controllers
{
    public class StoriesController : Controller
    {
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
