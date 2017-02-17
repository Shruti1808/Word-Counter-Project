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
                RepeatCounter newRepeatCounter = new RepeatCounter();
                string result = newRepeatCounter.CountRepeats(Request.Form["inputWord"],Request.Form["inputSentence"]);
                string[] countResultData = {Request.Form["inputWord"],Request.Form["inputSentence"],result};
                return View ["results.cshtml", countResultData];
            };
        }
    }
}
