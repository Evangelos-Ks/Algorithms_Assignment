using System;

namespace Assignment3.Entities.PaymentMethods
{
    class Credit_DebitCard : PaymetnMethod
    {
        //========================= Properties ========================================
        public override string Name { get; } = "Credit - Debit card";
        protected decimal Limit { get; } = 600;

        //========================= Methods ===========================================
        public override bool Pay(decimal amount)
        {
            if (amount <= 0 || amount > Limit) return false;
            else return true;
        }

        public override void UnsuccessfulMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"\tThe limit for Credit payment is {Limit}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
