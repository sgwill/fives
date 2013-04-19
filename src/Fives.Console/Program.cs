using Fives.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fives.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			GameEngine engine = new GameEngine();

			System.Console.WriteLine("Welcome to Fives. Enter your guess. Type 'quit' to quit");

			string guess = "";
			bool gameOver = false;
			do
			{
				guess = System.Console.ReadLine();

				if (guess == "quit")
				{
					System.Console.WriteLine("Sorry to see you go");
					gameOver = true;
				}
				else
				{
					var result = engine.AcceptGuess(guess);
					if (result.InPlace == 5)
					{
						System.Console.WriteLine("You won. The word is {0}. It took you {1} guesses.", guess, result.Guesses);
						gameOver = true;
					}
					else
					{
						System.Console.WriteLine("Incorrect. You have {0} matched letters, and {1} are in the right place.", result.Matches, result.InPlace);
						gameOver = false;
					}
				}
			}
			while (gameOver != true);
		}
	}
}