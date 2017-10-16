using System;
namespace BoMSort
{
    public class insertionsort
    {
		//private int[] IntArray;
		//private string[] StringArray;
        private worddata[] DataArray;

		////Creates a new object holding an array of ints
		//public insertionsort(int[] newArray)
		//{
		//	IntArray = newArray;
		//}

        public insertionsort(worddata[] newArray)//, bool sortByString)
		{
            DataArray = newArray;
            DataArray = InsertionSortStrings();
			DataArray = InsertionSortCount();
            DataArray = InsertionSortPercent();
		}

        public worddata[] getWorddata() {
            return DataArray;
        }

		////Creates a new object holding an array of strings
		//public insertionsort(string[] newArray)
		//{
		//	StringArray = newArray;
		//}

		//Uses insertion sort algorithm to sort percent highest to lowest
		public worddata[] InsertionSortPercent()
		{
            worddata temp; 
            int j;
			for (int i = 1; i < DataArray.Length; i++)
			{
                temp = DataArray[i];
				j = i - 1;

                while (j >= 0 && DataArray[j].percent < temp.percent)
				{
					DataArray[j + 1] = DataArray[j];
					j -= 1;
				}

				DataArray[j + 1] = temp;
			}

			return DataArray;
		}

		//Uses insertion sort algorithm to sort word in alphabetical order
		public worddata[] InsertionSortStrings()
		{
			for (int i = 1; i < DataArray.Length; i++)
			{
				worddata temp = DataArray[i];
				int j = i - 1;
				while (j >= 0 && DataArray[j].word.CompareTo(temp.word) > 0)
				{
					DataArray[j + 1] = DataArray[j];
					j--;
				}
				DataArray[j + 1] = temp;
			}

			return DataArray;
		}

		//Uses insertion sort algorithm to sort percent highest to lowest
		public worddata[] InsertionSortCount()
		{
			worddata temp;
			int j;
			for (int i = 1; i < DataArray.Length; i++)
			{
				temp = DataArray[i];
				j = i - 1;

				while (j >= 0 && DataArray[j].count < temp.count)
				{
					DataArray[j + 1] = DataArray[j];
					j -= 1;
				}

				DataArray[j + 1] = temp;
			}

			return DataArray;
		}







		////Uses insertion sort algorithm to sort ints highest to lowest
		//public int[] InsertionSortInts()
		//{
		//	int temp, j;
		//	for (int i = 1; i < IntArray.Length; i++)
		//	{
		//		temp = IntArray[i];
		//		j = i - 1;

		//		while (j >= 0 && IntArray[j] < temp)
		//		{
		//			IntArray[j + 1] = IntArray[j];
		//			j--;
		//		}

		//		IntArray[j + 1] = temp;
		//	}

  //          return IntArray;
		//}

		////Uses insertion sort algorithm to sort strings in alphabetical order
		//public string[] InsertionSortStrings()
		//{ 
		//	for (int i = 1; i < StringArray.Length; i++)
		//	{
		//		string temp = StringArray[i];
		//		int j = i - 1;
		//		while (j >= 0 && StringArray[j].CompareTo(temp) > 0)
		//		{
		//			StringArray[j + 1] = StringArray[j];
		//			j--;
		//		}
		//		StringArray[j + 1] = temp;
		//	}

  //          return StringArray;
		//}

    }
}




