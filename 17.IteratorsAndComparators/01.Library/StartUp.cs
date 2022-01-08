using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book.Title);
            }


            //Book firstBook = new Book("3% Man", 2016);
            //string[] firstInput = Console.ReadLine().Split(", ");
            //for (int i = 0; i < firstInput.Length; i++)
            //{
            //    firstBook.Authors.Add(firstInput[i]);
            //}
            //
            //Console.WriteLine(string.Join(" --> ", firstBook.Authors));
        }
    }
}
