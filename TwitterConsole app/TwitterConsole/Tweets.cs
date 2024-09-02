using System;
using System.Linq;
using System.Text.RegularExpressions;
using TweetSharp;


namespace TwitterConsole
{
    class Tweets : Autentification
    {
        string printedTweets;
        string printedHastag;
        
        public void Printedtweets()
        {
            var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();

            for (int i = 0; i < 5; i++)
            {
               TimeSpan longPeriod = DateTime.Now.Subtract(tweets[i].CreatedDate);
               
               printedTweets = /*Console.WriteLine*/
                    (
                    $"\n{StringHelper.Cut(tweets[i].Text)}\n"
                    +
                    $"This tweet was published: {longPeriod.Days}days = {longPeriod.Hours}hours = {longPeriod.Minutes}minutes\nlong ago".ToString()
                    ).ToString();

                var hastagpattern = "\\s(#)\\w*\\s+";
                var hastagsuccess = Regex.Match(tweets[i].Text, hastagpattern, RegexOptions.IgnoreCase);
                if (hastagsuccess.Success)
                {
                    /*Console.WriteLine*/printedHastag = ($"Hashtag for this tweet would be {hastagsuccess.Value}\n\n\n").ToString();
                }
            }
            string printedTwHstg = ($"{printedTweets}\n{printedHastag}");
            
        }
    }
}
