using System;

class GuessingGame
{
    static void Main()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101);
        int guess = 0;
        int numGuesses = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            numGuesses++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        Console.WriteLine("Congratulations, you guessed the number in " + numGuesses + " guesses!");
    }
}
