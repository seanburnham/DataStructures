using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class binarytree
    {
        private Node root;

        public binarytree()
        {
            //Creates an empty binary tree
            root = null;
        }

        //stores a key=value pair to the tree in the appropriate spot
        public void set(char key, char value)
        {
            if (root == null)
            {
                root = new Node(key, value, null, null, null);
                return;
            }

            Node ptr = root; //keeps track of where we are setting the new node in relation to root
            Node parentPtr = null; //keeps track of where the new node's parent node should be

            bool isLeft = false; //tracks whether or not the new node will be a child on the left or the right

            while (ptr != null)
            {
                parentPtr = ptr;

                if (key < ptr.key)
                {
                    ptr = ptr.left;
                    isLeft = true;
                }
                else
                {
                    ptr = ptr.right;
                    isLeft = false;
                }
            }

            if (isLeft)
                parentPtr.left = new Node(key, value, parentPtr, null, null);
            else
                parentPtr.right = new Node(key, value, parentPtr, null, null);
        }

        // returns the value stored with the given key.  If the key does not exist, null is returned.
        public string get(char key)
        {
            Node current = root; //tracks the node we are on in relation to root as we traverse the tree

            if (current == null)
            {
                return "null";
            }

            while (current != null)
            {
                if (current.key == key)
                {
                    return current.value.ToString();
                }

                if (key < current.key)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            return "";
        }

        //removes the node with the given key from the tree.  If the key does not exist, it should simply return.
        // The algorithm I used is to replace the node we want to remove with the farthest right leaf node of the left child of the node we are removing
        public void remove(char key)
        {

            Node current = root; //tracks the node we are on in relation to root as we traverse the tree

            while (true) //This loops through the tree to find the given node to remove
            {
                if (current == null)
                    return;

                if (current.key == key)
                {
                    break;
                }

                if (key < current.key)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            bool isRoot = false; //Used if the node chosen to remove is the root node so we know how to deal with the remaining nodes

            if (current.key == root.key)
            {
                isRoot = true;
            }

            if (current.left != null)
            {
                if (current.left.right == null) //This part is done if the left child of the node we are removing doesn't have any children on the right.
                {
                    if (!isRoot)
                    {
                        if (current.key < current.parent.key)
                        {
                            current.parent.left = current.left;
                        }
                        else
                        {
                            current.parent.right = current.left;
                        }
                    }
                    else
                    {
                        root = current.left;
                        root.parent = null;
                    }

                    current.left.right = current.right;
                    current.right.parent = current.left;
                }
                else //If there is a right child then find the farthest leaf node down the right side
                {
                    Node replace = current.left.right;
                    while (replace.right != null)
                    {
                        replace = replace.right;
                    }

                    current.key = replace.key;
                    current.value = replace.value;
                    replace.parent.right = null;
                }
            }
            else if (current.right != null) //This part is done if there is no left child to begin with from the node we are removing
            {
                if (!isRoot)
                {
                    if (current.key < current.parent.key)
                    {
                        current.parent.left = current.right;
                        current.left.parent = current.parent;
                    }
                    else
                    {
                        current.parent.right = current.right;
                        current.right.parent = current.parent;
                    }
                }
                else
                {
                    root = current.right;
                    root.parent = null;
                }

            }
            else
            {
                if (!isRoot)
                {
                    if (current.key < current.parent.key)
                    {
                        current.parent.left = null;
                    }
                    else
                    {
                        current.parent.right = null;
                    }
                }
                else
                {
                    root = null;
                }

            }

        }

        //iterates through the nodes of the tree in depth-first-search "inorder" order
        public void walk_dfs_inorder()
        {
            inorder(root);
        }

        private void inorder(Node n) 
        {
            if (n == null)
            {
                return;
            }

            inorder(n.left);
            Console.WriteLine(n.value);
            inorder(n.right);
        }

        //iterates through the nodes of the tree in depth-first-search "preorder" order.
        public void walk_dfs_preorder()
        {
            preorder(root);
        }

        private void preorder(Node n)
        {
            if (n == null)
            {
                return;
            }
            Console.WriteLine(n.value);
            preorder(n.left);
            preorder(n.right);
        }

        //iterates through the nodes of the tree in depth-first-search "postorder" order.
        public void walk_dfs_postorder()
        {
            postorder(root);
        }

        private void postorder(Node n)
        {
            if (n == null)
            {
                return;
            }

            postorder(n.left);
            postorder(n.right);
            Console.WriteLine(n.value);
        }

        //iterates through the nodes of the tree in breadth-first-search order.
        public void walk_bfs()
        {
            Queue<Node> q = new Queue<Node>(); //used to store the nodes that will be printed out FIFO
            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node current = q.Dequeue();
                if (current == null) //If the node in the queue is a null value then skip it and only print the ones that have values
                    continue;
                
                Console.WriteLine(current.value);

                q.Enqueue(current.left);
                q.Enqueue(current.right);

            }
        }

        //prints a graphical representation of the tree more or less.
        public void debug_print()
        {
            Queue<Node> q = new Queue<Node>(); //used to store the nodes that will be printed out FIFO
            q.Enqueue(root);
            int levelNodes = 0; //tracks which level of the tree we are on

            while (q.Count != 0)
            {
                levelNodes = q.Count;
                while (levelNodes > 0)
                {
                    Node n = q.Dequeue();
                    string parentValue = "-";

                    if(n.parent != null)
                    {
                        parentValue = n.parent.key.ToString();
                    }
                    Console.Write(n.key + "(" + parentValue + ") ");
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    levelNodes--;
                }
                Console.WriteLine("");
            }
        }


    }
}
