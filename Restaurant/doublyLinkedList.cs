using System;
namespace Restaurant
{
    public class doublyLinkedList
    {
		public Node head;
        Node prev;
        public Node tail;
		public int size;

		public doublyLinkedList()
		{
            // Creates a linked list.
			head = null;
            prev = null;
            tail = null;
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
				if (n.next != null)
				{
					output += ", ";
				}
				n = n.next;
			}

            n = tail;
            output += " >>> ";

			while (n != null)
			{
				output += n.accessNode;
				if (n.prev != null)
				{
					output += ", ";
				}
				n = n.prev;
			}

			Console.WriteLine(output);
		}

		//Retrieves the Node object at the given index.  Throws an exception if the index is not within the bounds of the linked list.
		private Node getNode(int index)
		{
			Node n = head;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: The given index is not within the bounds of the current list.");
				}
				if (iCount == index)
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
                head.prev = null;
                tail = head;
				size = 1;
				return;
			}

			Node n = head;

			while (n.next != null)
			{
				n = n.next;
			}

			n.next = new Node(item);
            n.next.prev = n;
            tail = n.next;

			size++;
		}

		//Inserts an item at the given index, shifting remaining items right 
		public void insert(int index, string item)
		{
			Node n = head;
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: The given index is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
					if (index == 0)
					{
						head = new Node(item);
						head.next = n;
                        n.prev = head;
                        head.prev = null;
					}
					else
					{
						prev.next = new Node(item);
                        prev.next.prev = prev;
						prev.next.next = n;
                        n.prev = prev.next;
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
					throw new System.Exception("Error: The given index is not within the bounds of the current list.");
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
					throw new System.Exception("Error: The given index is not within the bounds of the current list.");
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
			int iCount = 0;

			while (true)
			{
				if (n == null) //throw exception
				{
					throw new System.Exception("Error: The given index is not within the bounds of the current list.");
				}
				if (iCount == index)
				{
					if (index == 0)
					{
						head = n.next;
                        head.prev = null;
					}
					else
					{
						prev.next = n.next;
                        if(n.next != null)
                        {
                            n.next.prev = prev;

                        }
                        else
                        {
                            tail = prev;
                        }

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

	public class doublyTest
	{
		doublyLinkedList testList;

		public doublyTest(doublyLinkedList list)
		{
			testList = list;
		}


		public void testAdd()
		{
			testList.Add("a");
			testList.Add("b");
			testList.Add("c");
		}

		public void testDebug()
		{
			testList.debug_print();
		}

		public void testDelete()
		{
			testList.deleteItem(2);
		}

		public void testInsert()
		{
			testList.insert(4, "d");
		}

	}
}
