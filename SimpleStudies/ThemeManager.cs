using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies
{
    public class ThemeManager
    {
        private static ThemeManager instance;

        private ThemeManager()
        {
            PrimaryColor = Color.FromArgb(54, 34, 34);
            MainColor = Color.FromArgb(23, 16, 16);
            SecondaryColor = Color.FromArgb(66, 63, 62);
            TertiaryColor = Color.FromArgb(43, 43, 43);
            FontColor = Color.FromArgb(238, 238, 238);
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static ThemeManager Instance => instance ?? (instance = new ThemeManager());

        public Color FontColor { get; set; }
        public Color MainColor { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color TertiaryColor { get; set; }

        public void ApplyTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                component.BackColor = MainColor;
                component.ForeColor = FontColor;

                if (component is Panel)
                {
                    ApplyTheme(component.Controls);
                }
                else if (component is Button btn)
                {
                    btn.FlatAppearance.BorderColor = SecondaryColor;
                    btn.BackColor = SecondaryColor;
                }
                else if (component is TextBox)
                {
                    component.BackColor = PrimaryColor;
                    component.ForeColor = FontColor;
                }
                else if (component is ComboBox)
                {
                    component.BackColor = PrimaryColor;
                    component.ForeColor = FontColor;
                }
                else if (component is ListView lv)
                {
                    lv.BackColor = SecondaryColor;
                }
            }
        }
    }
}
