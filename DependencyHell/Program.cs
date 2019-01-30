using System;
using System.Net;
using System.Net.Http;

namespace DependencyHell
{
    class Program
    {
        static void Main(string[] args)
        {
            // We want to use version 4.1.1.3
            // At my computer VS tells me it will use 4.2.0 but it does not copy assembly so it uses assembly from GAC with version of 4.0.0.0.
            // Sense? What sense? There is no sense here!
            Console.WriteLine(typeof(HttpContent).Assembly.Location);
            Console.WriteLine(typeof(HttpContent).Assembly.GetName().FullName);
            Console.WriteLine(typeof(HttpContent).Assembly.GetName().Version);
            Console.ReadKey();
        }
    }
}
