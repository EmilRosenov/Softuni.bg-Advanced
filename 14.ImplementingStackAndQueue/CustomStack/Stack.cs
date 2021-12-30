using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class Stack
    {
        private const int Inititalcapacity = 4;
        private int[] elements;
        public Stack()
        {
            elements = new int[Inititalcapacity];
        }
        public int Count { get; private set; }
        public void Push(int element)
        {
            if (Count==elements.Length)
            {
                Resize();
            }
            elements[Count++] = element;
        }
        public int Pop()
        {
            if (Count==0)
            {
                throw new InvalidOperationException();
            }
            int element = elements[Count - 1];

            Count--;
            if (Count<=elements.Length)
            {
                Shrink();
            }

            return element;
        }

       
        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return elements[Count - 1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
        }


        private void Resize()
        {
            int[] copyArray = new int[elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                copyArray[i] = elements[i];
            }
            elements = copyArray;
            //the code above equals this row:
            //Array.Copy(elements, copyArray, elements.Length);
            
        }
        private void Shrink()
        {
            int[] copyArray = new int[elements.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copyArray[i] = elements[i];
            }
            elements = copyArray;
        }



    }
}
