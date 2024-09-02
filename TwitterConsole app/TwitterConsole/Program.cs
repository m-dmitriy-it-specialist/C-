using System;

namespace TwitterConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////#region design: изменение цвета приложения по типу стиля Twitter

            ////////////////////////////FontBackgroundColor backcolor = new FontBackgroundColor();
            ////////////////////////////{
            ////////////////////////////    Console.ForegroundColor = backcolor.ForegroungColor;
            ////////////////////////////    Console.BackgroundColor = backcolor.BackgroungColor;
            ////////////////////////////    Console.Clear();
            ////////////////////////////}
            ////////////////////////////#endregion

            ////////////////////////////#region geolocation: определение IP адреса и города

            ////////////////////////////GeoPositionCurent located = new GeoPositionCurent();
            ////////////////////////////{

            ////////////////////////////    Console.WriteLine($"Ваш город: {located.GetLocationByPublicIP("1")}.\nВаш IP адрес: {located.GetLocationByPublicIP("0")}.");
            ////////////////////////////}

            ////////////////////////////#endregion

            ////////////////////////////#region weatherToday: погода сегодня

            ////////////////////////////WeatherToday weathertoday = new WeatherToday();
            ////////////////////////////{
            ////////////////////////////    Console.WriteLine(weathertoday.GetCurrentWeatherByLocation());
            ////////////////////////////}
            ////////////////////////////#endregion

            ////////////////////////////#region greating: приветствие пользователя от системы при входе

            ////////////////////////////SystemGreatings.GreatingsClientDo();

            ////////////////////////////#endregion


            #region Autentification: авторизация к аккаунту по ключам и токенам

            //var service = new TwitterService(consumerKey, consumerSecret);

            //var requestToken = service.GetRequestToken();

            //var uri = service.GetAuthorizationUri(requestToken);
            //Process.Start(uri.ToString());

            //var verifier = Console.ReadLine();
            //var access = service.GetAccessToken(requestToken, verifier);

            //service.AuthenticateWith(access.Token, access.TokenSecret);
            #endregion

            #region tweets
            //var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions()).ToList();

            //for (int i = 0; i < 5; i++)
            //{
            //    TimeSpan longPeriod = DateTime.Now.Subtract(tweets[i].CreatedDate);
            //    var hastagpattern = "\\s(#)\\w*\\s+";
            //    var hastagsuccess = Regex.Match(tweets[i].Text, hastagpattern, RegexOptions.IgnoreCase);

            //    Console.WriteLine
            //        (
            //        $"\n{StringHelper.Cut(tweets[i].Text).ToString()}\n" +
            //        $"This tweet was published: {longPeriod.Days}days = {longPeriod.Hours}hours = {longPeriod.Minutes}minutes\nlong ago"
            //        );

            //    if (hastagsuccess.Success)
            //    {
            //        Console.WriteLine($"Hashtag for this tweet would be {hastagsuccess.Value}\n\n\n");
            //    }
            //}
            var tweets = new Tweets();
            tweets.Printedtweets();
            #endregion

            #region trends
            //var trends = service.ListLocalTrendsFor(new ListLocalTrendsForOptions() { Id = 1 }); // 1 - весь мир

            //StringBuilder sbuilder = new StringBuilder();
            //string ds = ", ";

            //foreach (var trend in trends)
            //{
            //    if (trend.Name.Contains("#")) sbuilder.Append(trend.Name + ds);
            //}

            //Console.WriteLine(sbuilder.ToString());
            
            #endregion

            Console.ReadKey();

        }
    }
}













