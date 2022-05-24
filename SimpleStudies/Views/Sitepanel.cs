using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleStudies.Events;
using SimpleStudies.Models.Enums;

namespace SimpleStudies.Views
{
    public partial class Sitepanel : UserControl
    {
        public Sitepanel()
        {
            InitializeComponent();
        }

        public delegate void OnNavEvent(object sender, NavigationEvent e);

        public event OnNavEvent NavEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Stundenplan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Hausaufgabe);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Lernplan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Navigate(NavView.EMail);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Notenuebersicht);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Newsfeed);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Navigate(NavView.Verwaltung);
        }

        private void Navigate(NavView view)
        {
            if (NavEvent != null)
            {
                NavEvent.Invoke(this, new NavigationEvent(view));
            }
        }
    }
}
