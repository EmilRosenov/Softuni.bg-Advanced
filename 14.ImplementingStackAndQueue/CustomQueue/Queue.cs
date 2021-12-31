using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    public class Queue
    {
        private int[] sequence;
        private const int Capacity = 4;
        private const int FirstElementIndex = 0;

        public int Count { get; private set; }
        public int this[int i]
        {
            get
            {
                IsInRange(i);

                return sequence[i];
            }
            set
            {
                IsInRange(i);

                sequence[i] = value;
            }
        }
        public Queue()
        {
            sequence = new int[Capacity];
        }

        public void Enqueue(int element)
        {
            if (Count >= sequence.Length)
            {
                DoubleSize();
            }
            sequence[Count++] = element;
        }
        public int Dequeue()
        {
            if (Count==0)
            {
                throw new InvalidTimeZoneException();
            }

            Count--;
            int firstElement = sequence[FirstElementIndex];
            SwitchElements();
            return firstElement;
        }

        public int Peek()
        {
            int element = sequence[FirstElementIndex];
            if (Count==0)
            {
                throw new InvalidTimeZoneException();
            }
            return element;
            
        }
        public int Clear()
        {
            while (Count>0)
            {
                Count--;
            }
            //Console.WriteLine("0");
            return 0;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(sequence[i]);
            }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", sequence));
        }
        private void DoubleSize()
        {
            int[] tempArray = new int[sequence.Length * 2];
            for (int i = 0; i < sequence.Length; i++)
            {
                tempArray[i] = sequence[i];
            }
            sequence = tempArray;
        }
        private void IsInRange(int i)
        {
            if (i < 0 || i >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void SwitchElements()
        {
            sequence[FirstElementIndex] = default;
            for (int i = 1; i < sequence.Length; i++)
            {
                sequence[i - 1] = sequence[i];
            }
            sequence[sequence.Length - 1] = default;
        }



    }
}
