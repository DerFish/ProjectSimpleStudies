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
    public partial class Lernplan : UserControl
    {
        internal TextBox textDatum;
        internal TextBox textZeit;

        public Lernplan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LernplanHinzufügen f = new LernplanHinzufügen();
            f.Show();


          
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
