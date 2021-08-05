using System;

namespace MeasureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variable
            int imperialInch = 1;
            decimal milSpin = 3.5m;
            int imperialFoot = 1;
            int milMeme = 5;

            //Initial input, Measurement type
            Console.WriteLine("Please enter a measurement type:");
            Console.Write("(a) Inches    (b) Feet  ");
            Console.Write("(c) Fidget Spinners  (d) Memes");
            var type = Console.ReadLine();

            //# Input for calculation
            Console.WriteLine("Please enter a number :");
            string unit = Console.ReadLine();
            int num1 = int.Parse(unit);

            //Algorithm for calculation
            var total = (num1 * milSpin);

            //'Loop' condition for continuous inputs if desired
            var temp = string.Empty;

            switch (type)
            {
                case "a":
                    Console.WriteLine("");
                    break;
                case "b":
                    Console.WriteLine("");
                    break;
                case "c":
                    Console.WriteLine();
                    break;
                case "d":
                    Console.WriteLine();
                    break;
                default:

                    break;
            }
            do
            {
                //program here
                //ask user if they would like to go through the program again
                Console.WriteLine("Would you like to try again (y/n)");
                var temp = Console.ReadLine().ToLower();
            } while (temp == "y");
        }
    }
}