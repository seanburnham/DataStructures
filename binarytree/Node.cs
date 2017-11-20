using System;
namespace BinaryTree
{
    public class Node
    {
        public Node(char key, char value, Node parent, Node left, Node right)
        {
            this.key = key;
            this.value = value;
            this.parent = parent;
            this.left = left;
            this.right = right;
        }

        public char key
        {
            get;
            set;
        }

        public char value
        {
            get;
            set;
        }
  
        public Node parent
        {
            get;
            set;
        }

        public Node left
        {
            get;
            set;
        }

        public Node right
        {
            get;
            set;
        }

    }
}
