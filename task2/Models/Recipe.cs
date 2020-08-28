using System.Collections.Generic;

namespace task2.Models
{
    class Recipe : Json
    {
        public string Description { get; set; }
        public List<string> Cooking { get; set; }
        public List<string> Ingredients { get; set; }

    }
}