using System;
namespace Arrays
{
	//An array implementation that holds arbitrary objects.
	public class ArrayClass
    {
        string[] data;
        int size;
        int chunkSize;
        int initialSize;

		//Creates an array with an intial size.
		public ArrayClass(int initial_Size = 10, int chunk_Size = 5)
        {
            chunkSize = chunk_Size;
            initialSize = initial_Size;

            data = new string[initialSize];
            size = 0;
        }

		//Prints a representation of the entire allocated space, including unused spots.
		public void debug_print()
        {
            string output = "";
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] == null)
                {
                    output += "None";
                }
                else
                {
                   output += data[i]; 
                }
                if(i != data.Length - 1)
                {
                    output += ", ";
                }
            }
            Console.WriteLine(size.ToString() + " of " + data.Length.ToString() + " >>> " + output);
        }

		//Ensures the index is within the bounds of the array: 0 <= index <= size.
		private bool checkBounds(int index)
        {
            if(index >= size || index < 0)
            {
                return false;     
            }
            return true;
        }

        //Checks whether the array is full and needs to increase by chunk size
        //in preparation for adding an item to the array.
        private void checkIncrease()
        {
            if(size == data.Length)
            {
                string[] newData = new string[data.Length + chunkSize];
                for (int i = 0; i < data.Length; i++)
                {
                    newData[i] = data[i];
                }

                //Garbage collector takes care of memory with no reference
                data = newData;
            }

        }

		//Checks whether the array has too many empty spots and can be decreased by chunk size.
		//If a decrease is warranted, it should be done by allocating a new array and copying the
		//data into it(don't allocate multiple arrays if multiple chunks need decreasing).
		private void checkDecrease()
		{
            if(size < initialSize || size > data.Length - chunkSize)
            {
                return;
            }
            if(size % chunkSize == 0)
            {
                
				string[] newData = new string[data.Length - chunkSize];
				for (int i = 0; i < newData.Length; i++)
				{
					newData[i] = data[i];
				}

				//Garbage collector takes care of memory with no reference
				data = newData;
            }
		}

		//Adds an item to the end of the array, allocating a larger array if necessary.
		public void Add(string item)
        {
            checkIncrease();
            data[size] = item;
            size++;
        }

		//Inserts an item at the given index, shifting remaining items right and allocating a larger array if necessary.
		public void insert(int index, string item)
        {
            if(checkBounds(index))
            {
                checkIncrease();
                for (int i = size; i >= 0 ; i--)
                {
                    if(i == index)
                    {
                        data[i] = item;
                        break;
                    }
                    data[i] = data[i - 1];
                }
                size++;
            }
            else
            {
                Console.WriteLine("Error: " + index + " is not within the bounds of the current array.");
            }
        }

		//Sets the given item at the given index.  Throws an exception if the index is not within the bounds of the array.
		public void setItem(int index, string item)
        {
            if(checkBounds(index))
            {
                data[index] = item; 
            }
			else
			{
				Console.WriteLine("Error: " + index + " is not within the bounds of the current array.");
			}
        }

		//Retrieves the item at the given index.  Throws an exception if the index is not within the bounds of the array.
		public string getItem(int index)
		{
			if (checkBounds(index))
			{
                return data[index];
			}
            return "Error: " + index + " is not within the bounds of the current array.";
		}

		//Deletes the item at the given index, decreasing the allocated memory if needed.  Throws an exception if the index is not within the bounds of the array.
		public void deleteItem(int index)
        {
            if(checkBounds(index))
            {
                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                //data[size - 1] = null;
                size--;

                checkDecrease();
            }
            else
            {
                Console.WriteLine("Error: " + index + " is not within the bounds of the current array.");
            }
        }

        //Swaps the values at the given indices.
        public void swap(int index1, int index2)
        {
            if (checkBounds(index1) && checkBounds(index2))
            {
                string temp = data[index1];
                data[index1] = data[index2];
                data[index2] = temp;
            }
            else
            {
                if (checkBounds(index1))
                {
                    Console.WriteLine("Error: " + index2 + " is not within the bounds of the current array.");

                }
                else
                {
					Console.WriteLine("Error: " + index1 + " is not within the bounds of the current array.");
				}
            }
        }

    }
}
