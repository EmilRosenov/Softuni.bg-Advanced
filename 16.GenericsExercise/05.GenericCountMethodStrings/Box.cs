using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }
        public void Swap(int first, int second)
        {
            T temp = items[first];
            items[first] = items[second];
            items[second] = temp;

        }
        public int GetGenericCount(T elementToCompare)
        {
            int counter = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(elementToCompare)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
