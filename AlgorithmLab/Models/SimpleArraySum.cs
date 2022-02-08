using System;

namespace AlgorithmLab.Models
{
  public class SimpleArraySum
  {
    public void Solve(int[] numbers)
    {
      Console.WriteLine(GetTheSumPositiveNumbers(numbers));
    }

    public int GetTheSumPositiveNumbers(int[] numbers)
    {
      var sum = 0;

      for (var i = 0; i < numbers.Length; i++)
      {
        sum += CheckIfTheNumberIsPositiveOrGreaterThan1000(numbers[i]);
      }

      return sum;
    }

    public int CheckIfTheNumberIsPositiveOrGreaterThan1000(int number)
    {
      if (number > 1000)
        throw new ArgumentException("Array numbers must not be greater than 1000");

      else if (number > 0)
        return number;

      else
        return 0;
    }
  }
}