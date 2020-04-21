using System;
using System.Collections.Generic;

namespace Assignment3.Entities.PaymentMethods
{
    public abstract class PaymetnMethod
    {
        public abstract string Name { get; }
        public abstract bool Pay(decimal amount);

        //===================================== Methods ====================================================================
        public static List<PaymetnMethod> paymentMethodsList = new List<PaymetnMethod>() 
        {
            new Credit_DebitCard(),
            new BankTransfer(),
            new Cash(),
        };

        public void DisplayTransactionApprouved(bool pay)
        {
            if (pay)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("\tThe transaction was successful.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("\tThe transaction was unsuccessful.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.Write("\t==========================================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
