using System;
using System.Collections.Generic;
using System.Text;

namespace _04072022
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public string ShowInfo()
        {
            return $"Name-{Name} Id-{Id} Price-{Price} AuthorName{AuthorName}";
        }
    }
}
