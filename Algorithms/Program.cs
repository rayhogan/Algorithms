using System;
using System.Collections.Generic;
using Algorithms.TreeTraversal;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing to interact with here... yet");
            Console.WriteLine("Try running the Unit Tests");

            // Build tree
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);

            two.Left = four;
            two.Right = five;

            one.Left = two;
            one.Right = three;

            TreeTraversal.TreeTraversal.PostOrderTravseral(one);


        }

    }
}
