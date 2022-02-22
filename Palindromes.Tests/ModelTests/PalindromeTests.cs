using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void Palindrome_MakeAPalindrome_Word()
    {
      string word = "radar";
      Palindrome testPalindrome = new Palindrome(word);
      Assert.AreEqual("radar", testPalindrome.Word);
    }

    [TestMethod]
    public void Reverse_ReverseAWord_ReversedWord()
    {
      string word = "radar";
      Palindrome testPalindrome = new Palindrome(word);
      testPalindrome.ReverseWord();
      Assert.AreEqual("radar", testPalindrome.ReversedWord);
    }
  }
}