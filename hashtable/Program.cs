using System;
using System.Collections.Generic;
using System.IO;
using BinaryTree;

namespace Hashtable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Strings
            StringHashtable myStringTable = new StringHashtable();

            List<string> myStringList = importFile("strings.txt");

            foreach(string s in myStringList)
            {
                myStringTable.set(s.ToLower(), s);
            }

            Console.Write("String hash table:");
            myStringTable.debug_print();

            Console.WriteLine("\nString lookups:");
            Console.WriteLine(myStringTable.get("indian meal moth"));
            Console.WriteLine(myStringTable.get("orb-weaving spiders (banded garden spider)"));

            // Guids
            GuidHashtable myGuidTable = new GuidHashtable();

            List<string> myGuidList = importFile("guids.txt");

            foreach (string g in myGuidList)
            {
                myGuidTable.set(g.ToLower(), g);
            }

            Console.Write("\nGuid hash table:");
            myGuidTable.debug_print();

            Console.WriteLine("\nGuid lookups:");
            Console.WriteLine(myGuidTable.get("00000158691797bd77464883000a001800388ccf"));
            Console.WriteLine(myGuidTable.get("00000158691797bd7746488c000a001991ef0003"));



            // Images
            string targetDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/images/"; //This find the images folder in the directory
            string[] fileEntries = new string[] { };
            if (Directory.Exists(targetDirectory))
            {
                fileEntries = Directory.GetFiles(targetDirectory); //This simply holds an array of the file names that are in the images folder
            }        
            else 
            {
                Console.WriteLine("\n{0} is not a valid file.", targetDirectory);
            }

            ImageHashtable myImagesTable = new ImageHashtable();
            foreach (string g in fileEntries)
            {
                if(Path.GetExtension(g) == ".png")
                {
                    myImagesTable.set(Path.GetFileName(g).ToLower(), Path.GetFileName(g));
                }

            }

            Console.Write("\nImage hash table:");
            myImagesTable.debug_print();

            Console.WriteLine("\nImage lookups:");
            Console.WriteLine(myImagesTable.get("document.png"));
            Console.WriteLine(myImagesTable.get("security_keyandlock.png"));

        }

        //Imports a csv file using a local path directory. 
        static private List<string> importFile(string filename)
        {
            //This specifically searches the users local directory for a file
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/" + filename;

            List<string> list = new List<string>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    list.Add(line);
                }
            }
            return list;
        }


    }
}
