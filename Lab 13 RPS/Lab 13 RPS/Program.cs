using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_13_RPS
{
    public enum RPS
    {
        rock,
        paper,
        scissors,
    }

    public interface Player
    {
        string Name
        {
            get;
            set;
        }

        RPS GenerateRPS();
    }

    public class RockPlayer : Player
    {
        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }

    public class RandomPlayer : Player
    {
        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            var random = new Random();
            var randomPlayer = random.Next(1, 4);
            if(randomPlayer == 1)
            {
                return RPS.rock;
            }
            else if(randomPlayer == 2)
            {
                return RPS.paper;
            }
            else
            {
                return RPS.scissors;
            }
        }
    }

    public class HumanPlayer : Player
    {
        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            var input = Console.ReadLine();

            if(input == "rock")
            {
                return RPS.rock;
            }
            else if (input == "paper")
            {
                return RPS.paper;
            }
            else
            {
                return RPS.scissors;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors ! Please enter your name :");
            var Name = Console.ReadLine();

            Console.WriteLine("Please select an opponent : 1. Rock Player   2. Random Player");
            string input = Console.ReadLine().ToLower();

            if (input == "rock player")
            {
                return RockPlayer;
            }
            else
            {
                return RandomPlayer;
            }
            //RockPlayer rock = new RockPlayer();
            //rock.Name = "Dwayne";

            //RandomPlayer rdm = new RandomPlayer();

            //Console.WriteLine(rdm.GenerateRPS());

        }
    }
}
