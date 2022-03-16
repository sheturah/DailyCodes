using System;

namespace _1321DailyCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, z, w;
            float answer;

            Console.WriteLine("[Math Mad Libs]");

            Console.WriteLine("\nx + (y / z) * w = ? ");
            Console.WriteLine("Enter the first term: ");
            x = Single.Parse(Console.ReadLine());


            Console.WriteLine("\n" + x + " + (y / z) * w = ? ");
            Console.WriteLine("Enter the second term: ");
            y = Single.Parse(Console.ReadLine());

            Console.WriteLine("\n" + x + " + (" + y + " / z) * w = ? ");
            Console.WriteLine("Enter the third term: ");
            z = Single.Parse(Console.ReadLine());

            Console.WriteLine("\n" + x + " + (" + y + " / " + z + ") * w = ? ");
            Console.WriteLine("Enter the first term: ");
            w = Single.Parse(Console.ReadLine());


            answer = x + (y / z) * w;
            Console.WriteLine("\n" + x + " + (" + y + " / " + z + ") * " + w + " = " + answer);
        }
    }
}
