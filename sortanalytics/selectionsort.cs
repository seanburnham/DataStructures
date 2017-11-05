using System;
using System.Collections.Generic;
namespace SortAnalytics
{
    public class selectionsort
    {
        private List<long> myList;
        private List<double> myDoubleList;

        //Creates a new object holding a list of ints
        public selectionsort(List<long> newList)
        {
            myList = newList;
            myList = selectSortInts();
        }

        public List<long> getList()
        {
            return myList;
        }

        //Creates a new object holding a list of doubles
        public selectionsort(List<double> newList)
        {
            myDoubleList = newList;
            myDoubleList = selectSortDouble();
        }

        public List<double> getDoubleList()
        {
            return myDoubleList;
        }

        //Uses selection sort algorithm to sort ints lowest to highest
        public List<long> selectSortInts()
        {
            //pos_min is short for position of min
            int pos_min; 
            long temp;
            for (int i = 0; i < myList.Count - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array
                for (int j = i + 1; j < myList.Count; j++)
                {
                    if (myList[j] < myList[pos_min])
                  {
                      //pos_max will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                  }
                }
                //if pos_max no longer equals i than a larger value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = myList[i];
                    myList[i] = myList[pos_min];
                    myList[pos_min] = temp;
                }
            }
            return myList;
        }


        //Uses selection sort algorithm to sort doubles lowest to highest
        public List<double> selectSortDouble()
        {
            //pos_min is short for position of min
            int pos_min;
            double temp;
            for (int i = 0; i < myDoubleList.Count - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array
                for (int j = i + 1; j < myDoubleList.Count; j++)
                {
                    if (myDoubleList[j] < myDoubleList[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }
                //if pos_min no longer equals i than a larger value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = myDoubleList[i];
                    myDoubleList[i] = myDoubleList[pos_min];
                    myDoubleList[pos_min] = temp;
                }
            }
            return myDoubleList;
        }

    }
}
