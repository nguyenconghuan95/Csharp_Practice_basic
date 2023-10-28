using System;

namespace GuessNumber
{
    public class Program
    {
        //Properties

        //Constructor

        //Main method
        public static void Main(string[] args)
        {
            string input = "";
            Random programRand = new Random();
            int programNum = programRand.Next(1, 100);
            int guessNumber = 0;

            while (input.ToLower() != "exit")
            {
                Console.WriteLine($"Guess a number between 1-100 (or type 'exit' to exit the program):");
                input = Console.ReadLine();

                //Check if input is integer or exit command
                while (!int.TryParse(input, out guessNumber) && (input != "exit"))
                {
                    Console.WriteLine($"Please input an integer between 1-100:");
                    input = Console.ReadLine();
                }

                if (input == "exit") break;

                if (guessNumber != programNum)
                {
                    Console.WriteLine($"Wrong guessing number! Too {(guessNumber < programNum ? "Low" : "High")}");
                }
                else
                {
                    Console.WriteLine($"CONGRATULATION!!! Your guess is right. Enter to continue.");
                    programNum = programRand.Next(1, 100); //Prepare for the next guess if the guess is right
                    Console.ReadLine();
                }
            }
        }

    }

}