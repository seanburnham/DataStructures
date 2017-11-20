using System;
namespace LinkedLists
{
    public class LinkedList
    {
        Node head;
        private int size;

        public LinkedList()
        {
           // Creates a linked list.

			head = null;
            size = 0;
        }

        //Prints a representation of the entire list
        public void debug_print()
        {
            string output = "";
            Node n = head;
            output += size + " >>> ";

            while (n != null)
            {
                output += n.accessNode;
                if(n.next != null)
                {
                    output += ", ";
                }
                n = n.next; 
            }

            Console.WriteLine(output);
        }

		//Retrieves the Node object at the given index.  Throws an exception if the index is not within the bounds of the linked list.
		private Node getNode(int index)
        {
            Node n = head;
            int iCount = 0;

            while(true)
            {
                if(n == null) //throw exception
                {
                    throw new System.Exception("Error: " + index + " is not within the bounds of the current list.");
                }
                if(iCount == index)
                {
                    return n;
                }

                n = n.next;
                iCount++;
            }
        }

        //Adds an item to the end of the list
        public void Add(string item)
        {
			if (head == null)
			{
				head = new Node(item);
				size = 1;
				return;
			}

            Node n = head;

            while(n.next != null)
            {
                n = n.next;
            }

            n.next = new Node(item);

            size++;
        }

        //Inserts an item at the given index, shifting remaining items right 
        public void insert(int index, string item)
        {
			Node n = head;
			Node prev = null;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: " + index + " is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
					if (index == 0)
					{
						head = new Node(item);
                        head.next = n;
					}
					else
					{
						prev.next = new Node(item);
                        prev.next.next = n;
					}
                    size++;
					return;

				}

				prev = n;
				n = n.next;
				iCount++;
			}

        }

        //Sets the given item at the given index.  Throws an exception if the index is not within the bounds of the array.
        public void setItem(int index, string item)
        {
			Node n = head;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: " + index + " is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
                    n.accessNode = item;
                    return;
				}

				n = n.next;
				iCount++;
			}

        }

        //Retrieves the item at the given index.  Throws an exception if the index is not within the bounds of the array.
        public string getItem(int index)
        {
			Node n = head;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: " + index + " is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
					return n.accessNode;
				}

				n = n.next;
				iCount++;
			}
        }

		//Deletes the item at the given index. Throws an exception if the index is not within the bounds of the linked list..
		public void deleteItem(int index)
        {
			Node n = head;
            Node prev = null;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: " + index + " is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
                    if(index == 0)
                    {
                        head = n.next;
                    }
                    else
                    {
                        prev.next = n.next;    
                    }
                    size--;
                    return;

				}

                prev = n;
				n = n.next;
				iCount++;
			}
        }

        //Swaps the values at the given indices.
        public void swap(int index1, int index2)
        {
			Node temp1 = getNode(index1);
            string tempValue = temp1.accessNode;
            Node temp2 = getNode(index2);

            temp1.accessNode = temp2.accessNode;
            temp2.accessNode = tempValue;
			
        }

    }

    //Creates a node to be used in the linkedlist class
    public class Node
    {
        private string _value;
        public Node next = null;

        public Node(string val)
        {
            _value = val;

        }

        //Accesses the vlaue stored in the node 
        public string accessNode
        {
            get{
                return _value;
            }    

            set{
                _value = value;
            }
        }

        //Returns the value that is held in the given node.
        public string debugNode()
        {
            return accessNode;
        }
    }

}
