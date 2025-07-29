using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task: Grade Checker
            //        int MinGrade = 0;
            //        int MaxGrade = 100;
            //        Console.WriteLine($"Please Enter your mark from {MinGrade} to {MaxGrade} :");
            //        double grade = Convert.ToDouble(Console.ReadLine());
            //        if (grade >= MinGrade && grade <= MaxGrade)
            //        {
            //            if (grade >= 90 && grade <= 100)
            //                Console.WriteLine("Your Grade is A");
            //            else if (grade >= 80 && grade <=89)
            //                Console.WriteLine("Your Grade is B");
            //            else if (grade >= 70 && grade <= 79)
            //                Console.WriteLine("Your Grade is C");
            //            else if (grade >= 60 && grade <= 69)
            //                Console.WriteLine("Your Grade is D");
            //            else
            //                Console.WriteLine("Your Grade is F");
            //        }
            //        else 
            //            Console.WriteLine("You Entered Wrong Value");

            //=====================================================================

            //Multiplication Table:

            Console.WriteLine("Please Enter a number to print its multiplication table :");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i} ");

            }
        }
    }
    }
