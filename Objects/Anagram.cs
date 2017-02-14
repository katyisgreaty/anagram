using Nancy;
using System;
using System.Collections.Generic;

namespace AnagramChecker.Objects
{
  public class Anagram
  {
    private string _word;
    private string _phrase;
    // private string _checkedWord;
    private List<string> _checkedWordMatches = new List<string>{};

    public Anagram (string word, string phrase)
    {
      _word = word;
      _phrase = phrase;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string inputWord)
    {
      _word = inputWord;
    }

    public string GetPhrase()
    {
      return _phrase;
    }
    public void SetPhrase(string inputPhrase)
    {
      _phrase = inputPhrase;
    }

    public List<string> CheckAnagram()
    {
      string phrase = GetPhrase();
      string[] phraseList = phrase.Split(' ');
      string word = GetWord();
      char[] wordArray = word.ToCharArray();
      Array.Sort<char>(wordArray);

      for (int j = 0; j < phraseList.Length; j ++)
      {
        string checkedWord = phraseList[j];
        char[] checkedWordArray = checkedWord.ToCharArray();
        Array.Sort<char>(checkedWordArray);

        //If words don't match exactly
        for (int i = 0; i < wordArray.Length; i++)
        {
          //then check the last letter
          if ( i == wordArray.Length-1 && wordArray[i] == checkedWordArray[i])
          {
            _checkedWordMatches.Add(checkedWord);
            continue;
          }
          //then check all the letters
          else if (wordArray[i] == checkedWordArray[i])
          {
            continue;
          }
          //bail
          else
          {
            break;
          }
        }
      }
      return _checkedWordMatches;
    }
  }
}
