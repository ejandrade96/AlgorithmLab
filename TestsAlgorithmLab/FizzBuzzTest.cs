using System.Linq;
using AlgorithmLab.Models;
using FluentAssertions;
using Xunit;

namespace TestsAlgorithmLab
{
  public class FizzBuzzTest
  {
    [Fact]
    public void CheckTheNumberIsDivisible_IfIsDivisibleBy3_ReturnsFizz()
    {
      var fizzBuzz = new FizzBuzz();

      var result = fizzBuzz.CheckTheNumberIsDivisible(3);

      result.Should().Be("Fizz");
    }

    [Fact]
    public void CheckTheNumberIsDivisible_IfIsDivisibleBy5_ReturnsBuzz()
    {
      var fizzBuzz = new FizzBuzz();

      var result = fizzBuzz.CheckTheNumberIsDivisible(5);

      result.Should().Be("Buzz");
    }

    [Fact]
    public void CheckTheNumberIsDivisible_IfIsDivisibleBy3And5_ReturnsFizzBuzz()
    {
      var fizzBuzz = new FizzBuzz();

      var result = fizzBuzz.CheckTheNumberIsDivisible(15);

      result.Should().Be("FizzBuzz");
    }

    [Fact]
    public void CheckTheNumberIsDivisible_IfNotDivisibleBy3And5_ReturnsNumber()
    {
      var fizzBuzz = new FizzBuzz();

      var result = fizzBuzz.CheckTheNumberIsDivisible(1);

      result.Should().Be("1");
    }

    [Fact]
    public void CountToTheNumber_IfNumberIs15_ReturnsSpecificList()
    {
      var fizzBuzz = new FizzBuzz();
      var expectedList = new string[15] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

      var result = fizzBuzz.CountTheNumber(15).SequenceEqual(expectedList);

      result.Should().BeTrue();
    }
  }
}
