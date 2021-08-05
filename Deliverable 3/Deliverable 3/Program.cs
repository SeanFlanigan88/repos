using System;

namespace Deliverable_3
{
    class Program
    {
        //● 1 Point: The application prompts to the user to enter an integer between 1 and 100.
        //● The application displays the associated result based on the integer range entered.
        //● 1 Point: Use if/else statements to make different actions depending on user input.
        //● Given an integer entered by a user, perform the following conditional actions:
        //○ 1 Point: If the integer is odd, print the number entered and “Odd.”
        //○ 1 Point: If the integer entered is even and in the inclusive range of 2 to 25,
        //print “Even and less than 25.”
        //○ 1 Point: If the integer entered is even and in the inclusive range of 26 to 60,
        //print “Even.”
        //○ 1 Point: If the integer entered is even and greater than 60, print the number
        //entered and “Even”.
        //○ 1 Point: If the integer entered is odd and greater than 60, print the number
        //entered and “Odd.”
        static void Main(string[] args)
        {
            // +1 The app prompts the user to enter an integer between 1 and 100
            Console.WriteLine("Please enter a number between 1 and 100.");

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
                    Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine(parsedInput + "Odd");
                }
            }
            else if (remainder == 0 && (2 <= parsedInput && parsedInput < 25))
            {
                //Test cases -> 2, 14 will print the desired
                Console.WriteLine("Even and less than 25");
            }
            //If the integer entered is even and in the inclusive range of 26 to 60, print 'Even'
            else if (remainder == 0 && (parsedInput >= 26 && parsedInput <= 60))
            {

                Console.WriteLine("Even");
            }
        }
    }
}
