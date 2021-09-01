using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10
{
    public enum MovieType
    {
        Unknown,
        Animated,
        Horror,
        Drama,
        Scifi,
    }
    class Program
    {
        string input = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application !");
            Console.WriteLine("There are X Movies on this list.");
            Console.WriteLine("What Category are you interested in ?");
            Console.WriteLine("1. Animated  2. Horror\n3. Drama 4. Scifi");

            List<Movie> animated = new List<Movie>();
            Movie a1 = new Movie("Frozen", MovieType.Animated);
            Movie a2 = new Movie("Luca", MovieType.Animated);
            Movie a3 = new Movie("Up", MovieType.Animated);
            animated.Add(a1);
            animated.Add(a2);
            animated.Add(a3);

            List<Movie> horror = new List<Movie>();
            Movie h1 = new Movie("Saw", MovieType.Horror);
            Movie h2 = new Movie("Resident Evil", MovieType.Horror);
            Movie h3 = new Movie("Spiral", MovieType.Horror);
            horror.Add(h1);
            horror.Add(h2);
            horror.Add(h3);

            List<Movie> drama = new List<Movie>();
            Movie d1 = new Movie("The Imitation Game", MovieType.Drama);
            Movie d2 = new Movie("SE7EN", MovieType.Drama);
            drama.Add(d1);
            drama.Add(d2);

            List<Movie> scifi = new List<Movie>();
            Movie s1 = new Movie("The Avengers", MovieType.Scifi);
            Movie s2 = new Movie("Black Widow", MovieType.Scifi);
            Movie s3 = new Movie("Jurassic Park", MovieType.Scifi);
            scifi.Add(s1);
            scifi.Add(s2);
            scifi.Add(s3);

            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Console.WriteLine(animated);
                    break;
                case "2":
                    Console.WriteLine(horror);
                    break;
                case "3":
                    Console.WriteLine(drama);
                    break;
                case "4":
                    Console.WriteLine(scifi);
                    break;
                default:
                    Console.WriteLine("Value Unknown");
                    break;
            }
        }
    }
}
