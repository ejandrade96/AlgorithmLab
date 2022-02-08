using System;
using AlgorithmLab.Models;
using FluentAssertions;
using Xunit;

namespace TestsAlgorithmLab
{
  /*
    Given an array of integers, find the sum of its positive elements.
  */
  public class SimpleArraySumTest
  {
    [Fact]
    public void CheckIfTheNumberIsPositiveOrGreaterThan1000_GivenAPositiveNumber_ReturnsSameNumber()
    {
      var simpleArraySum = new SimpleArraySum();
      var number = 2;

      var result = simpleArraySum.CheckIfTheNumberIsPositiveOrGreaterThan1000(number);

      result.Should().Be(number);
    }

    [Fact]
    public void CheckIfTheNumberIsPositiveOrGreaterThan1000_GivenANegativeNumber_ReturnsZero()
    {
      var simpleArraySum = new SimpleArraySum();
      var number = -2;

      var result = simpleArraySum.CheckIfTheNumberIsPositiveOrGreaterThan1000(number);

      result.Should().Be(0);
    }

    [Fact]
    public void CheckIfTheNumberIsPositiveOrGreaterThan1000_GivenANumberGreaterThan1000_ReturnsException()
    {
      var simpleArraySum = new SimpleArraySum();
      var number = 1001;

      Action act = () => simpleArraySum.CheckIfTheNumberIsPositiveOrGreaterThan1000(number);

      act.Should().Throw<ArgumentException>()
                  .WithMessage("Array numbers must not be greater than 1000");
    }

    [Fact]
    public void GetTheSumPositiveNumbers_GivenAnArrayOfIntegersWhereMaximumNumberIs1000_ReturnsSumOfPositiveNumbers()
    {
      var simpleArraySum = new SimpleArraySum();
      var array = new int[10] { 3, 5, -8, 10, -15, 7, -5, 9, -4, 6 };

      var result = simpleArraySum.GetTheSumPositiveNumbers(array);

      result.Should().Be(40);
    }

    [Fact]
    public void GetTheSumPositiveNumbers_GivenAnArrayOfIntegersWhereThereIsSomeNumberGreaterThan1000_ReturnsAnException()
    {
      var simpleArraySum = new SimpleArraySum();
      var array = new int[10] { 3, 5, -8, 10, -15, 1001, -5, 9, -4, 6 };

      Action act = () => simpleArraySum.GetTheSumPositiveNumbers(array);

      act.Should().Throw<ArgumentException>()
                  .WithMessage("Array numbers must not be greater than 1000");
    }
  }
}