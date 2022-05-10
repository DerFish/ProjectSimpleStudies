namespace SimpleStudies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Views.Sitepanel c = new Views.Sitepanel();
            panel2.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}