using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class LInkedListItem
    {
        public LInkedListItem(int value)
        {
            this.Value = value;
        }

        public LInkedListItem Previous { get; set; }
        public LInkedListItem Next { get; set; }
        public int Value { get; set; }
    }
}
