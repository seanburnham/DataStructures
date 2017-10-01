/*
 * Sean Burnham
 * IS 537
 * 10/2/2017
 */

using System;
using System.IO;
using System.Collections.Generic;

namespace Restaurant
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create the lists for storing restaurant data
            doublyLinkedList callahead = new doublyLinkedList();
            doublyLinkedList waiting = new doublyLinkedList();
            queue appetizers = new queue();
            stack buzzers = new stack();
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            buzzers.push("Buzzer");
            circularList songs = new circularList();
            songs.Add("Song 1");
            songs.Add("Song 2");
            songs.Add("Song 3");
            songs.songIter = new CircularLinkedListIterator(songs);

            /*
             * DEBUG
             * SONG
             * APPETIZER_READY
             * SEAT
             * ARRIVE
             * APPETIZER
             * CALL
             * LEAVE
             */

			//Creates a list of lists that holds all the data brought in from the imported csv file.
			List<List<string>> list = importFile();

			//Runs through each item in the csv file now stored in a list and reads it into the program 
			foreach (List<string> item in list)
			{
				Console.WriteLine(item[item.Count - 1]);

                //Prints out data found in each of the lists created above.
				if (item[0] == "DEBUG")
				{
					callahead.debug_print();
                    waiting.debug_print();
                    appetizers.debug_print();
                    buzzers.debug_print();
                    songs.debug_print();
				}
                //Prints out the song list and the current song that should be playing.
				else if (item[0] == "SONG")
				{
                    Console.WriteLine(songs.songIter.next());
				}
                //Adds the new appetizer created onto the queue that holds all appetizers
				else if (item[0] == "APPETIZER_READY")
				{
					appetizers.enqueue(item[1]);
				}
                //Removes the given party from the waiting list and adds a buzzer to the buzzer list.
				else if (item[0] == "SEAT")
				{
					try //Makes sure that the given name that was seated is in the waiting list.
					{
                        Console.WriteLine(waiting.getItem(0));
						waiting.deleteItem(0);
                        buzzers.push("Buzzer");
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
                //Adds the given name to the waiting list unless they are found on the callahead list. 
                //If they are on the callahead list then they are placed up to 5 spots ahead on the waiting list.
                //The given name is then removed from the callahead list.
                //A buzzer is also removed from the buzzer list signifying the party was given a buzzer to wait with.
				else if (item[0] == "ARRIVE")
				{
                    
					Node n = callahead.head;
                    string tempName = "";

                    for (int iCount = 0; iCount < callahead.size; iCount++)
					{
						if (n.accessNode == item[1])
						{
                            tempName = item[1];
							if (waiting.size <= 4)
							{
								waiting.insert(0, item[1]);
							}
							else
							{
								waiting.insert(waiting.size - 4, item[1]);
							}
							try
							{
								callahead.deleteItem(iCount);
								break;
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
							}
						}
						n = n.next;
					}

                    if(tempName == "")
                    {
						waiting.Add(item[1]);
					}

                    buzzers.pop();

				}
                //Removes the given appetizer from the appetizer list and given to the last three names on the waiting list.
                //The last three names are printed in reverse order
				else if (item[0] == "APPETIZER")
				{
					try //Ensures that there is someone in the waiting list to recieve the appetizer
					{
                        string output = "";

                        for (int i = waiting.size - 1; i > waiting.size - 4 && i >= 0; i--)
                        {
                            output += waiting.getItem(i);
                            if(i != waiting.size - 3 && i > 0)
                            {
                                output += ", ";
                            }
                        }

                        Console.WriteLine(appetizers.dequeue() + " >>> " + output);

					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}

				}
                //Adds the given name to the callahead list.
				else if (item[0] == "CALL")
				{
					callahead.Add(item[1]);
				}
                //Removes the given name from the waiting list
				else if (item[0] == "LEAVE")
				{
					Node n = waiting.head;
                    int iCount = 0;

					while (true)
					{
						if (n.accessNode == item[1])
						{
                            try //Ensures the given name is actually in the waiting list.
                            {
								waiting.deleteItem(iCount);
								break;
                            }
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
							}

						}
						n = n.next;
						iCount++;
					}
                    buzzers.push("Buzzer");
				}
			}

		}

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

