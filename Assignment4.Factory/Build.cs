using Assignment4.Database;
using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Factory
{
    public class Build
    {
        //============================================= Properties =======================================================
        protected MyDatabase Database { get; }
        protected TShirt Shirt { get; }

        //============================================= Constructor methods =======================================================
        public Build()
        {
            Shirt = new TShirt();
            Database = new MyDatabase();
            GenerateAllCombinationsOfShirts();
        }

        //============================================= Protected methods =======================================================
        protected void GenerateAllCombinationsOfShirts()
        {
           

            for (int i = 0; i < Database.colors.Count; i++)
            {
                for (int j = 0; j < Database.fabrics.Count; j++)
                {
                    for (int k = 0; k < Database.sizes.Count; k++)
                    {
                        TShirt ts = new TShirt(Database.colors[i], Database.fabrics[j], Database.sizes[k]);
                        Database.shirts.Add(ts);
                    }
                }
            }
        }

        //============================================= Public methods =======================================================
        public void StartMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t");
            Console.Write("\tPress any Key to see all the variations of T-Shirt.  ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t");
            Console.Write("{0, -15}{1,-15}{2,-15}{3,-15}", "Number" , "Color", "Fabric", "Size");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Shirt.Output(Database.shirts);
        }
        
    }
}
