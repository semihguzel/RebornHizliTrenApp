using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public static class Metodlar
    {
        public static void Temizle(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        public static bool Sorgula(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Trim() == string.Empty) return false;
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Year == DateTime.Now.Year) return false;
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1) return false;
                }
            }
            return true;
        }
    }
}
