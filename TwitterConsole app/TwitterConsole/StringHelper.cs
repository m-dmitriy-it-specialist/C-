namespace TwitterConsole
{
    public static class StringHelper
    {
        const int lengthOfTweet = 10;
        public static string Cut(string args)
        {

            if (args.Length > lengthOfTweet)
            {
                args = args.Substring(0, lengthOfTweet);
            }
            return args;

        }

    }
}

