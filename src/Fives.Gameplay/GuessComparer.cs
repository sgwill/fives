using System;
using System.Collections.Generic;

namespace Fives.Gameplay
{
	public class GuessComparer
	{
		ValidWord valid = new ValidWord();

		public GuessResult CompareGuess(string guess, string word)
		{
			guess = guess.ToUpper();
			word = word.ToUpper();
			GuessResult result = new GuessResult();

			if (valid.WordIsValid(guess))
			{
				if (guess == word)
				{
					result.Matches = 5;
					result.InPlace = 5;
				}
				else
				{
					// Use each letter only once
					List<char> match = new List<char>();
					List<int> inPlace = new List<int>();

					// Check how many letters match and in place
					for (int i = 0; i < 5; i++)
					{ // Selected word is i
						for (int j = 0; j < 5; j++)
						{ // guess is j
							if (guess[j] == word[i])
							{
								// Add to list of letters already tried 
								// Increment matches
								if (!match.Contains(Convert.ToChar(guess[i].ToString().ToUpper())))
								{
									match.Add(Convert.ToChar(guess[i].ToString().ToUpper()));
									result.Matches++;
								}

								// Check if the letter is in the right place
								if (!inPlace.Contains(j))
								{
									if (guess[j] == word[j])
									{
										result.InPlace++;
										inPlace.Add(j);
									}
								}
							}
						}
					}

				}
			}

			return result;
		}
	}
}