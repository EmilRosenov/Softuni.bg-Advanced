using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodStrings
{
    class Box<T>
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
