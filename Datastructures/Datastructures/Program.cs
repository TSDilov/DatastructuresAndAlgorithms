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
        list.Add(4);
        list.Add(7);
        list.Add(10);
        list.Sort();
        Console.WriteLine(list.HasCycle());
        var list2 = new CustomLinkedList<int>();
        list2.Add(1);
        list2.Add(2);
        list2.Add(3);
        list2.Add(4);
        list2.Add(5);
        list2.Head.Next.Next.Next.Next = list2.Head.Next;
        Console.WriteLine(list2.HasCycle());
    }
}