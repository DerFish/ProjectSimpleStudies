using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleStudies.Models;

namespace SimpleStudies.Controls
{
    public partial class NewsItemControl : UserControl
    {
        public NewsItemControl()
        {
            InitializeComponent();
        }

        public NewsItemControl(NewsItem item) : this(item.PicturePath, item.Headline, item.Text, item.Link)
        {
        }

        public NewsItemControl(string picturePath, string headline, string text, string link) : this()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            PbMain.ImageLocation = picturePath;
            LblTitle.Text = headline;
            LblAbstract.Text = text;
            this.Link = link;
        }

        public string Link { get; set; }

        private void LblTitle_Click(object sender, EventArgs e)
        {
            OpenLink();
        }

        private void OpenLink()
        {
            var myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = Link;
            myProcess.Start();
        }

        private void PbMain_Click(object sender, EventArgs e)
        {
            OpenLink();
        }
    }
}
