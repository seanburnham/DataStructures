using System;

namespace BinaryTree
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            binarytree myTree = new binarytree();

            myTree.set('c', 'C');
            myTree.set('h', 'H');
            myTree.set('a', 'A');
            myTree.set('e', 'E');
            myTree.set('f', 'F');
            myTree.set('d', 'D');
            myTree.set('b', 'B');
            myTree.set('j', 'J');
            myTree.set('g', 'G');
            myTree.set('i', 'I');
            myTree.set('k', 'K');

            Console.WriteLine("Initial Tree:");
            myTree.debug_print();
            Console.WriteLine();

            Console.WriteLine("Lookups:");
            Console.WriteLine(myTree.get('f'));
            Console.WriteLine(myTree.get('b'));
            Console.WriteLine(myTree.get('i'));
            Console.WriteLine();

            Console.WriteLine("BFS:");
            myTree.walk_bfs();
            Console.WriteLine();

            Console.WriteLine("DFS preorder:");
            myTree.walk_dfs_preorder();
            Console.WriteLine();

            Console.WriteLine("DFS inorder");
            myTree.walk_dfs_inorder();
            Console.WriteLine();

            Console.WriteLine("DFS postorder");
            myTree.walk_dfs_postorder();
            Console.WriteLine();

            Console.WriteLine("Remove b:");
            myTree.remove('b');
            myTree.debug_print();
            Console.WriteLine();

            Console.WriteLine("Remove f:");
            myTree.remove('f');
            myTree.debug_print();
            Console.WriteLine();

            Console.WriteLine("Remove h:");
            myTree.remove('h');
            myTree.debug_print();

        }
    }
}
