using Datastructures.BinarySearchTree;
using Datastructures.Graph;
using Datastructures.SortingAlgorithms;
using Datastructures.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        var graph = new Graph<int, int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);

        graph.AddEdge(1, 2, 2);
        graph.AddEdge(1, 3, 4);
        graph.AddEdge(2, 3, 1);
        graph.AddEdge(2, 4, 7);
        graph.AddEdge(3, 4, 3);

        Console.WriteLine("Original Graph:");
        graph.PrintGraph();

        var distances = graph.DijkstraAlgorithm(1);

        Console.WriteLine("Shortest Distances from Vertex 1:");
        foreach (var entry in distances)
        {
            Console.WriteLine($"To {entry.Key}: {entry.Value}");
        }
    }
}