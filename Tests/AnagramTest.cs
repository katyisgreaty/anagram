using Xunit;

namespace AnagramChecker.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void CheckAnagram_ForExactMatch_true()
    {
      Anagram testAnagram = new Anagram("team", "team");
      Assert.Equal(true, testAnagram.CheckAnagram(testAnagram));
    }

    [Fact]
    public void CheckAnagram_ForNotMatchOrAnagram_false()
    {
      Anagram testAnagram = new Anagram("team", "dolphin");
      Assert.Equal(false, testAnagram.CheckAnagram(testAnagram));
    }
  }
}
