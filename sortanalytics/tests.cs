using System;
using SortAnalytics;
using System.Collections.Generic;

namespace Tests
{
    public class tests
    {

        //Runs the test methods instantiated below the main function.
        public static void Main(string[] args)
        {
            List<long> testList;// = CreateTestData();

            Console.WriteLine("Bubble Sort Test:");
            try
            {
                testList = bubblesortTest();

                foreach (long thing in testList)
                {
                    Console.WriteLine(thing);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }


            Console.WriteLine();

            Console.WriteLine("Insertion Sort Test:");
            try
            {
                testList = insertionSortTest();

                foreach (long thing in testList)
                {
                    Console.WriteLine(thing);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }


            Console.WriteLine();

            Console.WriteLine("Selection Sort Test:");
            try
            {
                testList = selectionSortTest();

                foreach (long thing in testList)
                {
                    Console.WriteLine(thing);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }

            Console.WriteLine();

            Console.WriteLine("Quick Sort Test:");
            try
            {
                testList = quicksortTest();

                foreach (long thing in testList)
                {
                    Console.WriteLine(thing);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }

            Console.WriteLine();

            Console.WriteLine("Native Sort Test:");
            try
            {
                testList = nativesortTest();

                foreach (long thing in testList)
                {
                    Console.WriteLine(thing);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }

        }

        public tests()
        {

        }


        //Used to test bubblesort methods
        static public List<long> bubblesortTest()
        {
            List<long> testList = new List<long>() {1,453,46,67,23,567,2,3,623,6,2,58,9};
            List<long> newTestList;

            newTestList = new bubblesort(testList).getList();

            return newTestList;
        }

        //Used to test doubly Insertion Sort methods
        static public List<long> insertionSortTest()
        {
            List<long> testList = new List<long>() {4};
            List<long> newTestList;

            newTestList = new insertionsort(testList).getList();

            return newTestList;
        }

        //Used to test selection sort methods
        static public List<long> selectionSortTest()
        {
            List<long> testList = new List<long>() {1,2,3,4,5,6,7,8,9};
            List<long> newTestList;

            newTestList = new selectionsort(testList).getList();

            return newTestList;
        }

        //Used to test quick sort methods
        static public List<long> quicksortTest()
        {
            List<long> testList = new List<long>() { 123432,3456456,768634,23,45,567,3243245,5862,3443436,58657,234234,5689,890,32423423,57,342,234345,456,5,678,234,234,456,567 };
            List<long> newTestList;

            newTestList = new quicksort(testList).getList();

            return newTestList;
        }

        //Used to test native sort methods
        static public List<long> nativesortTest()
        {
            List<long> testList = new List<long>();

            testList.Sort();
            return testList;
        }

    }
}
