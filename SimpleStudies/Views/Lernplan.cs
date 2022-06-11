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

            ThemeManager.Instance.ApplyTheme(this.Controls);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LernplanHinzufügen f = new LernplanHinzufügen();
            if (f.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(f.datum);
                item.SubItems.Add(f.zeit);
                item.SubItems.Add(f.abgabedatum);
                item.SubItems.Add(f.thema);

                listView.Items.Add(item);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
            else
            {
                MessageBox.Show("Bitte Item auswählen");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Sitepanel c = new Sitepanel();
        }
    }
}
