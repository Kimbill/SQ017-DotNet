﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList 
{
    /// <summary>
    /// Creates the linkage for the nodes of the linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Size;

        /// <summary>
        /// Starts out with its data set as null until an item is added to it
        /// </summary>
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        /// <summary>
        /// returns the number of items in the list.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return Size;
        }

        /// <summary>
        /// checks if the list is empty and returns either true or false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Size == 0;
        }

        /// <summary>
        /// Inserts a new Node at the end of the list and returns the current size of the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Add(T item)
        {
            var newNode = new Node<T>(item);
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                //Tail = newNode;
            }
            Tail = newNode;
            Size++;
            return Size;
        }

        /// <summary>
        /// Searches through the linked list starting from the head to get the first occurence of the item. 
        /// If the item is found, removes it and returns true but if item is not found, it returns false.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            Node<T> current = Head;

            if (IsEmpty())
                throw new Exception("There are no items in the list");

            if (Check(item))
            {
                if(Size == 1)
                {
                    Head = Tail = null;
                    Size--;
                    return true;
                }
                current.Next = current.Next.Next;
                Size--;
                return true;
            }
            return false;
            
        }

        /// <summary>
        /// Checks for a specified item in the linked list. Returns true if found and false if not found. 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Check(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(item))
                    return true;
                current = current.Next;
            }
                
            return false;
        }

        /// <summary>
        /// Returns the index of an item or returns -1 if the item is not found 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Index(T item)
        {
            Node<T> current = Head;
            int index = 0;

            while (Check(item) != false)
            {
                if (current.Data.Equals(item))
                    return index;
                current = current.Next;
                index++;
            }
           
            return -1;
        }

        // this will automatically create the 
        // appropriate class for you
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // this will invoke the public generic
            // version, so there is no recursion
            return this.GetEnumerator();
        }


    }
}
