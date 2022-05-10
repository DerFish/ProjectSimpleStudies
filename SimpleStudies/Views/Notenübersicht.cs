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
    public partial class Notenübersicht : Form
    {
        public Notenübersicht()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
            panel2.Controls.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
