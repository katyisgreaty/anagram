using Nancy;
using AnagramChecker.Objects;
using System.Collections.Generic;

namespace AnagramChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        var newAnagram = new Anagram(Request.Form["initial-word"], Request.Form["phrase"]);
        return View["results.cshtml", newAnagram];
      };
    }
  }
}
