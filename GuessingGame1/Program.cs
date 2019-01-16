using System;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You Guessed:" + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You Win!");
            }
            else if (userGuess.Equals("0"))
            {
                Console.WriteLine("Try again!");
            }
            else
            {
                Console.WriteLine("You lost.");
            }
        }
    }
}
