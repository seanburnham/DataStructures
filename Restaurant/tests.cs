using System;
using Restaurant;

namespace Tests
{
    public class tests
    {
        //Runs the test methods instantiated below the main function.
		public static void Main(string[] args)
        {
            Console.WriteLine("Circular Linked List Test");
            try
            {
               new circularTest(); 
            }
            catch
            {
                Console.WriteLine("Out of bounds error!");
            }
            Console.WriteLine();
            Console.WriteLine("Doubly Linked List Test");
			try
			{
				new doublyTest();
			}
			catch
			{
				Console.WriteLine("Out of bounds error!");
			}
            Console.WriteLine();
            Console.WriteLine("Queue Test");
			try
			{
				new queueTest();
			}
			catch
			{
				Console.WriteLine("Out of bounds error!");
			}
            Console.WriteLine();
            Console.WriteLine("Stack Test");
			try
			{
				new stackTest();
			}
			catch
			{
				Console.WriteLine("Out of bounds error!");
			}
            Console.WriteLine();
            Console.WriteLine("Linked List Test");
			try
			{
				new llTest();
			}
			catch
			{
				Console.WriteLine("Out of bounds error!");
			}
		}

        public tests()
        {
             
        }

        //Used to test circular linked list methods
		public class circularTest
		{
			Restaurant.circularList testList;

            public circularTest()//circularList list)
			{
                testList = new Restaurant.circularList();
                testAdd();
                testDebug();
                testDelete();
                testDebug();
                testInsert();
                testDebug();
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
				testList.insert(5, "d");
			}

		}

		//Used to test doubly linked list methods
		public class doublyTest
		{
			Restaurant.doublyLinkedList testList;

            public doublyTest()//doublyLinkedList list)
			{
				testList = new Restaurant.doublyLinkedList();
				testAdd();
				testDebug();
				testDelete();
				testDebug();
				testInsert();
				testDebug();
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
				testList.insert(2, "d");
			}

		}

		//Used to test queue methods
		public class queueTest
		{
			Restaurant.queue testList;

            public queueTest()//ueue list)
			{
				testList = new Restaurant.queue();
				testAdd();
				testDebug();
				testDelete();
				testDebug();
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

		//Used to test stack methods
		public class stackTest
		{
			stack testList;

            public stackTest()//stack list)
			{
				testList = new Restaurant.stack();
				testAdd();
				testDebug();
				testDelete();
				testDebug();
			}


			public void testAdd()
			{
				testList.push("a");
				testList.push("b");
				testList.push("c");
			}

			public void testDebug()
			{
				testList.debug_print();
			}

			public void testDelete()
			{
				testList.pop();
			}
		}

		//Used to linked list methods
		public class llTest
		{
			Restaurant.linkedList testList;

			public llTest()
			{
				testList = new Restaurant.linkedList();
				testAdd();
				testDebug();
				testDelete();
				testDebug();
				testInsert();
				testDebug();
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
}
