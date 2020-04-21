using System;

namespace Assignment3.Entities.PaymentMethods
{
    class Cash : PaymetnMethod
    {
        //========================= Properties ========================================
        public override string Name { get; } = "Cash";

        //========================= Methods ===========================================
        public override bool Pay(decimal amount)
        {
            if (amount <= 0) return false;
            else return true;
        }

        public override void UnsuccessfulMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            //Message
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
