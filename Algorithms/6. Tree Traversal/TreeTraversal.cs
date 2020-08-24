using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.TreeTraversal
{
    public static class TreeTraversal
    {
        public static void InOrderTravseral(Node node)
        {
            // Left, Root, Right
            if (node.Left != null)
            {
                InOrderTravseral(node.Left);
                Console.WriteLine(node.Value);
                InOrderTravseral(node.Right);
            }
            else
            {
                Console.WriteLine(node.Value);
            }
        }

        public static void PreOrderTravseral(Node node)
        {
            // Root, Left, Right
            Console.WriteLine(node.Value);

            if (node.Left != null)
            {
                PreOrderTravseral(node.Left);
                PreOrderTravseral(node.Right);
            }
            
        }

        public static void PostOrderTravseral(Node node)
        {
            // Left, Right, Root
            if (node.Left != null)
            {
                PostOrderTravseral(node.Left);
                PostOrderTravseral(node.Right);
            }
            Console.WriteLine(node.Value);

        }
    }
}
