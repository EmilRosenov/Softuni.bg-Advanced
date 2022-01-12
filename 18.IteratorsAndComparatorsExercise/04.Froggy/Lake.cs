using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Lake: IEnumerable<int>
    {
        private int[] stonePath;
        public Lake(int[] data)
        {
            stonePath = data; 
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stonePath.Length; i++)
            {
                if (i % 2==0)
                {
                    yield return stonePath[i];
                }
                
            }

            for (int i = stonePath.Length - 1; i >= 0; i--)
            {
                if (i % 2 !=0)
                {
                    yield return stonePath[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
