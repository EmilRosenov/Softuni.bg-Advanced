using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {

        private LInkedListItem first = null;
        private LInkedListItem last = null;

        public int Count //read-only prop
        {

            get
            {
                var count = 0;
                var current = first;

                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }

        }

        //adds an element at the beginning of the collection
        public void AddFirst(int element)
        {
            var newItem = new LInkedListItem(element);
            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first=newItem;
            }
        }

        //adds an element at the end of the collection
        public void AddLast(int element)
        {
            var newItem = new LInkedListItem(element);
            if (last == null) // or first == null
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                last.Next = newItem;
                newItem.Previous = last;
                last = newItem;
            }
        }

        //removes the element at the beginning of the collection
        public int RemoveFirst()
        {

            if (first == null)
            {
                return 0;
                //ToDO: Exceptions
            }

            var currentFirstValue = first.Value;
            if (first == last) //1 item
            {
                first = null;
                last = null;
            }
            else // more than 1 item
            {
                var newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }

            return currentFirstValue;
        }

        //removes the element at the end of the collection
        public int RemoveLast()
        {
            if (first == null)
            {
                return 0;
                //ToDO: Exceptions
            }

            int currentLastValue = last.Value;
            if (first == last) //1 item
            {
                first = null;
                last = null;
            }
            else // more than 1 item
            {
                var newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }
            return currentLastValue;
        }

        //goes through the collection and executes a given action
        public void ForEach(Action<int> action)
        {
            var current = first;

            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        //returns the collection as an array
        public int[] ToArray()
        {

            var array = new int[Count];
            var current = first;
            var index = 0;
            while (current!=null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }

            return array;
        }
    }
}
