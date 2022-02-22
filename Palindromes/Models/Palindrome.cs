using System;
namespace Palindromes.Models
{
  public class Palindrome
  {
    public string Word { get; set; }
    public Palindrome(string word)
    {
      Word = word;
    }

    public bool IsPalindrome()
    {
      char[] wordArray = Word.ToCharArray();
      bool isPalindrome = true;

      for (int i = 0; i < wordArray.Length / 2; i++)
      {
        if (wordArray[i] != wordArray[wordArray.Length - i - 1])
        {
          isPalindrome = false;
          break;
        }
      }

      return isPalindrome;
    }
  }
}