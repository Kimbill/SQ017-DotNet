using SinglyLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyQueue
{
    public class MyQueue<T> : IEnumerable<T>
    {
        MyLinkedList<T> myQueue = new MyLinkedList<T>();

        /// <summary>
        /// Adds an item to the tail of the queue 
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item)
        {
            myQueue.Add(item);
        }

        /// <summary>
        /// Removes and returns the first item added to the queue 
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (myQueue.IsEmpty())
                throw new Exception("There is no item in the Queue");

            Node<T> node = myQueue.Head;
            myQueue.Head = node.Next;
            myQueue.Size--;
            return node.Data;
        }

        
        /// <summary>
        /// Returns the number of items currently in the stack 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return myQueue.Length();
        }

        // this will automatically create the 
        // appropriate class for you
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = myQueue.Head;
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
