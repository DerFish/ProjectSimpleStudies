using SimpleStudies.Events;

namespace SimpleStudies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
                panel2.Visible = true;
        }

        private void C_NavEvent(object? sender, NavigationEvent e)
        {
            UserControl control = null;

            switch (e.NavToView)
            {
                case Models.Enums.NavView.Kurse:
                    control = new Views.Kurse();
                    break;

                case Models.Enums.NavView.EMail:
                    control = new Views.E_Mail_Adressen();
                    break;

                case Models.Enums.NavView.Hausaufgabe:
                    control = new Views.Hausaufgaben();
                    break;

                case Models.Enums.NavView.Lernplan:
                    control = new Views.Lernplan();
                    break;

                case Models.Enums.NavView.Newsfeed:
                    control = new Views.NewsFeed();
                    break;

                case Models.Enums.NavView.Notenuebersicht:
                    control = new Views.Notenübersicht();
                    break;

                case Models.Enums.NavView.Stundenplan:
                    control = new Views.Stundenplan();
                    break;

                case Models.Enums.NavView.Verwaltung:
                    control = new Views.Verwaltung();
                    break;

                default:
                    break;
            }

            if (control == null)
            {
                return;
            }

            PMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PMain.Controls.Add(control);
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Views.Sitepanel c = new Views.Sitepanel();
            c.NavEvent += C_NavEvent;
            panel2.Controls.Add(c);
        }
    }
}