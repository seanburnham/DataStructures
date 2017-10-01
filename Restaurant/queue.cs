using System;
namespace Restaurant
{
    public class queue
    {
        linkedList myList;

        public queue(linkedList list)
        {
            myList = list;    
        }

		public queue()
		{
            myList = new linkedList();
		}

        public void debug_print()
        {
            myList.debug_print();
        }

        public void enqueue(string item)
        {
            myList.Add(item);
        }

        public string dequeue()
        {
            string temp = myList.getItem(0);
            myList.deleteItem(0);

            return temp;
        }

        public int size()
        {
           return myList.getSize();
        }

    }

	public class queueTest
	{
		queue testList;

		public queueTest(queue list)
		{
			testList = list;
		}


		public void testAdd()
		{
			testList.enqueue("a");
			testList.enqueue("b");
			testList.enqueue("c");
		}

		public void testDebug()
		{
			testList.debug_print();
		}

		public void testDelete()
		{
			testList.dequeue();
		}
	}
}
