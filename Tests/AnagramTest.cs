using Xunit;

namespace AnagramChecker.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void CheckAnagram_ForAnagramOfWord_true()
    {
      Anagram testAnagram = new Anagram("team", "team");
      Assert.Equal(true, testAnagram.CheckAnagram(testAnagram));
    }
  }
}
