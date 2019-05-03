namespace RestfulDemo
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("REST API Demo - using RestSharp");

            // Basic - write this one in blue
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            new BasicRequest().DemoBasicRequest();
            Console.WriteLine();


            // Ask for exit so that data can be read by the user
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}