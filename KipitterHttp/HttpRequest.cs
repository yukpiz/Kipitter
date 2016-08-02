using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using KipitterCore.Constant;
using System.IO;

namespace KipitterCore
{
    public class HttpRequest
    {
        public void Get()
        {
            HttpWebRequest req = (HttpWebRequest)
                WebRequest.Create(Http.TRADEBOARD_URL);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)
                req.GetResponse();

            Console.WriteLine(res.Headers);
            if (res.StatusCode != HttpStatusCode.OK)
            {
                //ログ出力
                Console.WriteLine("Error HTTP Request.");
            }

            Stream stream = res.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string body = reader.ReadToEnd();

            HtmlParser parser = new HtmlParser();
            parser.Parse(body);
        }
    }
}
