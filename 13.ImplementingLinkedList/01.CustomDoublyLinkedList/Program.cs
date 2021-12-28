using System;

namespace CustomDoublyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new DoublyLinkedList();
            list.AddFirst(3);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(2);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(1);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddLast(4);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(0);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddLast(100);
            Console.WriteLine(string.Join("-", list.ToArray()));
            
            list.RemoveFirst();
            //Console.WriteLine(string.Join("-", list.ToArray()));
            list.RemoveLast();
            //Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddLast(5);
            Console.WriteLine(string.Join("-", list.ToArray()));

            Console.WriteLine($"*Count: {list.Count}");
            list.ForEach(Console.WriteLine);
            

        }
    }
}
