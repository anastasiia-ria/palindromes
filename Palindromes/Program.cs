using System;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      string word = "read";
      Palindrome testPalindrome = new Palindrome(word);
      testPalindrome.IsPalindrome();
    }
  }
}