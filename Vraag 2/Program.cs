using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double totalScore = 0;

            Console.WriteLine("What is the name of the student?");
            string student = Console.ReadLine();
            
            do
            {
                Console.WriteLine($"What are the scores for {student} between 5 and 10?");
                double score = double.Parse(Console.ReadLine());
                if (score >= 5 && score <= 10)
                {
                    totalScore += score;
                    i++;
                }
                else
                {
                    Console.WriteLine("The score has to be between 5 and 10.");
                }
            } while (i < 3);

            double average = totalScore / 3;
            Console.WriteLine($"{student} had a total score of {totalScore}/30 and their average is {average:n2}.");
        }
    }
}
