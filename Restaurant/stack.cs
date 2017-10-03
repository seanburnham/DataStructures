using System;
namespace Restaurant
{
    public class stack : linkedList
    {
		/*
		 * A linked list implementation of a stack.
		 * This extends the LinkedList class, adding the typical stack methods to the class.
		 * In other words, this class uses "Inheritance" instead of "Composition".
        */

        //Default Constructor
        public stack()
        {
            
        }

		//Pushes an item onto the stack
		public void push(string item)
        {
            Add(item);
        }

		/*
         * Pops an item from the stack.  This is done as follows:
            1. Get the last node in the list.
            2. Delete the node from the list.
            3. Return the value of the node.
        */
        public string pop()
        {
            string temp = getItem(getSize() - 1);
            deleteItem(getSize() - 1);
            return temp;
        }

    }
}
