using System;
using System.Text.RegularExpressions;
namespace Lab_7
{
    class Program
    {
        public static string PromptUser(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }

        //public static bool ValidateEmail(string userEmail, string pattern)
        //{
        //    Regex regex = new Regex(@"([a-zA-Z0-9.!#$%&'*+/=?^_-]{5,29})+(@[a-zA-Z]{0,29})+(.[a-zA-Z0-9]{0,5})");
        //    return regex.IsMatch(userEmail);
        //}

        //public static bool ValidateName(string userInput)
        //{
        //    Regex regex = new Regex(@"(^[A-Z]{1}[a-zA-Z ]{0,29}$)");
        //    return regex.IsMatch(userInput);
        //}

        public static bool ValidateInput(string userInput, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(userInput);

        }
        static void Main(string[] args)
        {
            string name = PromptUser("Please enter your name.");
            //bool isValidName = ValidateName(name);
            bool isValidName = ValidateInput(name, "(^[A-Z]{1}[a-zA-Z ]{0,29}$)");
            if(isValidName == true)
            {
                Console.WriteLine("This is a valid name !");
            }
            else
            {
                Console.WriteLine("This name is not valid !");
            }

            string email = PromptUser("Please enter your email.");
            bool isValidEmail = ValidateInput(email, "([a-zA-Z0-9.!#$%&'*+/=?^_-]{5,29})+(@[a-zA-Z]{0,29})+(.[a-zA-Z0-9]{0,5})");
            if(isValidEmail == true)
            {
                Console.WriteLine("This is a valid email !");
            }
            else
            {
                Console.WriteLine("This email is not valid !");
            }

            string phoneNumber = PromptUser("Please enter your phone number.");
            bool isValidPhoneNumber = ValidateInput(phoneNumber, "([0-9()]{3,5})+-([0-9-]{3})+-([0-9]{4})");
            if(isValidPhoneNumber == true)
            {
                Console.WriteLine("This is a valid phone number !");
            }
            else
            {
                Console.WriteLine("This is not a valid phone number !");
            }

            string date = PromptUser("Please enter your date.");
            bool isValidDate = ValidateInput(date, "([0-9]{2})+([0-9/]{2})+([0-9/]{4})");
            if(isValidDate == true)
            {
                Console.WriteLine("This is a valid date !");
            }
            else
            {
                Console.WriteLine("This is not a valid date !");
            }

            // Console.WriteLine(ValidateName("Sean Flanigan"));
            // prompt user for a name, and set it
            // string userName = PromptUser(string question)
            // validate user's name
            // ValidateName(userName);
        }
    }
}
