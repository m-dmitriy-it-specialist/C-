using System.IO;
using System.Net;



namespace TwitterConsole
{
    class GeoPositionCurent
    {
        string direction = "";
        string res = "";
        internal string GetLocationByPublicIP(string arg)
        {
            #region external ip detection

            WebRequest request0 = WebRequest.Create("http://checkip.dyndns.org/");
            WebResponse response0 = request0.GetResponse();

            StreamReader stream0 = new StreamReader(response0.GetResponseStream());
            {
                direction = stream0.ReadToEnd();
            }
            int first0 = direction.IndexOf("Address:") + 9;
            int last0 = direction.IndexOf("</body>");
            direction = direction.Substring(first0, last0 - first0);

            #endregion

            #region external ip location resolving

            WebRequest request1 = WebRequest.Create("http://ipinfo.io/" + direction);
            WebResponse response1 = request1.GetResponse();
            StreamReader stream1 = new StreamReader(response1.GetResponseStream());
            {

                string line;

                while ((line = stream1.ReadLine()) != null)
                {
                    res += line;
                }

            }
            int first1 = res.IndexOf("city") + 8;
            int last1 = res.IndexOf("region") - 5;
            res = res.Substring(first1, last1 - first1);
            string[] array = new string[2] { direction, res };

            switch (arg)
            {
                case "0": return array[0];
                case "1": return array[1];
            }
            return arg;
            #endregion
        }

    }
}
