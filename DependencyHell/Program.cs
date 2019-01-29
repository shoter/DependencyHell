using InnocentLookingProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DependencyHell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to start something bad");
            var version = typeof(X509Certificate).Assembly.GetName().Version;
            Console.WriteLine(version);
            InnocentClass.LetsStartAHell();
            Console.ReadKey();
        }
    }
}
