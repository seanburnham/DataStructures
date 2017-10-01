using System;
namespace Restaurant
{
    //A circularly-linked list implementation that holds arbitrary objects.
    public class circularList
    {

        public Node head;
        private int size;
        public CircularLinkedListIterator songIter;

        public circularList()
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

            while (n.next != head)
            {
                output += n.accessNode;
                if (n.next != head)
                {
                    output += ", ";
                }
                n = n.next;
            }
            output += n.accessNode;
            Console.WriteLine(output);
        }

        //Prints a representation of the entire cycled list up to count items
        public void debug_cycle(int count)
        {
            string output = "";
            Node n = head;
            output += size + " >>> ";

            for (int i = 0; i < count; i++)
            {
                output += n.accessNode;
                if (i < count - 1)
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
                head.next = head;
                size = 1;
                return;
            }

            Node n = head;

            while (n.next != head)
            {
                n = n.next;
            }

            n.next = new Node(item);
            n.next.next = head;

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
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
                }
                if (iCount == index)
                {
                    if (index == 0)
                    {
                        Node tail = head;
                        head = new Node(item);
                        head.next = n;

                        //Fix tail pointing to new head
                        while(true)
                        {
                            if(tail.next == n)
                            {
                                tail.next = head;
                                break;
                            }

                            tail = tail.next;
                        }

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
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
                }
                if (iCount == index)
                {
                    n.accessNode = item;
                    return;
                }
                if (n.next == head)
                {
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
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
                if (n.next == head)
                {
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
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
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
                }
                if (iCount == index)
                {
                    if (index == 0)
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
                if (n.next == head)
                {
                    throw new System.Exception("Error: The given index is not within the bounds of the current list.");
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

    /*************************************************************************/
    //An iterator for the circular list
    public class CircularLinkedListIterator
    {
        circularList myList;
        private Node n;


        public CircularLinkedListIterator(circularList Iter)
        {
            myList = Iter;
            n = myList.head;
        }

        public bool has_next()
        {
            if (myList.head == null)
            {
                return false;
            }
            return true;
        }

        public string next()
        {
            Node tempNode = n;
            n = n.next;
            return tempNode.accessNode;
        }


    }


    public class circularTest
    {
        circularList testList;

        public circularTest(circularList list)
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
