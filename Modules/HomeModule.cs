using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;


namespace WordCounter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/result"] = _ => {
                RepeatCounter testRepeatCounter = new RepeatCounter();
                string result = repeatCounter.CountRepeats(Request.Form["inputWord"],Request.Form["inputSentence"]);
                string[] countResultData = {};
                return View ["results.cshtml", countResultData];
            };
        }
    }
}
