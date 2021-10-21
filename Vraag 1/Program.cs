using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int i = 0;
            int number;
            int biggestNumber = 0;
            while (i < 3)
            {
                number = int.Parse(Console.ReadLine());
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
                i++;
            }
            Console.WriteLine($"The biggest number is {biggestNumber}");
        }
    }
}
