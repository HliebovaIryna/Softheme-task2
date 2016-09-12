using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    Console.WriteLine("Number {0} is evenly divisible by  {1}", num, i);

            Console.ReadKey();

        }
    }
}
