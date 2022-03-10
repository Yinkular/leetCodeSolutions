using CodingPractice.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingPractice.Traversals
{
    public static class WallsAndGates
    {
        public static void WallsAndGatesSolution(int[][] rooms)
        {
            List<Tuple<int,List<int>>> IndexGraph = CreateGraphByIndex(rooms);

            for(int i = 0; i < rooms.Length; i++)
            {
                for(int j = 0; j < rooms[i].Length; j++)
                {
                    var currentNodeValue = rooms[i][j];

                    if(currentNodeValue == 2147483647)
                    {
                        FindPaths(GetIndex(i, j,rooms.Length), IndexGraph, rooms);
                    }
                }
            }

            PrintOutput(rooms);
        }

        public static void FindPaths(int currentIndex, List<Tuple<int, List<int>>> nodes, int[][] rooms)
        {
            Queue<int> queue = new Queue<int>();
            int steps = 1;

            var reverseIndexStartRoom = ReverseIndex(currentIndex, rooms.Length);

            queue.Enqueue(currentIndex);
            while(queue.Count > 0)
            {
                int qSize = queue.Count();

                for(int i = 0;i < qSize;i++)
                {
                    int index = queue.Peek();
                    var reversedIndex = ReverseIndex(index, rooms.Length);

                    if(rooms[reversedIndex.Item1][reversedIndex.Item2] == 0)
                    {
                        var currentSteps = rooms[reverseIndexStartRoom.Item1][reverseIndexStartRoom.Item2];
                        if(currentSteps == 2147483647)
                        {
                            rooms[reverseIndexStartRoom.Item1][reverseIndexStartRoom.Item2] = steps;
                        }
                        else
                        {
                            rooms[reverseIndexStartRoom.Item1][reverseIndexStartRoom.Item2] = Math.Min(currentSteps, steps);
                        }
                    }

                    var connectedNodes = nodes[index].Item2;
                    foreach(var node in connectedNodes)
                    {
                        queue.Enqueue(node);
                    }

                    queue.Dequeue();
                }
                steps++;
            }
        }

        public static void PrintOutput(int[][] rooms)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[i].Length; j++)
                {
                   Console.Write(rooms[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintNodes(List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> nodes)
        {
            foreach (var node in nodes)
            {
                var currentNode = node.Item1;
                var connectedNodes = node.Item2;

                Console.Write(currentNode.Item1 + "," + currentNode.Item2);
                Console.Write(" -> ");
                foreach (var connectedNode in connectedNodes)
                {
                    Console.Write(connectedNode.Item1 + "," + connectedNode.Item2);
                    Console.Write(":");
                }
                Console.WriteLine();
            }
        }

        public static void PrintNodesByIndex(List<Tuple<int, List<int>>> nodes)
        {
            foreach(var node in nodes)
            {
                var currentNodeIndex = node.Item1;
                var connectedNodes = node.Item2;

                Console.Write(currentNodeIndex);
                Console.Write(" -> ");
                foreach(var connectedNode in connectedNodes)
                {
                    Console.Write(connectedNode);
                    Console.Write(":");
                }
                Console.WriteLine();
            }
        }

        private static List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> CreateGraphByPostion(int[][] rooms)
        {
            List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> Graph = new List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>>();

            int length = rooms.Length;
            int breadth = rooms[0].Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < breadth; j++)
                {
                    var currentValue = rooms[i][j];

                    var top = i - 1 >= 0 ? i - 1 : -1;
                    var right = j + 1 < breadth ? j + 1 : -1;
                    var bottom = i + 1 < length ? i + 1 : -1;
                    var left = j - 1 >= 0 ? j - 1 : -1;

                    // get connected nodes
                    var connectedNodes = new List<Tuple<int, int>>();
                    if (top != -1)
                    {
                        connectedNodes.Add(new Tuple<int, int>(top, j));
                    }
                    if (right != -1)
                    {
                        connectedNodes.Add((new Tuple<int, int>(i, right)));
                    }
                    if (bottom != -1)
                    {
                        connectedNodes.Add((new Tuple<int, int>(bottom, j)));
                    }
                    if (left != -1)
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

            return Graph;
        }

        private static List<Tuple<int, List<int>>> CreateGraphByIndex(int[][] rooms)
        {
            List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>> Graph = new List<Tuple<Tuple<int, int>, List<Tuple<int, int>>>>();
            List<Tuple<int, List<int>>> IndexGraph = new List<Tuple<int, List<int>>>();

            int length = rooms.Length;
            int breadth = rooms[0].Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < breadth; j++)
                {
                    var currentValue = rooms[i][j];

                    var top = i - 1 >= 0 ? i - 1 : -1;
                    var right = j + 1 < breadth ? j + 1 : -1;
                    var bottom = i + 1 < length ? i + 1 : -1;
                    var left = j - 1 >= 0 ? j - 1 : -1;

                    // get connected nodes
                    var connectedNodesIndex = new List<int>();
                    if (top != -1)
                    {
                        connectedNodesIndex.Add(GetIndex(top, j, length));
                    }
                    if (right != -1)
                    {
                        connectedNodesIndex.Add(GetIndex(i, right, length));
                    }
                    if (bottom != -1)
                    {
                        connectedNodesIndex.Add(GetIndex(bottom, j, length));
                    }
                    if (left != -1)
                    {
                        connectedNodesIndex.Add(GetIndex(i, left, length));
                    }

                    // index
                    var currentNodeIndex = GetIndex(i, j, length);
                    var currentNodeIndexEntry = new Tuple<int, List<int>>(currentNodeIndex, connectedNodesIndex);

                    IndexGraph.Add(currentNodeIndexEntry);
                }
            }

            PrintNodesByIndex(IndexGraph);

            return IndexGraph;
        }

        private static int GetIndex(int i, int j, int length)
        {
            return ((i * length) + j) ;
        }

        private static Tuple<int,int> ReverseIndex(int index, int length)
        {
            int i = 0;
            int j = 0;

            if(index >= length)
            {
                i = index / length;
                
            }
            j = index % length;

            return Tuple.Create(i, j);
        }
    }
}
