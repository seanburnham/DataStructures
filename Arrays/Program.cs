/*
 * Sean Burnham
 * IS 537
 * 9/15/2017
 */

using System;
using System.IO;
using System.Collections.Generic;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creates a list of lists that holds all the data brought in from the imported csv file.
            List<List<string>> list = importFile();

            //Creates a new array using the newly created array class
            ArrayClass myArray = new ArrayClass(); 

            //Runs through each item in the csv file now stored in a list and reads it into the program 
            foreach(List<string> item in list)
            {
                Console.WriteLine(item[item.Count - 1]);

                if(item[0] == "CREATE")
                {
                    myArray = new ArrayClass();
                }
                else if(item[0] == "DEBUG")
                {
                    myArray.debug_print();
                }
				else if (item[0] == "ADD")
				{
                    myArray.Add(item[1]);
				}
				else if (item[0] == "SET")
				{
                    myArray.setItem(Convert.ToInt32(item[1]), item[2]);
				}
				else if (item[0] == "GET")
				{
                    Console.WriteLine(myArray.getItem(Convert.ToInt32(item[1])));
				}
				else if (item[0] == "DELETE")
				{
					myArray.deleteItem(Convert.ToInt32(item[1]));
				}
				else if (item[0] == "INSERT")
				{
                    myArray.insert(Convert.ToInt32(item[1]), item[2]);
				}
				else if (item[0] == "SWAP")
				{
                    myArray.swap(Convert.ToInt32(item[1]),Convert.ToInt32(item[2]));
				}
            }

        }

        //Imports a csv file using a local path directory. 
		static private List<List<string>> importFile()
		{
            //This specifically searches the users local directory for a file called data.csv
			string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/data.csv";

			List<List<string>> list = new List<List<string>>();
            int count = 0;

			using (var reader = new StreamReader(path))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(',');

					List<string> temp = new List<string>();
					foreach (string item in values)
					{
						temp.Add(item);
					}

                    temp.Add(count.ToString() + ":" + line);
					list.Add(temp);
                    count++;
				}
			}
			return list;
		}
    }
}
