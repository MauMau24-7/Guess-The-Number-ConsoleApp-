using System;

int guess;
int number;
Random random = new Random();
int tries = 10;
bool playAgain = true;

number = random.Next(1, 100);   // Randomizes the number to guess

while (playAgain && tries != 0)
{

    Console.WriteLine("Guess the number!");
    Console.WriteLine("Guess between 1 - 100");
    //Console.WriteLine(number);
    Console.Write("Guess: ");
    guess = Convert.ToInt16(Console.ReadLine());

    if (guess > number)
    {
        tries--;

        Console.WriteLine("Too high");
        Console.WriteLine($"{tries} tries left");
    }
    else if (guess < number)
    {
        tries--;

        Console.WriteLine("Too low");
        Console.WriteLine($"{tries} tries left");
    }
    else if (guess == number)
    {
        Console.WriteLine("You guessed the right number!");
        Console.WriteLine($"You had {tries - 1} tries left");
        Console.WriteLine($"The number was {number}");
        break;
    }
        if (tries == 0)
        {
            Console.WriteLine("You ran out of tries...");
            Console.WriteLine($"The right number was {number}");
            //Console.WriteLine("Would you like to play again? (Y/N)");
        }
}

Console.ReadKey();
