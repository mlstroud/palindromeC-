using System;

public class Palindrome
{
  public static void Main()
  {
    Console.WriteLine("Enter your word/s to see if it's a palindrome:");
    string input = Console.ReadLine();

    Console.WriteLine(checkPalindrome(input));
  }

  public static bool checkPalindrome(string input)
  {
    if (int.TryParse(input, out int num))
    {
      //int num = int.Parse(input);
      int remainder = 0;
      int reversedNum = 0;

      while (num > 0)
      {
        remainder = num % 10;
        reversedNum = (reversedNum * 10) + remainder;
        num /= 10;
      }

      if (reversedNum == int.Parse(input))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    else
    {
      int i = 0;
      int j = input.Length - 1;

      while (i < j)
      {
        if (input[i] != input[j])
        {
          return false;
        }
        i++;
        j--;
      }

      return true;
    }
  }
}