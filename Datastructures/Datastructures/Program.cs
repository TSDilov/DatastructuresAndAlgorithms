using Datastructures.BinarySearchTree;
using Datastructures.Graph;
using Datastructures.SortingAlgorithms;
using Datastructures.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        var graph = new Graph<int, int>();

        for (int i = 0; i < 5; i++)
        {
            graph.AddVertex(i);
        }

        graph.AddEdge(0, 1, 1);
        graph.AddEdge(0, 2, 4);
        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 3, 2);
        graph.AddEdge(1, 4, 2);
        graph.AddEdge(3, 2, 5);
        graph.AddEdge(3, 1, 1);
        graph.AddEdge(4, 3, -3);

        graph.PrintGraph();

        var distances = graph.FloydWarshallAlgorithm();

        Console.WriteLine("Shortest Distances:");
        foreach (var entry in distances)
        {
            Console.WriteLine($"From {entry.Key.Item1} to {entry.Key.Item2}: {entry.Value}");
        }
    }
}