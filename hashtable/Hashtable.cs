using System;
using BinaryTree;

namespace Hashtable
{
    public abstract class Hashtable
    {

        binarytree[] myTree = new binarytree[10];

        public Hashtable()
        {
            //Creates an array of ten empty binary trees
            for (int i = 0; i < 10; i++)
            {
                myTree[i] = new binarytree();
            }
        }

        //Adds item to binary tree by hashing the key to find out which bucket it should go in and then placing it in that tree
        public void set(string key, string value)
        {
            int hash = get_hash(key);
            myTree[hash].set(key, value);
        }

        //Hashes the given key to then find which binary tree to search for the given item
        public string get(string key)
        {
            int hash = get_hash(key);

            return myTree[hash].get(key);

        }

        //Hashes the given key to then find which binary tree to search for and remove the given item
        public void remove(string key)
        {
            int hash = get_hash(key);

            myTree[hash].remove(key);
        }

        //Abstrct function forcing the children classes to create this function with their own implementation
        public abstract int get_hash(string key);

        //Prints the index followed by the values in each bucket using a breadth first search of the tree
        public void debug_print()
        {
            for (int i = 0; i < myTree.Length; i++)
            {

                Console.WriteLine();
                Console.Write(i.ToString() + ": ");
                myTree[i].walk_bfs();

            }
            Console.WriteLine();
        }

    }
}
