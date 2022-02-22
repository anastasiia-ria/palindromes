namespace Palindromes.Models
{
  public class Palindrome
  {
    public string Word { get; set; }
    public string ReversedWord { get; set; }

    public Palindrome(string word)
    {
      Word = word;
      ReversedWord = "";
    }

    public void ReverseWord()
    {
    }
  }
}