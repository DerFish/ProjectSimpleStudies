using SimpleStudies.Events;

namespace SimpleStudies
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            SpNav.NavEvent += C_NavEvent;
        }

        private void BtnSidepanel_Click(object sender, EventArgs e)
        {
            ScMain.Panel2Collapsed = !ScMain.Panel2Collapsed;
        }

        private void C_NavEvent(object? sender, NavigationEvent e)
        {
            UserControl control = null;
            string title = "";

            switch (e.NavToView)
            {
                case Models.Enums.NavView.Kurse:
                    control = new Views.Kurse();
                    title = "Kurse";
                    break;

                case Models.Enums.NavView.EMail:
                    control = new Views.E_Mail_Adressen();
                    title = "EMails";
                    break;

                case Models.Enums.NavView.Hausaufgabe:
                    control = new Views.Hausaufgaben();
                    title = "Hausaufgaben";
                    break;

                case Models.Enums.NavView.Lernplan:
                    control = new Views.Lernplan();
                    title = "Lernplan";
                    break;

                case Models.Enums.NavView.Newsfeed:
                    control = new Views.NewsFeed();
                    title = "Newsfeed";
                    break;

                case Models.Enums.NavView.Notenuebersicht:
                    control = new Views.Notenübersicht();
                    title = "Notenübersicht";
                    break;

                case Models.Enums.NavView.Stundenplan:
                    control = new Views.Stundenplan();
                    title = "Stundenplan";
                    break;

                case Models.Enums.NavView.Verwaltung:
                    control = new Views.Kurse();
                    title = "Verwaltung";
                    break;

                default:
                    break;
            }

            if (control == null)
            {
                return;
            }

            ScMain.Panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ScMain.Panel1.Controls.Add(control);
            ScMain.Panel2Collapsed = true;

            LbLTitle.Text = title;
        }
    }
}