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
    public partial class LernplanHinzufügen : Form
    {
        ListView listView1;
        Lernplan lernplan;

        public LernplanHinzufügen()
        {
            InitializeComponent();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDatum.Text) || string.IsNullOrEmpty(textZeit.Text))
                return;


            ListViewItem item = new ListViewItem(textDatum.Text);
            item.SubItems.Add(textZeit.Text);

            lernplan.textDatum = textDatum;
            lernplan.textZeit = textZeit;
            lernplan.listView1.Items.Add(item);

            

            textDatum.Clear();
            textZeit.Clear();
            textDatum.Focus();


            
        }
    }
}
