using System;
using System.Collections.Generic;
using System.Linq;

namespace Fives.Gameplay
{
	public class WordSelector
	{
		ValidWord valid = new ValidWord();

		public string SelectWord(IEnumerable<string> wordList)
		{
			wordList = wordList.Where(s => s.Length == 5);

			if (wordList.Any())
			{
				Random rnd = new Random();
				string word = wordList.ElementAt(rnd.Next(wordList.Count()));

				while (!valid.WordIsValid(word))
					word = wordList.ElementAt(rnd.Next(wordList.Count()));

				return word.ToUpper();
			}

			return "";
		}
	}
}