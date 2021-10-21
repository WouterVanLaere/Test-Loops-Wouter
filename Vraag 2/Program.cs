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
            string input;
            double score;
            do
            {
                int i = 0;
                double totalScore = 0;
                Console.WriteLine("What is the name of the student?");
                string student = Console.ReadLine();
                do
                {
                    Console.WriteLine("What score would you like to enter? English, Programming, or Networking?");
                    string course = Console.ReadLine();
                    Console.Clear();
                    do
                    {

                        Console.WriteLine($"What is the scores {course} for {student} between 5 and 10?");

                        score = double.Parse(Console.ReadLine());
                        if (score >= 5 && score <= 10)
                        {
                            totalScore += score;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("The score has to be between 5 and 10.");
                        }
                    } while (score < 05 || score > 10);
                    Console.Clear();
                } while (i < 3);
                double average = totalScore / 3;
                Console.WriteLine($"{student} had a total score of {totalScore}/30 and their average is {average:n2}.");

                Console.WriteLine("Do you want to add another student? y/n");
                input = Console.ReadLine();
                Console.Clear();
            } while (input == "y");

        }
    }
}
