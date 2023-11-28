using Datastructures.Models;
using Datastructures.Queue;

namespace Datastructures
{
    public class Algorithm
    {
        public static int ShortestPathInMaze(char[,] maze, int startRow, int startCol, int endRow, int endCol)
        {
            var rows = maze.GetLength(0);
            var cols = maze.GetLength(1);

            int[] dRows = { -1, 1, 0, 0 };
            int[] dCols = { 0, 0, -1, 1 };

            int[,] distances = new int[rows, cols];

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < cols; j++)
                {
                    distances[i, j] = int.MaxValue;
                }
            }

            distances[startRow, startCol] = 0;
            var nodeComparer = Comparer<Node>.Create((a, b) => a.Distance.CompareTo(b.Distance));
            var priorityQueue = new CustomPriorityQueue<Node>(nodeComparer);
            priorityQueue.Enqueue(new Node(startRow, startCol, 0));

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Dequeue();
                if (current.Row == endRow && current.Col == endCol)
                {
                    return current.Distance;
                }

                for (int i = 0; i < 4; i++)
                {
                    var newRow = current.Row + dRows[i];
                    var newCol = current.Col + dCols[i];

                    if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols 
                        && maze[newRow, newCol] != '#' 
                        && current.Distance + 1 < distances[newRow, newCol])
                    {
                        distances[newRow, newCol] = current.Distance + 1;
                        priorityQueue.Enqueue(new Node(newRow, newCol, current.Distance + 1));
                    }
                }
            }

            return -1;
        }
    }
}
