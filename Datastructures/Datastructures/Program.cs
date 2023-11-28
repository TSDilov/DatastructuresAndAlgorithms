using Datastructures;
using Datastructures.Queue;

internal class Program
{
    private static void Main(string[] args)
    {
        char[,] maze = {
            {'S', '.', '.', '#', '.', '#'},
            {'.', '#', '.', '#', '.', '.'},
            {'.', '#', '.', '.', '.', '#'},
            {'.', '#', '#', '#', '.', '#'},
            {'.', '.', '.', '#', '.', 'E'}
        };

        int startRow = 0;
        int startCol = 0;
        int endRow = 4;
        int endCol = 5;

        int shortestPathLength = Algorithm.ShortestPathInMaze(maze, startRow, startCol, endRow, endCol);

        if (shortestPathLength != -1)
        {
            Console.WriteLine($"Shortest path length: {shortestPathLength}");
        }
        else
        {
            Console.WriteLine("No path found!");
        }
    }
}