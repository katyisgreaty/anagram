using Nancy;
using System;
using System.Collections.Generic;

namespace AnagramChecker.Objects
{
  public class Anagram
  {
    private string _word;
    private string _checkedWord;

    public Anagram (string word, string checkedWord)
    {
      _word = word;
      _checkedWord = checkedWord;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string inputWord)
    {
      _word = inputWord;
    }

    public string GetCheckedWord()
    {
      return _checkedWord;
    }
    public void SetCheckedWord(string inputCheckedWord)
    {
      _checkedWord = inputCheckedWord;
    }

    public bool CheckAnagram(Anagram anagram)
    {
      string word = anagram.GetWord();
      string checkedWord = anagram.GetCheckedWord();

      if (word == checkedWord)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
