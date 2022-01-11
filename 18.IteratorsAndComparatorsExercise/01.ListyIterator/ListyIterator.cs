using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private int currIndex;
        private List<T> collection;

       
        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currIndex = 0;
        }

        public void Print()
        {
            if (collection.Count<=0)
            {
                throw new ArgumentException("Invalid Operation!");
                
            }
            else
            {
                Console.WriteLine(collection[currIndex]);
            }

        }
        public bool HasNext() => currIndex < collection.Count - 1;
        
        public bool Move()
        {
            bool canMove = HasNext(); 
            if (canMove)
            {
                currIndex++;     
            }
            return canMove;
        }

        public void Reset() { }

        public void Dispose() { }

    }
}
