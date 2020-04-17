using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Factory;

namespace Assignment4.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Build build = new Build();

            build.StartMenu();

            Console.ReadKey();
        }
    }
}
