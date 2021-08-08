using System;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = null;
            do
            {
                // +1 The app prompts the user to enter an integer between 1 and 100
                // Extra Exercise : Prompt user for their name
                Console.WriteLine("Hello there, what is your name ?");
                string name = Console.ReadLine();

                Console.WriteLine("Hello, " + name + ", Please enter a number between 1 and 100.");

                //take in user input
                string input = Console.ReadLine();
                //change input from string to int, parse
                int parsedInput = int.Parse(input);

                //If the integer is odd, print the # and the word 'Odd'
                //If remainder is 1, then the parsed input is odd, else it is even

                int remainder = parsedInput % 2;

                Console.WriteLine("Remainder: " + remainder);

                if (remainder == 1)
                {
                    if (parsedInput > 60)
                    {
                        Console.WriteLine(parsedInput + " Odd");
                    }
                }
                else if (remainder == 0 && (2 <= parsedInput && parsedInput < 25))
                {
                    //Test cases -> 2, 14 will print the desired
                    Console.WriteLine(name + ", This input is Even and less than 25");
                }
                //If the integer entered is even and in the inclusive range of 26 to 60, print 'Even'
                else if (remainder == 0 && (parsedInput >= 26 && parsedInput <= 60))
                {
                    Console.WriteLine(name + ", This input is Even");
                }
                //If the integer entered is even and greater than 60, print integer and 'Even'
                else if (remainder == 0 && parsedInput > 60)
                {
                    Console.WriteLine(parsedInput + name + ", This input is Even");
                }
                Console.WriteLine("Continue y/n ?");
                response = Console.ReadLine();

            } while (response == "y");
            if (response == "n")
            {
                Console.WriteLine("The program is now ending");
            }
        }
    }
}
