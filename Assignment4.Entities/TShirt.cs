using Assignment4.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Assignment4.Entities
{
    public class TShirt
    {
        //============================= Properties ===========================================================
        public Color color { get; }
        public Fabric fabric { get; }
        public Size size { get; }
        public decimal TShirtPrice { get; }


        //============================= Constractors ===========================================================
        public TShirt() { }
        public TShirt(Color color, Fabric fabric, Size size)
        {
            this.color = color;
            this.fabric = fabric;
            this.size = size;
            TShirtPrice = (Colors.Cost[color] + Fabrics.Cost[fabric] + Sizes.Cost[size]);
        }

        //============================= Methods ===============================================================
        public void Output(List<TShirt> shirts)
        {
            int count = 1;
            foreach (var shirt in shirts)
            {
                Console.Write("\t");
                Console.WriteLine("{0, -15}{1, -15}{2,-15}{3,-15}", count++, shirt.color, shirt.fabric, shirt.size);
            }
        }

        public decimal CalculatePriceOfTShirts(List<TShirt> shirts)
        {
            decimal amount = 0;

            foreach (var shirt in shirts)
            {
                amount += shirt.TShirtPrice;
            }

            return amount;
        }

        public void DisplayThePriceOfTshirts(decimal amount)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.Write("\t==========================================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"\tThe amount of T-Shirts are {amount}.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
