using Xunit;
using System;
using System.Collections.Generic;

namespace AnagramChecker.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void CheckAnagram_ForExactMatch_match()
    {
      Anagram testAnagram = new Anagram("team", "team");
      List<string> expected = new List<string>{"team"};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForNotMatchOrAnagram_notmatch()
    {
      Anagram testAnagram = new Anagram("team", "dolphin");
      List<string> expected = new List<string>{};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForAnagram_match()
    {
      Anagram testAnagram = new Anagram("team", "mate");
      List<string> expected = new List<string>{"mate"};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForNotAnagramSameFirstLetter_notmatch()
    {
      Anagram testAnagram = new Anagram("abc", "abd");
      List<string> expected = new List<string>{};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForMultipleWordsInPhrase_match()
    {
      Anagram testAnagram = new Anagram("team", "meat mate");
      List<string> expected = new List<string>{"meat", "mate"};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForMultipleWordsInPhrase_notmatch()
    {
      Anagram testAnagram = new Anagram("team", "meat mate dolphin");
      List<string> expected = new List<string>{"meat", "mate"};
      List<string> output = testAnagram.CheckAnagram();
      Assert.Equal(expected, output);
    }
  }
}
