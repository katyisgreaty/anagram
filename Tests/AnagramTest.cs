using Xunit;

namespace AnagramChecker.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void CheckAnagram_ForExactMatch_true()
    {
      Anagram testAnagram = new Anagram("team");
      Assert.Equal(true, testAnagram.CheckAnagram("team"));
    }

    [Fact]
    public void CheckAnagram_ForNotMatchOrAnagram_false()
    {
      Anagram testAnagram = new Anagram("team");
      Assert.Equal(false, testAnagram.CheckAnagram("dolphin"));
    }

    [Fact]
    public void CheckAnagram_ForAnagram_true()
    {
      Anagram testAnagram = new Anagram("team");
      Assert.Equal(true, testAnagram.CheckAnagram("mate"));
    }

    [Fact]
    public void CheckAnagram_ForNotAnagramSameFirstLetter_false()
    {
      Anagram testAnagram = new Anagram("abc");
      Assert.Equal(false, testAnagram.CheckAnagram("abd"));
    }

    [Fact]
    public void CheckAnagram_ForMultipleWordsInPhrase_true()
    {
      Anagram testAnagram = new Anagram("team");
      List<string> expected = new List<string>{"meat", "mate"};
      List<string> output = testAnagram.CheckAnagram("meat mate");
      Assert.Equal(expected, output);
    }
  }
}
