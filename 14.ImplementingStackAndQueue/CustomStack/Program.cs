using System;

namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Peek());
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.ForEach(Console.WriteLine);
        }
    }
}
