using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {

        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            Books = books.OrderBy(x=>x.Year).ThenBy(x=>x.Title).ToList();

        }
        public IEnumerator<Book> GetEnumerator()
        {
            //return Books.GetEnumerator();
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        
        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;
            public List<Book> Books { get; set; }
            public LibraryIterator(List<Book> books)
            {
                Books = books;
            }
            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
