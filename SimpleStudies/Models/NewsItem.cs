using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Models
{
    public class NewsItem
    {
        public NewsItem()
        {
        }

        public NewsItem(string headline, string text, string picturePath, string link)
        {
            Headline = headline;
            Text = text;
            PicturePath = picturePath;
            Link = link;
        }

        public string Headline { get; set; }
        public string Link { get; set; }
        public string PicturePath { get; set; }
        public string Text { get; set; }
    }
}
