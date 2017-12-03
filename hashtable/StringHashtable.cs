using System;

namespace Hashtable
{
    public class StringHashtable : Hashtable
    {
        
        public StringHashtable(){}

        //Hashing function for strings in the text file
        public override int get_hash(string key)
        {
            double powerVariable = 1.5;
            int hashsum = 0;

            foreach(char c in key)
            {
                hashsum += (int)Math.Pow((int)c, powerVariable);
                powerVariable += 2;
            }


            return Math.Abs(hashsum % 10);
        }

    }
}
