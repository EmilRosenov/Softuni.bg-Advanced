using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class CustomStack<T>: IEnumerable<T>
    {
        private List<T> customStack;
        public int Count { get; set; }

        public CustomStack(params T[] data)
        {
            customStack = new List<T>(data);
            
        }

        public void Push(params T[] num)
        {
            customStack.AddRange(num);

            foreach (var element in num)
            {
                Count++;
            }
            
        }
        public void Pop()
        {
            if (customStack.Count==0)
            {
                Console.WriteLine("No elements");
                   
            }
            else
            {
                customStack.RemoveAt(customStack.Count - 1);
                Count--;
            }
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in customStack.ToArray().Reverse())
            {
                yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
    }
}
