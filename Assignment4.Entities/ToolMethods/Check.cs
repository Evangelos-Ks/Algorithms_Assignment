using System;

namespace Assignment4.Entities.ToolMethods
{
    public class Check
    {
        //============================================= Contractor =========================================================
        public Check()
        {
            comparison comparison = CheckMaterialsAsc;
            comparison = CheckMaterialsDesc;
        }

        //============================================= Methods ============================================================

        //Ask for a number and checks if it is a higter than zero number
        public static int InsertAndCheckNumber(int limitOfNumberSelection)
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
                    if (select < 1 || select > limitOfNumberSelection)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select an appropriate number.");
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

        //It Compares and return a bool
        protected bool CheckMaterialsAsc(TShirt shirt1, TShirt shirt2)
        {
            if ((int)shirt1.size > (int)shirt2.size) return true;
            else if (((int)shirt1.color > (int)shirt2.color)) return true;
            else if (((int)shirt1.fabric > (int)shirt2.fabric)) return true;
            else return false;
        }

        //It Compares and return a bool
        protected bool CheckMaterialsDesc(TShirt shirt1, TShirt shirt2)
        {
            if ((int)shirt1.size < (int)shirt2.size) return true;
            else if (((int)shirt1.color < (int)shirt2.color)) return true;
            else if (((int)shirt1.fabric < (int)shirt2.fabric)) return true;
            else return false;
        }

        //============================================= Delegates ==========================================================

        public delegate bool comparison(TShirt shirt1, TShirt shirt2);
    }
}
