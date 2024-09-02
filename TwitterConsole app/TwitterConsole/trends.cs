using System.Text;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using TweetSharp;

namespace TwitterConsole
{
    class Trends : Autentification
    {
        public string Printedtrends()
        {
            var service = Authorization();
            var trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир

            StringBuilder sbuilder = new StringBuilder();
            string ds = ", ";

            foreach (var trend in trends)
            {
                if (trend.Name.Contains("#")) sbuilder.Append(trend.Name + ds);
            }

            return sbuilder.ToString();
        }
    }
}
