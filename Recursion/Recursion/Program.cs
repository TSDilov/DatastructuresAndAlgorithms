using Recursion;
using Recursion.DataTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new Recursion.DataTypes.LinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        var current = list.Head;
        while (current != null)
        {
            Console.Write($"{current.Value} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");

        list.Reverse();
        current = list.Head;
        while (current != null)
        {
            Console.Write($"{current.Value} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}