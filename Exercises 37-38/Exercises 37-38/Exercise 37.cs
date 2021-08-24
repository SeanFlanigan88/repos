using System;

namespace Exercises_37_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = null;
            do
            {
                double[] array = new double[5];

                Console.WriteLine("Please enter 5 numbers :");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }

                double sum = 0;

                foreach (double d in array)
                {
                    sum += d;
                }
                Console.WriteLine(sum);

                Console.WriteLine("Would you like to continue y/n ?");
                response = Console.ReadLine();
            } while (response == "y");
        }
    }
}
