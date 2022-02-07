namespace AlgorithmLab.Models
{
  /*
    Write a short program that prints each number from 1 to 100 on a new line. 

    For each multiple of 3, print "Fizz" instead of the number. 

    For each multiple of 5, print "Buzz" instead of the number. 

    For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
  */
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