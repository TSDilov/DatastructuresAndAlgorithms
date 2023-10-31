using Datastructures.BinarySearchTree;

internal class Program
{
    private static void Main(string[] args)
    {
        var tree = new BinarySearchTree<int>();
        tree.Insert(17);
        tree.Insert(9);
        tree.Insert(6);
        tree.Insert(12);
        tree.Insert(19);
        tree.Insert(25);
        tree.BFS();
        Console.WriteLine();
        tree.InOrderPrint();
        Console.WriteLine();
        tree.InOrderDFS();
        Console.WriteLine();
        tree.PostOrderPrint();
        Console.WriteLine();
        tree.PostOrderDFS();
        Console.WriteLine();
        tree.PreOrderPrint();
        Console.WriteLine();
        tree.PreOrderDFS();
    }
}