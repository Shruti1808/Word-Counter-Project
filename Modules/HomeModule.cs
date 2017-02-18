using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;


namespace WordCounter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            //Routing to the HomePage
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

              //Routing to the Result Page
              
            Post["/result"] = _ => {
                RepeatCounter newRepeatCounter = new RepeatCounter();
                string result = newRepeatCounter.CountRepeats(Request.Form["inputWord"],Request.Form["inputSentence"]);
                string[] countResultData = {Request.Form["inputSentence"],Request.Form["inputWord"],result};
                return View ["results.cshtml", countResultData];
            };
        }
    }
}
