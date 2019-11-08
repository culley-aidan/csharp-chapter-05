using System;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 11);
            int guesses, guessedNumber = 0, lowGuesses = 0, highGuesses = 0;
            int? nguessedNumber = null;
            for (guesses = 0; guessedNumber != randomNumber; ++guesses)
            {
                string guessHint = nguessedNumber switch
                {
                    null => "Guess the number: ",
                    int x when x > randomNumber => highGuesses++ > 0 ? "Try again, you guessed too high again: " : "Try again, you guessed too high: ",
                    int x when x < randomNumber => lowGuesses++ > 0 ? "Try again, you guessed too low again: " : "Try again you guessed too low: ",
                    _ => "Guess the number: "
                };
                Console.Write(guessHint);
                int.TryParse(Console.ReadLine(), out guessedNumber);
                nguessedNumber = guessedNumber;
            }
            Console.WriteLine("Congratulations, You guessed the number {0} in {1} tries.", randomNumber, guesses);
        }

    }
}
