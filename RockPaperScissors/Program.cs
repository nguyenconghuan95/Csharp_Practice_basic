using System;

namespace RockPaperScissors
{
    public class Program
    {
        //Properties

        //Constructor

        //Main method
        public static void Main(string[] args)
        {
            string[] options = new string[] { "rock", "paper", "scissors" };
            Random programRand = new Random();

            string input = "";

            while (input != "exit")
            {
                string programResult = options[programRand.Next(0, 2)];

                Console.Write("Input your play (rock or r, paper or p, scissors or s) or type exit to exit the program: ");
                input = Console.ReadLine();

                if (input.ToLower() == "exit") break;

                Console.WriteLine($"The program get {programResult}");

                switch (input.ToLower())
                {
                    case "r":
                    case "rock":
                        Console.WriteLine($"You {(programResult == "rock" ? "Tie" : (programResult == "paper" ? "Win" : "Loose"))}");
                        break;

                    case "p":
                    case "paper":
                        Console.WriteLine($"You {(programResult == "paper" ? "Tie" : (programResult == "rock" ? "Win" : "Loose"))}");
                        break;

                    case "s":
                    case "scissors":
                        Console.WriteLine($"You {(programResult == "scissors" ? "Tie" : (programResult == "paper" ? "Win" : "Loose"))}");
                        break;

                }
            }


        }

    }

}