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
    public partial class Verwaltung : UserControl
    {
        public Verwaltung()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
        }
    }
}
