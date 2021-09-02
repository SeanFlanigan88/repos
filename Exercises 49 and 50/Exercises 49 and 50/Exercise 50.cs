using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercises_49_and_50
{
    class Exercise_50
    {
        static void Main(string[] args)
        {
            List<string> numberInput = new List<string>();

            Console.WriteLine("Please enter a side length");
            string input = Console.ReadLine();

            numberInput.Add(input);
            //int maxInput = int.Parse(numberInput.Max());
            //int minInput = int.Parse(numberInput.Min());

            while (input != "q")
            {
                Console.WriteLine("Please enter a side length (q to quit)");
                input = Console.ReadLine();

                if (input != "q")
                {
                    numberInput.Add(input);
                }
            }

            int maxInput = int.Parse(numberInput.Max());
            int minInput = int.Parse(numberInput.Min());
            int area = maxInput * maxInput;
            int perimeter = maxInput * 4;

            if (input == "q")
            {
                Console.WriteLine($"Largest : {maxInput} Smallest : {minInput} Largest Area : {area} Largest Perimeter : {perimeter}");
            }
        }
    }
}
