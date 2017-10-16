/*
 * Sean Burnham
 * IS 537
 * 10/13/2017
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BoMSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            worddata[] masterList = new worddata[0];

			//This is used to to rotate through each sort to make sure they all get used at least once as we run through the files.
            int sortCounter = 0;

			Dictionary<string, string> Filenames = new Dictionary<string, string>();

            Filenames.Add("1 Nephi", "01-1 Nephi.txt");
            Filenames.Add("2 Nephi", "02-2 Nephi.txt");
            Filenames.Add("Jacob", "03-Jacob.txt");
            Filenames.Add("Enos", "04-Enos.txt");
            Filenames.Add("Jarom", "05-Jarom.txt");
            Filenames.Add("Omni", "06-Omni.txt");
            Filenames.Add("Words of Mormon", "07-Words of Mormon.txt");
            Filenames.Add("Mosiah", "08-Mosiah.txt");
            Filenames.Add("Alma", "09-Alma.txt");
            Filenames.Add("Helaman", "10-Helaman.txt");
            Filenames.Add("3 Nephi", "11-3 Nephi.txt");
            Filenames.Add("4 Nephi", "12-4 Nephi.txt");
            Filenames.Add("Mormon", "13-Mormon.txt");
            Filenames.Add("Ether", "14-Ether.txt");
            Filenames.Add("Moroni", "15-Moroni.txt");

            Console.WriteLine("INDIVIDUAL BOOKS > 2%");

            //Run through each file and analyze the text of individual books
            foreach (KeyValuePair<string, string> item in Filenames)
			{
                worddata[] newSortedArray = analyzeText(item.Value, item.Key, sortCounter); 

				foreach(worddata thing in newSortedArray)
                {
                    if(thing.percent > 2)
                    {
                    Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent.ToString("0.0"));
                    }
                }

                Console.WriteLine();


                //Update the master list by merging the new book list into the master list
                merge updatedMaster = new merge(masterList, newSortedArray);

                masterList = updatedMaster.getMasterList();

                //This ensures each type of sort gets used
                sortCounter++;
                sortCounter %= 3;
			}

            //Prints out the merged master list after all the books have been analyzed.
            Console.WriteLine("MASTER LIST > 2%");
			foreach (worddata thing in masterList)
			{
				if (thing.percent > 2)
				{
                    Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent.ToString("0.0"));
				}
			}

            Console.WriteLine();

            //Prints the orderd list of all books and the stats around the word "christ" in the book
			Console.WriteLine("MASTER LIST == christ");
			foreach (worddata thing in masterList)
			{
                if (thing.word == "christ")
				{
					Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent.ToString("0.0"));
				}
			}

			Console.WriteLine();

            //Analyzes and prints all the word data for the entire Book of Mormon as a whole
			Console.WriteLine("FULL TEXT > 2%");
            worddata[] fullText = analyzeText("00-Book of Mormon.txt","Book of Mormon", 0);

            worddata[] newSortedArray1 = new insertionsort(fullText).getWorddata();

			foreach (worddata thing in newSortedArray1)
			{
				if (thing.percent > 2)
				{
					Console.WriteLine(thing.book + "," + thing.word + "," + thing.count + "," + thing.percent.ToString("0.0"));
				}
			}


		}


		static private worddata[] analyzeText(string Filename, string bookname, int sortCounter)
        {

			/*
             * Performs a very naive analysis of the words in the text, returning the SORTED list of WordData items
             * lowercase the entire text
             * split the text by whitespace to get a list of words
             * convert each word to the longest run of characters
             * eliminate any words that are empty after conversion to characters
             * count up the occurance of each word into a dictionary of: word -> count
             * create a WordData item for each word in our list of words
             * sort the WordData list using Bubble Sort, Insertion Sort, or Selection Sort:
             *      1. highest percentage [descending]
             *      2. highest count (if percentages are equal) [descending]
             * 
             *      3. lowest alpha order (if percentages and count are equal) [ascending]
             */

			// Read the file as one string.
			string text = System.IO.File.ReadAllText(Filename);

			//Convert everything to lowercase
			text = text.ToLower();

			//Split text on whitespace
			string[] separators = { " ", "\n" };
			string[] sepWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

			//Only keep the longest strings of characters that make up a word
			// for example "(between)" becomes "between" or "people-Lehi" becomes "people" because we only keep the longest run of letters
			string[] countWords = new string[sepWords.Length];
			int badCount = 0;
			for (int i = 0; i < sepWords.Length; i++)
			{
				string match = Regex.Match(sepWords[i], @"([a-zA-Z]+)").Value;
				if (match == "" || match == null)
					badCount++;
				else
					countWords[i - badCount] = match;
			}

			//eliminate any words that are empty after conversion to characters
			string[] countWords1 = new string[sepWords.Length - badCount];
			for (int i = 0; i < sepWords.Length - badCount; i++)
			{
				countWords1[i] = countWords[i];
			}

			//Create dictionary to hold words and their count
			Dictionary<string, int> dic = new Dictionary<string, int>();

			//count up the occurance of each word into a dictionary of: word -> count
			foreach (string s in countWords1)
			{
				if (dic.Keys.Contains(s))
					dic[s] += 1;
				else
                    dic.Add(s, 1);
			}

			//Creates an array of objects to hold all word data
			worddata[] wordDataArray = new worddata[dic.Count];
			int iCount = 0;

			foreach (KeyValuePair<string, int> word in dic)
			{
                //Calculate percent and round to 1 decimal point
                double tempNumber = word.Value / (double)countWords1.Length * 100;
                tempNumber = Math.Round(tempNumber, 1);

                wordDataArray[iCount] = new worddata(bookname, word.Key, word.Value, tempNumber);
				iCount++;
			}

			worddata[] newSortedArray;
			//This just rotates the sort being used on each file
			if (sortCounter == 0)
			{
				newSortedArray = new insertionsort(wordDataArray).getWorddata();
			}
			else if (sortCounter == 1)
			{
				newSortedArray = new bubblesort(wordDataArray).getWorddata();
			}
			else
			{
				newSortedArray = new selectionsort(wordDataArray).getWorddata();
			}

            return newSortedArray;

        }

	}
}
