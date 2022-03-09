using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Traversals
{
    public static class TraversalsRepository
    {
        public static void InitAllTraversalProblems()
        {
            InitWallsAndGatesProblem();
        }

        public static void InitWallsAndGatesProblem()
        {
            int[][] numbers = new int[4][];

            numbers[0] = new int[4] { 2147483647, -1, 0, 2147483647 };
            numbers[1] = new int[4] { 2147483647, 2147483647, 2147483647, -1 };
            numbers[2] = new int[4] { 2147483647, -1, 2147483647, -1 };
            numbers[3] = new int[4] { 0, -1, 2147483647, 2147483647 };

            WallsAndGates.WallsAndGatesSolution(numbers);
        }
    }
}
