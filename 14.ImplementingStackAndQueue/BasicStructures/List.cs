using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStructures
{
    public class List
    {
        private const int DefaultCapacity = 2;
        private int[] items;

        public List()
        {
            items = new int[DefaultCapacity];
        }

        public int Count { get; private set; }

        public int this[int i]
        {
            get
            {
                IsInRange(i);

                return items[i];
            }
            set
            {
                IsInRange(i);

                items[i] = value;
            }
        }

       

        public void Add(int element)
        {
            if (Count==items.Length)
            {
                Resize();
            }
            items[Count++] = element;

        }

        
        public int RemoveAt(int index)
        {
            IsInRange(index);

            int element = items[index];
            items[index] = 0;

            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
            Count--;

            //10-2->[] []
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return element;
        }

        private void Shrink()
        {
            int[] tempArray = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                tempArray[i] = items[i];
            }

            items = tempArray;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]==element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 ||firstIndex >= Count 
                || secondIndex<0 || secondIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            int tempElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempElement;
        }
        public void Print()
        {
            Console.WriteLine(string.Join(" ", items)); 
        }
        private void IsInRange(int i)
        {
            if (i < 0 || i >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void Resize()
        {
            int[] tempArray = new int[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
        }

    }
}
