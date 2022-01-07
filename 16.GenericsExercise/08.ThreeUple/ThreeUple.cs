using System;
using System.Collections.Generic;
using System.Text;

namespace _08.ThreeUple
{
    public class ThreeUple<Type1,Type2,Type3>
    {
        public ThreeUple(Type1 first,Type2 second,Type3 third)
        {
            First = first;
            Second = second;
            Third = third;
        }
        public Type1 First { get; set; }
        public Type2 Second { get; set; }
        public Type3 Third { get; set; }

        
        public string GetItems()
        {
            return $"{First} -> {Second} -> {Third}";
        }
    }
}
