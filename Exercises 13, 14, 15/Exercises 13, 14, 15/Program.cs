using System;

namespace Exercises_13__14__15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 13
            string response = null;
            do
            {

                Console.WriteLine("Please enter a value : ");
                string input = Console.ReadLine();

                int parseInput = int.Parse(input);
                int[] inputArray = { parseInput };

                for (int i = parseInput; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Continue y/n ?");
                response = Console.ReadLine();

            } while (response == "y");

            if (response == "n")
            {
                Console.WriteLine("Goodbye");
            }
            //Exercise 14
            //string response = null;
            //do
            //{

            //    Console.WriteLine("Please enter a value : ");
            //    string input = Console.ReadLine();

            //    int parseInput = int.Parse(input);
            //    int[] inputArray = { parseInput };

            //    for (int i = 1; i <= parseInput; i++)
            //    {
            //        Console.WriteLine(i * i);
            //    }
            //    Console.WriteLine("Continue y/n ?");
            //    response = Console.ReadLine();

            //} while (response == "y");

            //if (response == "n")
            //{
            //    Console.WriteLine("Goodbye");
            //}

            //Exercise 15
            //string response = null;
            //do
            //{

            //    Console.WriteLine("Please enter a value : ");
            //    string input = Console.ReadLine();

            //    int parseInput = int.Parse(input);
            //    int[] inputArray = { parseInput };

            //    for (int i = 1; i <= parseInput; i++)
            //    {
            //        Console.WriteLine(i * i * i);
            //    }
            //    Console.WriteLine("Continue y/n ?");
            //    response = Console.ReadLine();

            //} while (response == "y");

            //if (response == "n")
            //{
            //    Console.WriteLine("Goodbye");
            //}
        }
    }
}
