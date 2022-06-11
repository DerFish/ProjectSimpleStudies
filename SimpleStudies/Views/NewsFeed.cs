using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SimpleStudies.Controls;
using SimpleStudies.Models;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace SimpleStudies.Views
{
    public partial class NewsFeed : UserControl, IView
    {
        private const string Domain = "https://www.mosbach.dhbw.de";

        public NewsFeed()
        {
            InitializeComponent();

            ThemeManager.Instance.ApplyTheme(this.Controls);
        }

        public int Semester { get; set; }

        public void ResetView()
        {
            var news = Task.Run(() => LoadNewsAsync()).GetAwaiter().GetResult();
            foreach (var item in news)
            {
                var crtl = new NewsItemControl(item);
                crtl.MouseClick += Crtl_Click;
                FlpMain.Controls.Add(crtl);
            }
        }

        private void Crtl_Click(object? sender, EventArgs e)
        {
            NewsItemControl clickedButton = (NewsItemControl)sender;
            System.Diagnostics.Process.Start(clickedButton.Link);
        }

        private async Task<List<NewsItem>> LoadNewsAsync()
        {
            var news = new List<NewsItem>();

            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = await client.GetStringAsync(Domain + "/dhbw-mosbach/news-presse/");

            return ParseHtml(response);
        }

        private List<NewsItem> ParseHtml(string html)
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);
            var newsItems = htmlDoc.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "") == "news-teaser-item").ToList();

            List<NewsItem> news = new List<NewsItem>();

            foreach (var item in newsItems)
            {
                var n = new NewsItem();
                n.Link = Domain + item.Element("a").Attributes["href"].Value;
                n.Headline = item.Descendants("div").Where(w => w.GetAttributeValue("class", "").Contains("news-teaser-item-content")).FirstOrDefault().Element("h3").InnerText;
                n.PicturePath = Domain + item.Descendants("div").Where(w => w.GetAttributeValue("class", "") == "img-outer").FirstOrDefault().Element("img").GetAttributeValue("src", "");
                n.Text = item.Descendants("div").Where(w => w.GetAttributeValue("class", "").Contains("news-teaser-item-content")).FirstOrDefault().Element("p").GetDirectInnerText();
                n.Text = n.Text.Replace(@"\n", "").Trim();
                news.Add(n);
            }

            return news;
        }
    }
}
