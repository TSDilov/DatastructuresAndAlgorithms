using Datastructures.Datastructures;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new CustomLinkedList<int>();
        list.Add(1);
        list.Add(4);
        list.Add(5);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Display();
        list.Reverse();
        list.Display();
        list.Sort();
        list.Display();
        list.Reverse();
        list.Display();
        var node = list.FindNode(6);
    }
}