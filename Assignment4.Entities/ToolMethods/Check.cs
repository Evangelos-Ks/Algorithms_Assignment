﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities.ToolMethods
{
    public class Check
    {
        //Ask for a number and checks if it is a higter than zero number
        public static int InsertAndCheckNumber()
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
                    if (select < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select a number highter than zero.");
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


    }
}