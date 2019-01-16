using System;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10 or hit 0 for instructions");
            string userGuess = Console.ReadLine();

            if (userGuess.Equals("0"))
            { 
                Console.WriteLine("==INSTRUCTIONS==");
            Console.WriteLine("Guess a number between 1 and 10");
            Console.WriteLine("Hit enter to submit your guess.");

            userGuess = Console.ReadLine();
        }

            Console.WriteLine("You guessed:" + userGuess);
            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You Win!");
            
            }
            else
            {
                Console.WriteLine("You lost.");
            }
        }
    }
}
