using System;

namespace Exercises_26__27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 26
            string response = null;
            int total = 0;

            do
            {
                Console.WriteLine("Please enter some text :");
                string text = Console.ReadLine().ToLower();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                    {
                        total++;
                    }
                }

                Console.WriteLine($"Total number of Vowels is {total}");

                Console.WriteLine("Continue y/n ?");
                response = Console.ReadLine();
            }
            while (response == "y");
            if (response == "n")
            {
                Console.WriteLine("Goodbye !");
            }

            ////Exercise 27
            //string response = null;
            //int total = 0;
            //do
            //{
            //    Console.WriteLine("Please enter some text :");
            //    string text = Console.ReadLine().ToLower();

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i] != 'a' && text[i] != 'e' && text[i] != 'i' && text[i] != 'o' && text[i] != 'u' && text[i] != ' ')
            //        {
            //            total++;
            //        }
            //    }

            //    Console.WriteLine($"Total number of Consonants is {total}");

            //    Console.WriteLine("Would you like to continue y/n ?");
            //    response = Console.ReadLine();

            //} while (response == "y");
            //if (response == "n")
            //{
            //    Console.WriteLine("Goodbye !");
            //}


        }
    }
}
