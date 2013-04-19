using System;
using System.Collections.Generic;
using Xunit;

namespace Fives.Gameplay.Test
{
	public class GuessComparerTests
	{
		[Fact]
		public void GuessComparer_ExactMatch_ReturnsExactMatch()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("bread", "bread");

			Assert.Equal(5, result.InPlace);
			Assert.Equal(5, result.Matches);
		}

		[Fact]
		public void GuessComparer_ExactMatch_ReturnsExactMatch_IgnoresCase()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("bread", "BREAD");

			Assert.Equal(5, result.InPlace);
			Assert.Equal(5, result.Matches);
		}

		[Fact]
		public void GuessComparer_EmptyGuess_ReturnsNoMatch()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("", "BREAD");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(0, result.Matches);
		}

		[Fact]
		public void GuessComparer_InvalidGuess_ReturnsNoMatch_IgnoresCase()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("APPLE", "BREAD");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(0, result.Matches);
		}

		[Fact]
		public void GuessComparer_0Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("GHIJK", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(0, result.Matches);
		}

		[Fact]
		public void GuessComparer_1Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("EFGHI", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(1, result.Matches);
		}

		[Fact]
		public void GuessComparer_2Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("DEFGH", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(2, result.Matches);
		}

		[Fact]
		public void GuessComparer_3Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("CDEFG", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(3, result.Matches);
		}

		[Fact]
		public void GuessComparer_4Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("BCDEF", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(4, result.Matches);
		}

		[Fact]
		public void GuessComparer_5Match_0InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("BCDEA", "ABCDE");

			Assert.Equal(0, result.InPlace);
			Assert.Equal(5, result.Matches);
		}

		[Fact]
		public void GuessComparer_5Match_1InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("BCDAE", "ABCDE");

			Assert.Equal(1, result.InPlace);
			Assert.Equal(5, result.Matches);
		}

		[Fact]
		public void GuessComparer_4Match_4InPlace()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("ABCDF", "ABCDE");

			Assert.Equal(4, result.InPlace);
			Assert.Equal(4, result.Matches);
		}

		[Fact]
		public void GuessComparer_4Match_4InPlace_IgnoresCase()
		{
			GuessComparer comparer = new GuessComparer();
			var result = comparer.CompareGuess("abcdf", "ABCDE");

			Assert.Equal(4, result.InPlace);
			Assert.Equal(4, result.Matches);
		}
	}
}