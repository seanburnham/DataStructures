using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SortAnalytics
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Dictionary<string, string> Filenames = new Dictionary<string, string>();

            Filenames.Add("list1.txt", "int");
            Filenames.Add("list2.txt", "int");
            Filenames.Add("list3.txt", "int");
            Filenames.Add("list4.txt", "int");
            Filenames.Add("list5.txt", "double");
            Filenames.Add("list6.txt", "int");


            foreach (KeyValuePair<string, string> thing in Filenames)
            {
                //Array to hold results objects for each sort of the text file
                results[] myResults = new results[5];

                string line;
                List<long> myList = new List<long>();
                List<double> myDoubleList = new List<double>();

                if(thing.Value == "int")
                {
                    // Read the file and store in a list line by line.  
                    System.IO.StreamReader file = new System.IO.StreamReader(thing.Key);
                    while ((line = file.ReadLine()) != null)
                    {
                        myList.Add(long.Parse(line));
                    }

                    file.Close();

                    //Create an array of lists to hold 1000 copies of the unsorted lists just read in from txt files
                    List<long>[] unsortedArray = new List<long>[1000];

                    for (int i = 0; i < 1000; i++)
                    {
                        unsortedArray[i] = myList;
                    }

                    //Used to calculate time spent sorting the lists
                    Stopwatch stopWatch = new Stopwatch();

                    //######################## QUICKSORT ############################
                    List<long>[] quicksortArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        quicksortArray[i] = new quicksort(unsortedArray[i]).getList();
                    }

                    stopWatch.Stop();

                    myResults[0] = new results("Quick Sort", stopWatch.Elapsed, quicksortArray[0]);
                    stopWatch.Reset();

                    //######################## BUBBLESORT ############################
                    List<long>[] bubbleArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        bubbleArray[i] = new bubblesort(unsortedArray[i]).getList();
                    }

                    stopWatch.Stop();

                    myResults[1] = new results("Bubble Sort", stopWatch.Elapsed, bubbleArray[0]);
                    stopWatch.Reset();

                    //######################## INSERTIONSORT ############################
                    List<long>[] insertionArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        insertionArray[i] = new insertionsort(unsortedArray[i]).getList();
                    }

                    stopWatch.Stop();

                    myResults[2] = new results("Insertion Sort", stopWatch.Elapsed, insertionArray[0]);
                    stopWatch.Reset();

                    //######################## SELECTIONSORT ############################
                    List<long>[] selectionArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        selectionArray[i] = new selectionsort(unsortedArray[i]).getList();
                    }

                    stopWatch.Stop();

                    myResults[3] = new results("Selection Sort", stopWatch.Elapsed, selectionArray[0]);
                    stopWatch.Reset();

                    //######################## NATIVESORT ############################
                    //List<long>[] nativeArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        unsortedArray[i].Sort();
                    }

                    stopWatch.Stop();

                    myResults[4] = new results("Native Sort", stopWatch.Elapsed, unsortedArray[0]);



                    //Print out information

                    //Sorts array by fastest time taken to sort the 1000 lists
                    Array.Sort(myResults, delegate (results x, results y) { return x.duration.CompareTo(y.duration); });
                    Console.WriteLine(thing.Key);

                    string fastestTime = myResults[0].duration.ToString("s\\.ffffff");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(myResults[i].name);
                        Console.WriteLine(myResults[i].duration.ToString("s\\.ffffff"));

                        double relativeTime = (double.Parse(myResults[i].duration.ToString("s\\.ffffff")) - double.Parse(fastestTime)) / double.Parse(fastestTime); //100 * (algorithm time - fastest time) / fastest time
                        Console.WriteLine(Convert.ToInt32(relativeTime) + "%");

                        var first = myResults[i].nums.Take(10);
                        int counter = 0;

                        Console.Write("First 10: ");
                        foreach (long j in first)
                        {
                            if (counter != 9 && counter < myResults[i].nums.Count - 1)
                            {
                                Console.Write(j + ", ");
                                counter++;
                            }
                            else
                            {
                                Console.Write(j);
                                counter++;
                            }

                        }

                        var last = myResults[i].nums.Reverse<long>().Take(10).Reverse();
                        counter = 0;
                        Console.WriteLine();
                        Console.Write("Last 10: ");
                        foreach (long s in last)
                        {
                            if (counter != 9 && counter < myResults[i].nums.Count - 1)
                            {
                                Console.Write(s + ", ");
                                counter++;
                            }
                            else
                            {
                                Console.Write(s);
                                counter++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                    }

                    //100 * (algorithm time - fastest time) / fastest time
                }
                else
                {
                    // Read the file and store in a list line by line.  
                    System.IO.StreamReader file = new System.IO.StreamReader(thing.Key);
                    while ((line = file.ReadLine()) != null)
                    {
                        myDoubleList.Add(double.Parse(line));
                    }

                    file.Close();

                    //Create an array of lists to hold 1000 copies of the unsorted lists just read in from txt files
                    List<double>[] unsortedArray = new List<double>[1000];

                    for (int i = 0; i < 1000; i++)
                    {
                        unsortedArray[i] = myDoubleList;
                    }

                    //Used to calculate time spent sorting the lists
                    Stopwatch stopWatch = new Stopwatch();

                    //######################## QUICKSORT ############################
                    List<double>[] quicksortArray = new List<double>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        quicksortArray[i] = new quicksort(unsortedArray[i]).getDoubleList();
                    }

                    stopWatch.Stop();

                    myResults[0] = new results("Quick Sort", stopWatch.Elapsed, quicksortArray[0]);
                    stopWatch.Reset();

                    //######################## BUBBLESORT ############################
                    List<double>[] bubbleArray = new List<double>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        bubbleArray[i] = new bubblesort(unsortedArray[i]).getDoubleList();
                    }

                    stopWatch.Stop();

                    myResults[1] = new results("Bubble Sort", stopWatch.Elapsed, bubbleArray[0]);
                    stopWatch.Reset();

                    //######################## INSERTIONSORT ############################
                    List<double>[] insertionArray = new List<double>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        insertionArray[i] = new insertionsort(unsortedArray[i]).getDoubleList();
                    }

                    stopWatch.Stop();

                    myResults[2] = new results("Insertion Sort", stopWatch.Elapsed, insertionArray[0]);
                    stopWatch.Reset();

                    //######################## SELECTIONSORT ############################
                    List<double>[] selectionArray = new List<double>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        selectionArray[i] = new selectionsort(unsortedArray[i]).getDoubleList();
                    }

                    stopWatch.Stop();

                    myResults[3] = new results("Selection Sort", stopWatch.Elapsed, selectionArray[0]);
                    stopWatch.Reset();

                    //######################## NATIVESORT ############################
                    //List<long>[] nativeArray = new List<long>[1000];
                    stopWatch.Start();

                    for (int i = 0; i < 1000; i++)
                    {
                        unsortedArray[i].Sort();
                    }

                    stopWatch.Stop();

                    myResults[4] = new results("Native Sort", stopWatch.Elapsed, unsortedArray[0]);



                    //Print out information

                    //Sorts array by fastest time taken to sort the 1000 lists
                    Array.Sort(myResults, delegate (results x, results y) { return x.duration.CompareTo(y.duration); });
                    Console.WriteLine(thing.Key);

                    string fastestTime = myResults[0].duration.ToString("s\\.ffffff");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(myResults[i].name);
                        Console.WriteLine(myResults[i].duration.ToString("s\\.ffffff"));

                        double relativeTime = (double.Parse(myResults[i].duration.ToString("s\\.ffffff")) - double.Parse(fastestTime)) / double.Parse(fastestTime); //100 * (algorithm time - fastest time) / fastest time
                        Console.WriteLine(Convert.ToInt32(relativeTime) + "%");

                        var first = myResults[i].doubleNums.Take(10);
                        int counter = 0;

                        Console.Write("First 10: ");
                        foreach (double j in first)
                        {
                            if (counter != 9 && counter < myResults[i].doubleNums.Count - 1)
                            {
                                Console.Write(j + ", ");
                                counter++;
                            }
                            else
                            {
                                Console.Write(j);
                                counter++;
                            }

                        }

                        var last = myResults[i].doubleNums.Reverse<double>().Take(10).Reverse();
                        counter = 0;
                        Console.WriteLine();
                        Console.Write("Last 10: ");
                        foreach (double s in last)
                        {
                            if (counter != 9 && counter < myResults[i].doubleNums.Count - 1)
                            {
                                Console.Write(s + ", ");
                                counter++;
                            }
                            else
                            {
                                Console.Write(s);
                                counter++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                }

            }

        }
    }
}

