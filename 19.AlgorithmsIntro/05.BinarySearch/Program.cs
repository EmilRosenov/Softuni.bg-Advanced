using System;
using System.Linq;

namespace _05.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberToSearch = int.Parse(Console.ReadLine());

            int index = BinarySearch(array, numberToSearch);
            Console.WriteLine(index);
            
        }

        private static int BinarySearch(int[] array, int numberToSearch)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (numberToSearch > array[mid])
                {
                    low = mid + 1;
                }
                else if (numberToSearch < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
