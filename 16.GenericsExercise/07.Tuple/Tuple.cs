using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class MyTuple< T1, T2>
    {
        public MyTuple(T1 itemOne, T2 itemTwo)
        {
            ItemOne = itemOne;
            ItemTwo = itemTwo;
        }
        public T1 ItemOne { get; set; }
        public T2 ItemTwo { get; set; }

        public string GetItems()
        {
            return $"{ItemOne} -> {ItemTwo}";
        }
    }
}
