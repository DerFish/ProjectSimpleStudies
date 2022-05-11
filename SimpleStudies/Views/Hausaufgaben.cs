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
    public partial class Hausaufgaben : Form
    {
        public Hausaufgaben()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = (Sitepanel)sender;
            panel3.Controls.Add(c);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
            panel3.Controls.Add(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            else
                panel3.Visible = true;
        }
    }
}
