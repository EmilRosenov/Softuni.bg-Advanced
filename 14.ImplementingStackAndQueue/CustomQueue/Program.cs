using System;

namespace CustomQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Print();
            //queue.Dequeue();
            queue.Enqueue(2);
            queue.Print();
            
            Console.WriteLine(queue.Peek());
            
            queue.Print();
            Console.WriteLine(queue.Peek());
            queue.Clear();
            //Console.WriteLine(queue.Peek());
            queue.Enqueue(7);
            queue.Enqueue(9);
            queue.Enqueue(4);
            queue.Enqueue(4);
            queue.Print();
            queue.Enqueue(9);
            queue.ForEach(Console.WriteLine);
            queue.Print();
            //ToDo:Shrink();

            //queue.Enqueue(3);
            //queue.Enqueue(5);
            // queue.Peek();

            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Print();
            //Console.WriteLine(queue.Count);
            //queue.Enqueue(5);
            //queue.Print();
            //queue.Enqueue(9);
            //queue.Print();
            //Console.WriteLine("*, 50");
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Print();
        }
    }
}
