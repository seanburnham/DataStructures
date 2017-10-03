using System;
namespace Restaurant
{
    public class queue
    {
		/*
		 * A linked list implementation of a queue.
		 * This contains a LinkedList internally.It does not extend LinkedList.
		 * In other words, this class uses "Composition" rather than "Inheritance"
        */
		linkedList myList;

		//Constructor
		public queue(linkedList list)
        {
            myList = list;    
        }

		//Default Constructor
		public queue()
		{
            myList = new linkedList();
		}

		//Prints a representation of the entire queue.
		public void debug_print()
        {
            myList.debug_print();
        }

		//Adds an item to the end of the queue
		public void enqueue(string item)
        {
            myList.Add(item);
        }

		/*Dequeues the first item from the list.  This involves the following:
            1. Get the first node in the list.
            2. Delete the node from the list.
            3. Return the value of the node.
         */
        public string dequeue()
        {
            string temp = myList.getItem(0);
            myList.deleteItem(0);

            return temp;
        }

		//Returns the number of items in the queue
		public int size()
        {
           return myList.getSize();
        }

    }

}
