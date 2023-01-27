using Humanizer;
using System;


namespace HelloWorldConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));
        }
    }
}
