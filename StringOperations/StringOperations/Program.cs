using StringOperations;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var watch = new Stopwatch();
        watch.Start();
        StringOperation.AreAnagrams("Listen", "steinl");
        watch.Stop();
        Console.WriteLine($"Method 1 Elapsed Time: {watch.Elapsed}");
        watch.Reset();
        watch.Start();
        StringOperation.IsAnagrams("Listen", "steinl");
        watch.Stop();
        Console.WriteLine($"Method 2 Elapsed Time: {watch.Elapsed}");
    }
}