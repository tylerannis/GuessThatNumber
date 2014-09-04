using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGame();
            Console.ReadKey();
        }
        static void NumberGame()
        {
            
            //variable for number of guesses
            int counter = 0;
            //random number generator
            Random game = new Random();
            int answer = game.Next(1, 101);
            //instructions
            Console.WriteLine("Please guess a number between 1 and 100.");
            bool winner = false;
           
            while (!winner)
            {
                //variable for user input
                string input = Console.ReadLine();
                //parse input to make it an int
                int guess = int.Parse(input);
                //make your commands for the game
                if (answer == guess)
                {
                    winner = true;
                    Console.WriteLine("Congratulations, you must be a lucky guesser!");
                    counter++;
                }
                else if (answer > guess)
                {
                    Console.WriteLine("You're to low, guess higher!");
                    counter++;
                }
                else if (answer < guess)
                {
                    Console.WriteLine("Oh no! You're to high, come down a bit.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Please play the game right!");
                    counter++;
                }
            }
            Console.WriteLine("It took you " + counter + " guesses to win.");
        }
    }
}
