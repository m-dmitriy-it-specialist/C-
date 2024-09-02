using System;
using System.Diagnostics;
using TweetSharp;

namespace TwitterConsole
{
    class Autentification
    {
        const string consumerKey = "ZY4BFJOOziWVfhK7d8rvBx0Fu";
        const string consumerSecret = "mUKFkJcmf9hRgYxusbvBJ66nKelYd8oqZc79OVXT3BXg774Ryb";
        
        public static TwitterService Authorization()
        {
            var service = new TwitterService(consumerKey, consumerSecret);
            var requestToken = service.GetRequestToken();
            var uri = service.GetAuthorizationUri(requestToken);

            Process.Start(uri.ToString());

            Console.WriteLine("Put authorization token below");
            var verifier = Console.ReadLine();
            var access = service.GetAccessToken(requestToken, verifier);
            service.AuthenticateWith(access.Token, access.TokenSecret);

        }
    }
}
