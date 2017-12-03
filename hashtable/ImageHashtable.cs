using System.IO;
using System.Drawing;
using System;

namespace Hashtable
{
    public class ImageHashtable : Hashtable
    {
        public ImageHashtable(){}

        public override int get_hash(string key)
        {
            //Finds the path to each image file in the images folder
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/images/" + key;

            //Stores all the bytes of the image into an array
            byte[] myImg = File.ReadAllBytes(path);

            int hash = 0;

            foreach(byte b in myImg)
            {
                hash += (int)b;
            }

            return hash % 10;
        }
    }
}
