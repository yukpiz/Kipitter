using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Data;
using System.Text.RegularExpressions;

namespace KipitterCore
{
    public class HtmlParser
    {
        private string Url2Id(string url)
        {
            //Get id from parsed URL.
            Regex reg = new Regex(@"ix=(?<id>\d*)");
            Match match = reg.Match(url);
            return match.Success ? match.Groups["id"].Value : string.Empty;
        }

        private DataTable Article2DataTable(IEnumerable<Article> articles)
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", Type.GetType("string"));
            table.Columns.Add("title", Type.GetType("string"));
            table.Columns.Add("url", Type.GetType("string"));
            table.Columns.Add("name", Type.GetType("string"));
            table.Columns.Add("time", Type.GetType("string"));

            foreach (var article in articles)
            {
                DataRow row = table.NewRow();
                row["id"] = article.Id;
                row["title"] = article.Title;
                row["url"] = article.Url;
                row["name"] = article.Name;
                row["time"] = article.Time;
                table.Rows.Add(row);
            }
            return table;
        }

        private struct Article
        {
            public string Id;
            public string Title;
            public string Url;
            public string Name;
            public string Time;
            public Article(string id, string title, string url, string name, string time)
            {
                Id = id;
                Title = title;
                Url = url;
                Name = name;
                Time = time;
            }
        }
        
        public DataTable Parse(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            var articles = doc.DocumentNode
                .SelectNodes(@"//div[@id=""trade-list""]/table/tr[not(@class)]")
                .Select(tr =>
                {
                    var url = tr.SelectNodes(@"td[contains(./@class, ""list-title"")]/p/a").First().Attributes["href"].Value.Trim();

                    return new Article(
                        id: Url2Id(url),
                        title: tr.SelectNodes(@"td[contains(./@class, ""list-title"")]/p/a").First().InnerText,
                        url: url,
                        name: tr.SelectNodes(@"td[contains(./@class, ""list-name"")]/a").First().InnerText,
                        time: tr.SelectNodes(@"td[contains(./@class, ""list-date"")]").First().InnerText
                    );
                });

            return Article2DataTable(articles);
        }
    }
}
