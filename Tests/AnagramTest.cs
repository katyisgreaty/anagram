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
      Anagram testAnagram = new Anagram("team");
      List<string> expected = new List<string>{"team"};
      List<string> output = testAnagram.CheckAnagram("team");
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForNotMatchOrAnagram_notmatch()
    {
      Anagram testAnagram = new Anagram("team");
      List<string> expected = new List<string>{};
      List<string> output = testAnagram.CheckAnagram("dolphin");
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForAnagram_match()
    {
      Anagram testAnagram = new Anagram("team");
      List<string> expected = new List<string>{"mate"};
      List<string> output = testAnagram.CheckAnagram("mate");
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForNotAnagramSameFirstLetter_notmatch()
    {
      Anagram testAnagram = new Anagram("abc");
      List<string> expected = new List<string>{};
      List<string> output = testAnagram.CheckAnagram("abd");
      Assert.Equal(expected, output);
    }

    [Fact]
    public void CheckAnagram_ForMultipleWordsInPhrase_match()
    {
      Anagram testAnagram = new Anagram("team");
      List<string> expected = new List<string>{"meat", "mate"};
      List<string> output = testAnagram.CheckAnagram("meat mate");
      Assert.Equal(expected, output);
    }
  }
}
