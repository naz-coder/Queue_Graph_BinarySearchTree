using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphNodeApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();
            string[] names = {"Dave", "Anwar", "Rob", "Haniya", "Peggy", "Rabia"};
            foreach (var name in names)
                /*Add nodes to the graph*/
                myGraph.AddNode(name);
            
            /*Add directed edges*/
            myGraph.AddEdge("Dave","Peggy");
            myGraph.AddEdge("Anwar","Dave");
            myGraph.AddEdge("Anwar","Rob");
            myGraph.AddEdge("Rob","Haniya");
            myGraph.AddEdge("Peggy","Rob");
            myGraph.AddEdge("Peggy","Rabia");
            myGraph.AddEdge("Rabia", "Anwar");

            Console.WriteLine("Node Count: " + myGraph.NodeCount());
            Console.WriteLine("Edge Count: " + myGraph.EdgeCount());
            
            // Testing BFS
            var BFSResult = myGraph.BreadthFirstSearch("Anwar");
            Console.WriteLine("Breath First Search from Anwar: " + string.Join(", ", BFSResult));

            // Test CanTraverse method
            bool canTraverseFriends = myGraph.CanTraverse("Anwar", "Haniya");
            Console.WriteLine("Can Anwar traverse to Haniya? " + canTraverseFriends);
            
            /*To see what is happening with the Graph, add a breakpoint before the ReadKey() */
            Console.ReadKey();  
        }
    }
}