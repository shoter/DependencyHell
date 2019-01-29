using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InnocentLookingProject
{
    public class InnocentClass
    {
        public static void LetsStartAHell()
        {
            var cert = new X509Certificate();
            cert.Reset();
            Console.WriteLine(cert.GetType().Assembly.GetName().Version);
            Console.WriteLine(cert.GetType().Assembly.GetName().FullName);
        }
    }
}
