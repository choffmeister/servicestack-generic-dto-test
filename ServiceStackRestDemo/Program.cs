using System;

namespace ServiceStackRestDemo
{
    public class Program
    {
        private static readonly string baseAddress = "http://localhost:8080/api/";

        private static void Main(string[] args)
        {
            AppHost appHost = new AppHost();
            appHost.Init();

            appHost.Start(baseAddress);
            Console.WriteLine("Listening on {0}. Press a key to stop.", baseAddress);
            Console.ReadKey(false);
            appHost.Stop();
        }
    }
}