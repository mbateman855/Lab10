using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie()
        {
        }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
