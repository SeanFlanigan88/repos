using System;
using System.Collections.Generic;

namespace Deliverable1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password with an upper and lower case letter, number, and special character");
            string password = Console.ReadLine();
        }
        static bool CheckPassword(string input)
        {
            bool hasNum = false;
            bool hasCap = false;
            bool hasLow = false;
            bool hasSpec = false;

            if (!(input.Length < 7 || input.Length > 12))
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                currentCharacter = input[i];
                if (char.IsDigit(currentCharacter))
                {
                    hasNum = true;
                }
                else if (char.IsUpper(currentCharacter))
                {
                    hasCap = true;
                }
                else if (char.IsLower(currentCharacter))
                {
                    hasLow = true;
                }
                else if (!char.IsLetterOrDigit(currentCharacter))
                {
                    hasSpec = true;
                }

                if (hasNum && hasCap && hasLow && hasSpec)
                {
                    return true;
                }
            }
        }
    }
}
