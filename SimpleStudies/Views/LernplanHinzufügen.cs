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
        public string datum
        {
            get { return textDatum.Text; }
        }

        public string zeit
        {
            get { return textZeit.Text; }
        }

        public string abgabedatum
        {
            get { return textAbgabedatum.Text; }
        }

        public string thema
        {
            get { return textThema.Text; }
        }


        public LernplanHinzufügen()
        {
            InitializeComponent();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {  
            DialogResult = DialogResult.OK;
        }
    }
}
