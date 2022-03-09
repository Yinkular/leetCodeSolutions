using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Traversals
{
    public static class WallsAndGates
    {
        public static void WallsAndGatesSolution(int[][] rooms)
        {
            List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> Graph = new List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>>();
            int length = rooms.Length;
            int breadth = rooms[0].Length;
            
            List<Tuple<int,int>> startPoints = new List<Tuple<int, int>>();

            for (int i = 0; i < length; i++)
            {
                for(int j = 0; j < breadth; j++)
                {
                    var currentValue = rooms[i][j];

                    if (currentValue == -1)
                    {
                        startPoints.Add(new Tuple<int, int>(i, j));
                    }

                    var top = i - 1 >= 0 ? i-1 : -1; 
                    var right = j + 1 < breadth ? j + 1 : -1;
                    var bottom = i + 1 < length ? i+1 : -1;
                    var left = j - 1 >= 0 ? j-1 : -1;

                    // get connected nodes
                    var connectedNodes = new List<Tuple<int, int>>();
                    if(top != -1)
                    {
                        connectedNodes.Add(new Tuple<int, int>(top, j));
                    }
                    if(right != -1)
                    {
                        connectedNodes.Add((new Tuple<int, int>(i, right)));
                    }
                    if(bottom != -1)
                    {
                        connectedNodes.Add((new Tuple<int, int>(bottom, j)));
                    }
                    if(left != -1)
                    {
                        connectedNodes.Add((new Tuple<int, int>(i, left)));
                    }

                    // current node
                    var currentNodePair = new Tuple<int, int>(i, j);
                    var currentNode = new Tuple<Tuple<int, int>, List<Tuple<int, int>>>(currentNodePair, connectedNodes);

                    Graph.Add(currentNode);
                }
            }

            PrintNodes(Graph);
        }

        public static void FindPaths(List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> nodes, int[][] rooms)
        {
        }

        public static void PrintNodes(List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> nodes)
        {
            foreach(var node in nodes)
            {
                var currentNode = node.Item1;
                var connectedNodes = node.Item2;

                Console.Write(currentNode.Item1 + "," + currentNode.Item2);
                Console.Write(" -> ");
                foreach(var connectedNode in connectedNodes)
                {
                    Console.Write(connectedNode.Item1 + "," + connectedNode.Item2);
                    Console.Write(":");
                }
                Console.WriteLine();
            }
        }
    }
}
