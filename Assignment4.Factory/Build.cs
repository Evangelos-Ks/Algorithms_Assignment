using Assignment4.Database;
using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Entities.ToolMethods;
using Assignment4.Entities.Sorting_Algorithms;

namespace Assignment4.Factory
{
    public class Build
    {
        //============================================= Properties =======================================================
        protected MyDatabase Database { get; }
        protected TShirt Shirt { get; }

        //============================================= Constructor methods ==============================================
        public Build()
        {
            Shirt = new TShirt();
            Database = new MyDatabase();
        }

        //============================================= Protected methods ================================================
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

        protected void SelectSorting()
        {
            Check check = new Check();

            int input = Check.InsertAndCheckNumber();

            switch (input)
            {
                case 1 :
                    BubbleSort.ExecuteBubbleSort(Database.shirts, (x, y) => x > y);
                    break;
                case 2:
                    BubbleSort.ExecuteBubbleSort(Database.shirts, (x, y) => x < y);
                    break;
                case 3:
                    QuickSort.ExecuteQuickSort(Database.shirts, 0, Database.shirts.Count - 1, (x , y) => x > y);
                    break;
                case 4:
                    QuickSort.ExecuteQuickSort(Database.shirts, 0, Database.shirts.Count - 1, (x, y) => x < y);
                    break;
                default:
                    BubbleSort.ExecuteBubbleSort(Database.shirts, (x, y) => x > y);
                    break;
            }
        }


        //============================================= Public methods ===================================================
        public void MenuOfCreateTShirts()
        {
            Console.WriteLine();
            Console.WriteLine("\t");
            Console.WriteLine("\tHow many random variations of T-Shirt would you like?");
            GenerateCombinationsOfShirts(Check.InsertAndCheckNumber());
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t");
            Console.Write("{0, -15}{1,-15}{2,-15}{3,-15}", "Number" , "Color", "Fabric", "Size");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Shirt.Output(Database.shirts);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t==========================================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SelectSortingMenu()
        {
            string @continue;

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tPlease select the number of the appropriate sorting.");
                Console.WriteLine();
                Console.WriteLine("\t1. Size in ascending");
                Console.WriteLine("\t2. Size in descending");
                Console.WriteLine("\t3. Color in ascending");
                Console.WriteLine("\t4. Color in descending");
                Console.WriteLine("\t5. Fabric in ascending");
                Console.WriteLine("\t6. Fabric in descending");
                Console.WriteLine("\t7. Size and Color and Fabric in ascending");
                Console.WriteLine("\t8. Size and Color and Fabric in descending");

                SelectSorting();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t");
                Console.Write("{0, -15}{1,-15}{2,-15}{3,-15}", "Number", "Color", "Fabric", "Size");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Shirt.Output(Database.shirts);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\tWhould you like to select another sorting? Yes = Y , No = any key ");
                Console.ForegroundColor = ConsoleColor.White;
                @continue = Console.ReadLine().ToUpper();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.Write("\t==========================================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

            } while (@continue == "Y" );
            Console.WriteLine();
            Console.WriteLine("\tThank you");
            Console.WriteLine();
        }
        
    }
}
