using System;
namespace BoMSort
{
    public class worddata
    {
		//Data about a single word
		public worddata(string book, string word, int count, double percent)
        {
            this.book = book;
            this.word = word;
            this.count = count;
            this.percent = percent;

        }

        public string book
        {
            get;
            set;
        }

        public string word
        {
            get;
            set;
        }

        public int count
        {
            get;
            set;
        }

        public double percent
        {
            get;
            set;
        }
    }
}
