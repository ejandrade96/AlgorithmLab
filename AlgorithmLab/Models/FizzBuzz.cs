namespace AlgorithmLab.Models
{
  public class FizzBuzz
  {
    public void Solve()
    {
      System.Console.WriteLine(CountTheNumber(100));
    }

    public string[] CountTheNumber(int number)
    {
      var result = new string[number];

      for (var i = 1; i <= number; i++)
      {
        result[i - 1] = CheckTheNumberIsDivisible(i);
      }

      return result;
    }

    public string CheckTheNumberIsDivisible(int number)
    {
      if (number % 3 == 0 && number % 5 == 0)
        return "FizzBuzz";
      else if (number % 3 == 0)
        return "Fizz";
      else if (number % 5 == 0)
        return "Buzz";
      else
        return number.ToString();
    }
  }
}