using System;

namespace TotalTip
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, tax, delivery;

            double TotalTax, Subtotal, TenTip, TwentyTip, TotalTen, TotalTwenty;

            //asking the user for information to use in calculations
            Console.WriteLine("[Tip Calculator]");
            Console.WriteLine("Enter the total price of the meal: ");
            total = Single.Parse(Console.ReadLine());

            Console.WriteLine("Enter the local tax rate: ");
            tax = Single.Parse(Console.ReadLine());

            Console.WriteLine("Enter the delievery free: ");
            delivery = Single.Parse(Console.ReadLine());

            //calculations for determining tips
            TotalTax = total * tax;
            Subtotal = total + delivery;
            TenTip = Subtotal * .10;
            TwentyTip = (Subtotal * .20);
            TotalTen = TenTip + Subtotal + TotalTax;
            TotalTwenty = TwentyTip + Subtotal + TotalTax;

            TenTip = Math.Round(TenTip, 3);
            TwentyTip = Math.Round(TwentyTip, 3);
            TotalTen = Math.Round(TotalTen, 3);
            TotalTwenty = Math.Round(TotalTwenty, 3);

            //the total after taxes and delivery
            Console.WriteLine("\nA 10% tip would be $" + TenTip);
            Console.WriteLine("The total would be $" + TotalTen);

            Console.WriteLine("\nA 20% tip would be $" + TwentyTip);
            Console.WriteLine("The total would be $" + TotalTwenty);
        }

        //method that returns the double with three decimal places
        //overall was useful yet it didnt round up
        public static double ThreeDecimals(double total)
        {
            total = Math.Truncate(total * 1000) / 1000;
            return total;
        }
    }
}

