using System;
namespace BoMSort
{
    public class bubblesort
    {
        //private int[] IntArray;
        //private string[] StringArray;
        private worddata[] DataArray;

		//      //Creates a new object holding an array of ints
		//      public bubblesort(int[] newArray)
		//      {
		//          IntArray = newArray;
		//      }

		////Creates a new object holding an array of strings
		//public bubblesort(string[] newArray)
		//{
		//	StringArray = newArray;
		//}


		public bubblesort(worddata[] newArray)
		{
			DataArray = newArray;
			DataArray = bubbleSortWord();
            DataArray = bubbleSortCount();
			DataArray = bubbleSortPercent();
		}

        public worddata[] getWorddata() {
            return DataArray;
        }

		//Uses bubble sort algorithm to sort ints highest to lowest
        public worddata[] bubbleSortPercent()
        {
              worddata temp;
              int numLength = DataArray.Length;
              //sorting an array
            for (int i = 1; i <= numLength - 1; i++)
            {
                for (int j = 0; j < numLength - 1; j++)
                {
                    if (DataArray[j + 1].percent > DataArray[j].percent)
                    {
                        temp = DataArray[j];
                        DataArray[j] = DataArray[j + 1];
                        DataArray[j + 1] = temp;
                    }
                  }
              }
            return DataArray;
         }

		//Uses bubble sort algorithm to sort strings in alphabetical order
		public worddata[] bubbleSortWord()
        {
            worddata temp;
            for (int i = 0; i < DataArray.Length - 1; i++)
            {
                for (int j = i + 1; j < DataArray.Length; j++)
                {
                    if (DataArray[i].word.CompareTo(DataArray[j].word) > 0)
                    {
                        temp = DataArray[i];
		                DataArray[i] = DataArray[j];
		                DataArray[j] = temp;
		            }
		        }
		    }
            return DataArray;
		}

		//Uses bubble sort algorithm to sort ints highest to lowest
		public worddata[] bubbleSortCount()
		{
			worddata temp;
			int numLength = DataArray.Length;
			//sorting an array
			for (int i = 1; i <= numLength - 1; i++)
			{
				for (int j = 0; j < numLength - 1; j++)
				{
					if (DataArray[j + 1].count > DataArray[j].count)
					{
						temp = DataArray[j];
						DataArray[j] = DataArray[j + 1];
						DataArray[j + 1] = temp;
					}
				}
			}
			return DataArray;
		}











		//      //Uses bubble sort algorithm to sort ints highest to lowest
		//      public int[] bubbleSortInts()
		//      {
		//	int temp;
		//	int numLength = IntArray.Length;
		//	//sorting an array
		//	for (int i = 1; i <= numLength - 1; i++)
		//	{
		//              for (int j = 0; j < numLength - 1; j++)
		//		{
		//			if (IntArray[j + 1] > IntArray[j])
		//			{
		//				temp = IntArray[j];
		//				IntArray[j] = IntArray[j + 1];
		//				IntArray[j + 1] = temp;
		//			}
		//		}
		//	}

		//          return IntArray;
		//      }

		////Uses bubble sort algorithm to sort strings in alphabetical order
		//public string[] bubbleSortStrings()
		//     {
		//string temp;

		//for (int i = 0; i < StringArray.Length - 1; i++)
		//{
		//	for (int j = i + 1; j < StringArray.Length; j++)
		//	{
		//		if (StringArray[i].CompareTo(StringArray[j]) > 0)
		//		{
		//			temp = StringArray[i];
		//			StringArray[i] = StringArray[j];
		//			StringArray[j] = temp;
		//		}
		//	}
		//}
		//    return StringArray;

		//}

	}
}
