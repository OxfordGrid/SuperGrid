using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace OwinSelfhostSample
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";
            Console.WriteLine($"Student is running at {baseAddress}");
            
            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Test");
                Console.ReadLine();
            }

            
        }
    }
}