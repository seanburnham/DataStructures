using System;
using System.Collections.Generic;
namespace SortAnalytics
{
    public class quicksort
    {
        private List<long> myList;
        private List<double> myDoubleList;

        //Creates a new object holding a list of ints
        public quicksort(List<long> newList)
        {
            myList = newList;
            int left = 0;
            int right = myList.Count - 1;
            myList = quickSortInts(left, right);
        }

        //Creates a new object holding a list of doubles
        public quicksort(List<double> newList)
        {
            myDoubleList = newList;
            int left = 0;
            int right = myDoubleList.Count - 1;
            myDoubleList = quickSortDouble(left, right);
        }

        public List<long> getList()
        {
            return myList;
        }

        public List<double> getDoubleList()
        {
            return myDoubleList;
        }

        //Uses quicksort algorithm to sort ints lowest to highest
        public List<long> quickSortInts(int left, int right)
        {
            int i = left, j = right;
            long pivot = myList[(left + right) / 2];

            while (i <= j)
            {
                while (myList[i] < pivot)
                {
                    i++;
                }

                while (myList[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    long temp = myList[i];
                    myList[i] = myList[j];
                    myList[j] = temp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                quickSortInts(left, j);
            }

            if (i < right)
            {
                quickSortInts(i, right);
            }

            return myList;
        }


        //Uses quicksort algorithm to sort doubles lowest to highest
        public List<double> quickSortDouble(int left, int right)
        {
            int i = left, j = right;
            double pivot = myDoubleList[(left + right) / 2];

            while (i <= j)
            {
                while (myDoubleList[i] < pivot)
                {
                    i++;
                }

                while (myDoubleList[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    double temp = myDoubleList[i];
                    myDoubleList[i] = myDoubleList[j];
                    myDoubleList[j] = temp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                quickSortDouble(left, j);
            }

            if (i < right)
            {
                quickSortDouble(i, right);
            }

            return myDoubleList;
        }

    }
}
