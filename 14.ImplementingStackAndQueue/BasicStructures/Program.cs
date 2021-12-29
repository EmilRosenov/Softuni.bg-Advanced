using System;

namespace BasicStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(30);
            list.Add(30);
            list.Print();
            list.Swap(0, 1);
            list.Print();
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.Print();
            //list.RemoveAt(0);
            //list.RemoveAt(0);
            Console.WriteLine(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //list.Add(30);


            
        }
        // void Add(int element) - Adds the given element to the end of the list
        // int RemoveAt(int index) - Removes the element at the given index
        // bool Contains(int element) - Checks if the list contains the given element returns(True or False)
        // void Swap(int firstIndex, int secondIndex) - Swaps the elements at the given indexes
           
    }
}
