using System;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word, phrase, or number:");
      string userWord = Console.ReadLine();

      Palindrome userPalindrome = new Palindrome(userWord);
      if (userPalindrome.IsPalindrome() == true)
      {
        Console.WriteLine("Congratulations!! You have a palindrome");
      }
      else
      {
        Console.WriteLine("Try again. This is not a palindrome");
      }
      Console.WriteLine("Press 1 to try again or enter anything else to exit");
      string again = Console.ReadLine();
      if (again == "1")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Okay, bye");
      }
    }
  }
}