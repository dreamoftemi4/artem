using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 5;
            double j = 0;

            while (i > -1000)
            {
                i -= j;
                j--;
            }
            Console.WriteLine("Summa = " + i);

            Console.WriteLine("Ответ = {0}", i / j);
            Console.ReadKey();
        }
    }
}
