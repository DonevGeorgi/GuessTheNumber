using System;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main()
        {
            Random randomNumber = new Random();
            int computerChosenNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number in range 1 to 100: ");

                string playerInput = Console.ReadLine();

                bool isNumber = int.TryParse(playerInput, out int playerGuess);

                if (isNumber)
                {
                    if (playerGuess == computerChosenNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    if (playerGuess > computerChosenNumber)
                    {
                        Console.WriteLine("Number is too high.");
                    }
                    else
                    {
                        Console.WriteLine("Number is too low.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
