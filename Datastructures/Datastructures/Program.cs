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
        Console.WriteLine(list.Head.Data);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.RemoveDuplicates();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}