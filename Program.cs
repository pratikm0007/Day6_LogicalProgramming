using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    //StopWatch
    static void Main(string[] args)
    {
        
        Stopwatch stopwatch = new Stopwatch();

        // Start time
        Console.WriteLine("Start by Press 1");
        int start = Convert.ToInt32(Console.ReadLine());
        stopwatch.Start();

        Thread.Sleep(1);

        // Stop time.
        Console.WriteLine("Stop by Press 1");
        int stop = Convert.ToInt32(Console.ReadLine());
        stopwatch.Stop();

        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
}