using System;
using Assignment4.Factory;

namespace Assignment4.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Build build = new Build();

            build.MenuOfCreateTShirts();
            build.SelectSortingMenu();
            
            Console.ReadKey();
        }

    }
}
