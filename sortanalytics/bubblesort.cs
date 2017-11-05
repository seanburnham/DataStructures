using System;
using System.Collections.Generic;
namespace SortAnalytics
{
    public class bubblesort
    {
        private List<long> myList;
        private List<double> myDoubleList;

        //Creates a new object holding a list of ints
        public bubblesort(List<long> newList)
        {
            myList = newList;
            myList = bubbleSortInts();
        }

        public List<long> getList() {
            return myList;
        }

        //Creates a new object holding a list of doubles
        public bubblesort(List<double> newList)
        {
            myDoubleList = newList;
            myDoubleList = bubbleSortDouble();
        }

        public List<double> getDoubleList()
        {
            return myDoubleList;
        }

        //Uses bubble sort algorithm to sort ints lowest to highest
        public List<long> bubbleSortInts()
        {
            long temp;
            int numLength = myList.Count;
            //sorting an array
            for (int i = 1; i <= numLength - 1; i++)
            {
                for (int j = 0; j < numLength - 1; j++)
                {
                    if (myList[j + 1] < myList[j])
                    {
                        temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;
                    }
                }
            }
            return myList;
        }

        //Uses bubble sort algorithm to sort doubles lowest to highest
        public List<double> bubbleSortDouble()
        {
            double temp;
            int numLength = myDoubleList.Count;
            //sorting an array
            for (int i = 1; i <= numLength - 1; i++)
            {
                for (int j = 0; j < numLength - 1; j++)
                {
                    if (myDoubleList[j + 1] < myDoubleList[j])
                    {
                        temp = myDoubleList[j];
                        myDoubleList[j] = myDoubleList[j + 1];
                        myDoubleList[j + 1] = temp;
                    }
                }
            }
            return myDoubleList;
        }

    }
}
