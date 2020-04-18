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
        }

        //============================================= Protected methods =======================================================
        protected void GenerateCombinationsOfShirts(int numberOfTshirths)
        {

            Random random = new Random();
            int numberOfColor;
            int numberOfFabric;
            int numberOSize;
            int numberOfColors = Database.colors.Count;
            int numberOfFabrics = Database.fabrics.Count;
            int numberOfSizes = Database.sizes.Count;

            for (int i = 0; i < numberOfTshirths; i++)
            {
                numberOfColor = random.Next(0, numberOfColors - 1);
                numberOfFabric = random.Next(0, numberOfFabrics - 1);
                numberOSize = random.Next(0, numberOfSizes - 1);

                TShirt ts = new TShirt(Database.colors[numberOfColor], Database.fabrics[numberOfFabric], Database.sizes[numberOSize]);
                Database.shirts.Add(ts);
            }
        }

        protected int InsertAndCheck()
        {
            bool success;
            int select = 0;

            do
            {
                Console.WriteLine();
                Console.Write("\tInsert a number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select a non zerow possitive number.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tPlease select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            return select;
        }

        //============================================= Public methods =======================================================
        public void MenuOfCreateTShirts()
        {
            Console.WriteLine();
            Console.WriteLine("\t");
            Console.WriteLine("\tHow many random variations of T-Shirt would you like?");
            GenerateCombinationsOfShirts(InsertAndCheck());
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
