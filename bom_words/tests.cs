using System;
using BoMSort;

namespace Tests
{
	public class tests
	{
      
		//Runs the test methods instantiated below the main function.
		public static void Main(string[] args)
		{
            worddata[] testList = CreateTestData();

            Console.WriteLine("Unsorted List");

            foreach(worddata thing in testList)
            {
                Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent);
            }
			Console.WriteLine();

            Console.WriteLine("Bubble Sort Test:");
			try
			{
                testList = bubblesortTest();
			}
			catch
			{
				Console.WriteLine("Error!");
			}

			foreach (worddata thing in testList)
			{
				Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent);
			}

			Console.WriteLine();

            Console.WriteLine("Insertion Sort Test:");
			try
			{
				testList = insertionSortTest();
			}
			catch
			{
				Console.WriteLine("Error!");
			}

			foreach (worddata thing in testList)
			{
				Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent);
			}

			Console.WriteLine();

            Console.WriteLine("Selection Sort Test:");
			try
			{
				testList = selectionSortTest();
			}
			catch
			{
				Console.WriteLine("Error!");
			}

			foreach (worddata thing in testList)
			{
				Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent);
			}
			
		}

		public tests()
		{

		}


        static public worddata[] CreateTestData()
        {
			worddata[] testList = new worddata[4];

            testList[0] = new worddata("Jeremiah","happy", 85, 7.4);
            testList[1] = new worddata("Isaiah", "confusing", 32, 4.4);
            testList[2] = new worddata("John", "amazing", 22, 0.4);
            testList[3] = new worddata("Daniel", "the", 85, 12.4);

            return testList;
        }


		//Used to test bubblesort methods
		static public worddata[] bubblesortTest()
		{
            worddata[] testList = CreateTestData();
            worddata[] newTestList;

            newTestList = new bubblesort(testList).getWorddata();

            return newTestList;
		}

		//Used to test doubly Insertion Sort methods
		static public worddata[] insertionSortTest()
		{
			worddata[] testList = CreateTestData();
			worddata[] newTestList;

			newTestList = new insertionsort(testList).getWorddata();

			return newTestList;
		}

		//Used to test selection sort methods
		static public worddata[] selectionSortTest()
		{
			worddata[] testList = CreateTestData();
			worddata[] newTestList;

			newTestList = new selectionsort(testList).getWorddata();

			return newTestList;
		}
	}
}
