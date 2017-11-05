using System;
using System.Collections.Generic;
namespace SortAnalytics
{
    public class insertionsort
    {
        private List<long> myList;
        private List<double> myDoubleList;

        //Creates a new object holding a list of ints
        public insertionsort(List<long> newList)
        {
            myList = newList;
            myList = InsertionSortInts();
        }

        public List<long> getList() {
            return myList;
        }

        //Creates a new object holding a list of doubles
        public insertionsort(List<double> newList)
        {
            myDoubleList = newList;
            myDoubleList = InsertionSortDouble();
        }

        public List<double> getDoubleList()
        {
            return myDoubleList;
        }

        //Uses insertion sort algorithm to sort ints lowest to highest
        public List<long> InsertionSortInts()
        {
            long temp;
            int j;
            for (int i = 1; i < myList.Count; i++)
            {
                temp = myList[i];
                j = i - 1;

                while (j >= 0 && myList[j] > temp)
                {
                    myList[j + 1] = myList[j];
                    j--;
                }

                myList[j + 1] = temp;
            }
            return myList;
        }


        //Uses insertion sort algorithm to sort doubles lowest to highest
        public List<double> InsertionSortDouble()
        {
            double temp;
            int j;
            for (int i = 1; i < myDoubleList.Count; i++)
            {
                temp = myDoubleList[i];
                j = i - 1;

                while (j >= 0 && myDoubleList[j] > temp)
                {
                    myDoubleList[j + 1] = myDoubleList[j];
                    j--;
                }

                myDoubleList[j + 1] = temp;
            }
            return myDoubleList;
        }
    }
}
