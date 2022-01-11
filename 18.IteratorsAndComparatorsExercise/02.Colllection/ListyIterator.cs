using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _02.Colllection
{
    public class ListyIterator<T> : IEnumerable<T>, IEnumerator<T>
    {
        private int currIndex;
        private List<T> collection;

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
            currIndex = 0;
        }

        public void Print()
        {
            if (collection.Count <= 0)
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

        public void PrintAll()
        {
            foreach (var item in collection)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool MoveNext()
        {
            if (++currIndex < collection.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset() { }


        public void Dispose() { }

    }
}
