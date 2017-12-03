using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;


namespace Hashtable
{
    public class GuidHashtable : Hashtable
    {
        public GuidHashtable()
        {
        }

        public override int get_hash(string key)
        {
            //Combines all the numbers in the Guid to then be used separately in the hashing algorithm
            var numbers = Regex.Matches(key, @"\d+").OfType<Match>().Select(m => BigInteger.Parse(m.Value)).ToArray();

            string concatNum = String.Join("", numbers);

            var hashsum = BigInteger.Parse(concatNum);

            hashsum = Pow(hashsum, 2) / 7;

            return (int)(hashsum % 10);

        }

        //Separate power function to work with BigIntegers since the Guid numbers are so large
        private BigInteger Pow(BigInteger num, int pow)
        {
            if (pow == 1)
                return num;
            return num * Pow(num, pow - 1);
        }

    }
}
