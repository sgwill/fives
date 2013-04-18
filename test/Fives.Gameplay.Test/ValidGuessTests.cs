using System;
using Xunit;

namespace Fives.Gameplay.Test
{
	public class ValidGuessTests
	{
		[Fact]
		public void FiveCharacters_IsValid()
		{
			ValidGuess guess = new ValidGuess();
			Assert.True(guess.GuessIsValid("abcde"));
		}

		[Fact]
		public void LessThanFiveCharacters_IsInValid()
		{
			ValidGuess guess = new ValidGuess();
			Assert.False(guess.GuessIsValid("abcd"));
		}

		[Fact]
		public void MoreThanFiveCharacters_IsInValid()
		{
			ValidGuess guess = new ValidGuess();
			Assert.False(guess.GuessIsValid("abcdef"));
		}

		[Fact]
		public void OnlyFiveDistinctCharacters_IsValid()
		{
			ValidGuess guess = new ValidGuess();
			Assert.False(guess.GuessIsValid("aaaaa"));
			Assert.False(guess.GuessIsValid("aaaab"));
			Assert.False(guess.GuessIsValid("aaabc"));
			Assert.False(guess.GuessIsValid("aabcd"));
		}
	}
}