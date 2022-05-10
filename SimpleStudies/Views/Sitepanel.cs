using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStudies.Views
{
    public partial class Sitepanel : UserControl
    {
        public Sitepanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stundenplan stundenplan = new Stundenplan();
            stundenplan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Notenübersicht notenübersicht = new Notenübersicht();
            notenübersicht.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hausaufgaben hausaufgaben = new Hausaufgaben();
            hausaufgaben.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lernplan lernplan = new Lernplan();
            lernplan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            E_Mail_Adressen e_Mail_Adressen = new E_Mail_Adressen();
            e_Mail_Adressen.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewsFeed newsFeed = new NewsFeed();
            newsFeed.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Verwaltung verwaltung = new Verwaltung();
            verwaltung.Show();
        }
    }
}
