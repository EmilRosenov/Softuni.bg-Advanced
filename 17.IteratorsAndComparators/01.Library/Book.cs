using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public IReadOnlyList<string> Authors { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

    }
}
