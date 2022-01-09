using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public IReadOnlyList<string> Authors { get; private set; }

        public string Title { get; private set; }
        public int Year { get; private set; }
        
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}"; 
        }
        public int CompareTo(Book other)
        {
            int ressult = this.Year.CompareTo(other.Year);
            if (ressult == 0)
            {
                ressult = this.Title.CompareTo(other.Title);
            }

            return ressult;

        }
    }
}
