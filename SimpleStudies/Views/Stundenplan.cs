using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace SimpleStudies.Views
{
    public partial class Stundenplan : Form
    {
        public Stundenplan()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task Initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitializeBrowser()
        {
            Uri uri = new Uri("https://rapla.dhbw.de/rapla/calendar?key=25q8zGuMAw3elezlMsiegXs3Z-sCY45qHbigy7wiQ2e27FEEw1gUZrt95IawaK3jxZy_Y5bukYcuFWfh6SXaWScIBj1vU-rKPi1EJOM9QFX4p3tKwLad0qDpHO7Zn5W-IUQ1RhEYxI8ckde9URa_ng&salt=-2070726140");
            await Initizated();
            webView21.CoreWebView2.Navigate(uri.ToString());
        }
        private void webView21_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            this.Text = e.Uri.ToString() + "Is loading . . .";
        }


    }
}

