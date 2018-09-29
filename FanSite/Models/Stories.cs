using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanSite.Models
{
    public class Stories
    {
        [Required(ErrorMessage = "Please enter a title to your story.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the date the story occured.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please enter the story here.")]
        public string Text { get; set; }
    }
}
