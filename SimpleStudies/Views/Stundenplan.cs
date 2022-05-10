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
    public partial class Stundenplan : Form
    {
        public Stundenplan()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
            panel3.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
