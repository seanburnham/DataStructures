using System;
namespace BoMSort
{
	
    //Merges two sorted lists into a new, sorted list.  The new list is sorted by percent, count, alpha.
	public class merge
    {
        private worddata[] masterList;
		private worddata[] bookDataList;

        public merge(worddata[] list1, worddata[] list2)
        {
            masterList = list1;
            bookDataList = list2;
            updateMasterList();
        }

		public worddata[] getMasterList()
		{
			return masterList;
		}

		private void updateMasterList()
		{
		    int size;
		    if (masterList.Length == 0)
		    {
                //if masterList is empty then just stick whole sorted array in the masterList to start it
		        size = bookDataList.Length;
		        masterList = new worddata[size];
		        masterList = bookDataList;
		        return;
		    }

		    size = masterList.Length + bookDataList.Length;

            //Creates a temp array to store sorted items as the lists are merged and sorted simultaneously
		    worddata[] temp = new worddata[size];
		    int indexMaster = 0;
		    int indexBook = 0;

            //Ensures that each list is iterated through completely so there are no out of bounds errors
            bool bookFinishedFirst = false;
            //Iterates through masterList comparing to the new array of words from the analyzed book and sorting by percent and then count and then alphabetically
            while(indexMaster < masterList.Length)
            {
                if (indexBook == bookDataList.Length)
                {
                    bookFinishedFirst = true;
                    break;
                }
                if(masterList[indexMaster].percent > bookDataList[indexBook].percent)
                {
                    temp[indexMaster + indexBook] = masterList[indexMaster];
                    indexMaster++;
                }
                else if (masterList[indexMaster].percent < bookDataList[indexBook].percent)
                {
					temp[indexMaster + indexBook] = bookDataList[indexBook];
					indexBook++;
                }
                else if (masterList[indexMaster].percent == bookDataList[indexBook].percent)
                {
                    if (masterList[indexMaster].count > bookDataList[indexBook].count)
                    {
                        temp[indexMaster + indexBook] = masterList[indexMaster];
                        indexMaster++;
                    }
                    else if (masterList[indexMaster].count < bookDataList[indexBook].count)
                    {
                        temp[indexMaster + indexBook] = bookDataList[indexBook];
                        indexBook++;
                    }
                    else
                    {
                        if (masterList[indexMaster].word.CompareTo(bookDataList[indexBook].word) > 0)
                        {
                            temp[indexMaster + indexBook] = masterList[indexMaster];
                            indexMaster++;
                        }
                        else
                        {
                            temp[indexMaster + indexBook] = bookDataList[indexBook];
                            indexBook++;
                        }
                    }
                }
            }
            //After iterating through masterList if there is anything left over in the new array of words then it is appended to the end of masterList
            while (indexBook < bookDataList.Length)
            {
                temp[indexMaster + indexBook] = bookDataList[indexBook];
                indexBook++; 
            }

            if (bookFinishedFirst)
            {
                while (indexMaster < masterList.Length)
				{
					temp[indexMaster + indexBook] = masterList[indexMaster];
					indexMaster++;
				}
            }

			masterList = temp;

		}

	}
}
