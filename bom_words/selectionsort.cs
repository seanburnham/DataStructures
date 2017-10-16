using System;
namespace BoMSort
{
    public class selectionsort
    {
		//private int[] IntArray;
		//private string[] StringArray;
        private worddata[] DataArray;

		////Creates a new object holding an array of ints
		//public selectionsort(int[] newArray)
		//{
		//	IntArray = newArray;
		//}

		////Creates a new object holding an array of strings
		//public selectionsort(string[] newArray)
		//{
		//	StringArray = newArray;
		//}

		public selectionsort(worddata[] newArray)//, bool sortByString)
		{
			DataArray = newArray;
			DataArray = SelectionSortStrings();
            DataArray = SelectionSortCount();
			DataArray = SelectionSortPercent();
		}

		public worddata[] getWorddata()
		{
			return DataArray;
		}



		//Uses selection sort algorithm to sort ints highest to lowest
		public worddata[] SelectionSortPercent()
		{
            //pos_min is short for position of max
            int pos_max; 
            worddata temp;

			for (int i = 0; i < DataArray.Length - 1; i++)
			{
				pos_max = i;//set pos_max to the current index of array

				for (int j = i + 1; j < DataArray.Length; j++)
				{
					if (DataArray[j].percent > DataArray[pos_max].percent)
					{
						//pos_max will keep track of the index that min is in, this is needed when a swap happens
						pos_max = j;
					}
				}

				//if pos_max no longer equals i than a larger value must have been found, so a swap must occur
				if (pos_max != i)
				{
					temp = DataArray[i];
					DataArray[i] = DataArray[pos_max];
					DataArray[pos_max] = temp;
				}
			}

			return DataArray;
		}


		//Uses selection sort algorithm to sort strings in alphabetical order
		public worddata[] SelectionSortStrings()
		{
			//pos_min is short for position of max
			int pos_min;
			worddata temp;

			for (int i = 0; i < DataArray.Length - 1; i++)
			{
				pos_min = i;//set pos_min to the current index of array

				for (int j = i + 1; j < DataArray.Length; j++)
				{
					if (DataArray[j].word.CompareTo(DataArray[pos_min].word) < 0)
					{
						//pos_min will keep track of the index that min is in, this is needed when a swap happens
						pos_min = j;
					}
				}

				//if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
				if (pos_min != i)
				{
					temp = DataArray[i];
					DataArray[i] = DataArray[pos_min];
					DataArray[pos_min] = temp;
				}
			}

			return DataArray;
		}

		//Uses selection sort algorithm to sort ints highest to lowest
		public worddata[] SelectionSortCount()
		{
			//pos_min is short for position of max
			int pos_max;
			worddata temp;

			for (int i = 0; i < DataArray.Length - 1; i++)
			{
				pos_max = i;//set pos_max to the current index of array

				for (int j = i + 1; j < DataArray.Length; j++)
				{
					if (DataArray[j].count > DataArray[pos_max].count)
					{
						//pos_max will keep track of the index that min is in, this is needed when a swap happens
						pos_max = j;
					}
				}

				//if pos_max no longer equals i than a larger value must have been found, so a swap must occur
				if (pos_max != i)
				{
					temp = DataArray[i];
					DataArray[i] = DataArray[pos_max];
					DataArray[pos_max] = temp;
				}
			}

			return DataArray;
		}









		////Uses selection sort algorithm to sort ints highest to lowest
		//public int[] selectSortInts()
		//{
		//	//pos_min is short for position of max
		//	int pos_max, temp;

		//	for (int i = 0; i < IntArray.Length - 1; i++)
		//	{
		//		pos_max = i;//set pos_max to the current index of array

		//		for (int j = i + 1; j < IntArray.Length; j++)
		//		{
		//			if (IntArray[j] > IntArray[pos_max])
		//			{
		//				//pos_max will keep track of the index that min is in, this is needed when a swap happens
		//				pos_max = j;
		//			}
		//		}

		//		//if pos_max no longer equals i than a larger value must have been found, so a swap must occur
		//		if (pos_max != i)
		//		{
		//			temp = IntArray[i];
		//			IntArray[i] = IntArray[pos_max];
		//			IntArray[pos_max] = temp;
		//		}
		//	}

  //          return IntArray;
		//}


		////Uses selection sort algorithm to sort strings in alphabetical order
		//public string[] selectSortStrings()
		//{
  //          //pos_min is short for position of max
  //          int pos_min; 
  //          string temp;

		//	for (int i = 0; i < StringArray.Length - 1; i++)
		//	{
		//		pos_min = i;//set pos_min to the current index of array

		//		for (int j = i + 1; j < StringArray.Length; j++)
		//		{
		//			if (StringArray[j].CompareTo(StringArray[pos_min]) < 0)
		//			{
		//				//pos_min will keep track of the index that min is in, this is needed when a swap happens
		//				pos_min = j;
		//			}
		//		}

		//		//if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
		//		if (pos_min != i)
		//		{
		//			temp = StringArray[i];
		//			StringArray[i] = StringArray[pos_min];
		//			StringArray[pos_min] = temp;
		//		}
		//	}

		//	return StringArray;
		//}

    }
}
