using System;
using System.Collections.Generic;
using System.Linq;

namespace Fives.Gameplay
{
	public class GameEngine
	{
		ValidWord valid;
		GuessComparer comparer;
		WordSelector selector;

		public GameEngine()
		{
			valid = new ValidWord();
			comparer = new GuessComparer();
			selector = new WordSelector();

			LoadWordList();
			StartRound();
		}

		IEnumerable<string> words;
		private void LoadWordList()
		{
			words = new List<string> { "bread", "blarg" };
		}

		private string selectedWord;
		private void SelectWord()
		{
			if (words != null && words.Any())
				selectedWord = selector.SelectWord(words);
		}

		private int guesses;
		private void StartRound()
		{
			SelectWord();
			guesses = 0;
		}

		public GuessResult AcceptGuess(string guess)
		{
			var result = comparer.CompareGuess(guess, selectedWord);
			result.Guesses = ++guesses;

			return result;
		}
	}
}