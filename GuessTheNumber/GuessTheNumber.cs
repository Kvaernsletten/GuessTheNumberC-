using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvaernsletten
{
    internal class GuessTheNumber
    {

        public int randomNumber;
        public string input = "";
        public int attempts = 0;

        public void Run()
        {
            GenerateNumbers();
            Console.WriteLine(randomNumber);
            Console.WriteLine("I have generated a number between 1 and 100, guess which number it is by typing below: ");
            Guess();
        }

        public void GenerateNumbers()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        public void Guess()
        {
            input = Console.ReadLine();
            int guessedNumber;

            if (int.TryParse(input, out guessedNumber))
            {
                if (guessedNumber == randomNumber)
                {
                    attempts++;
                    Console.WriteLine($"Correct! You guessed the number in {attempts} {(attempts <= 1 ? "attempt" : "attempts")}");
                    Console.WriteLine("Press ENTER to play again");
                    Console.ReadLine();
                    PlayAgain();
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Wrong! Your number is too low!");
                    attempts++;
                    Guess();
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Wrong! Your number is too high!");
                    attempts++;
                    Guess();
                }
            }
        }

        public void PlayAgain()
        {
            attempts = 0;
            Console.Clear();
            GenerateNumbers();
            Console.WriteLine("I have generated a number between 1 and 100, guess which number it is by typing below: ");
            Guess();
        }
    }
}
