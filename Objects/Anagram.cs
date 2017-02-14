using Nancy;
using System;
using System.Collections.Generic;

namespace AnagramChecker.Objects
{
  public class Anagram
  {
    private string _word;
    // private string _checkedWord;
    private List<string> _checkedWordMatches = new List<string>{};

    public Anagram (string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string inputWord)
    {
      _word = inputWord;
    }

    // public string GetCheckedWord()
    // {
    //   return _checkedWord;
    // }
    // public void SetCheckedWord(string inputCheckedWord)
    // {
    //   _checkedWord = inputCheckedWord;
    // }
    //
    public List<string> GetAllMatches()
    {
      foreach (string thisWord in _checkedWordMatches)
      {
        return thisWord;
      }
    }

    public bool CheckAnagram(string phrase)
    {
      string word = GetWord();
      string checkedWord = phrase;
      char[] wordArray = word.ToCharArray();
      char[] checkedWordArray = checkedWord.ToCharArray();
      Array.Sort<char>(wordArray);
      Array.Sort<char>(checkedWordArray);

      if (word == phrase)
      {
        _checkedWordMatches.Add(checkedWord);
        return true;
      }
      else
      {
        for (int i = 0; i < wordArray.Length; i++)
        {
          if ( i == wordArray.Length-1 && wordArray[i] == checkedWordArray[i])
          {
            _checkedWordMatches.Add(checkedWord);
            // foreach (string thisWord in _checkedWordMatches)
            // {
            //   Console.WriteLine(thisWord);
            // }
            return true;
          }
          else if (wordArray[i] == checkedWordArray[i])
          {
            continue;
          }
          else
          {
            return false;
          }
        }
        return false;
      }
    }
  }
}
