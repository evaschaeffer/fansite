using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public static class StoryRepository
    {
        private static List<Stories> stories = new List<Stories>();

        public static IEnumerable<Stories> Stories
        {
            get
            {
                return stories;
            }
        }
        public static void AddStory(Stories story)
        {
            stories.Add(story);
        }
    }
}
