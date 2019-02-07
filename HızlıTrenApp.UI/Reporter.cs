using HızlıTrenApp.DAL;
using HızlıTrenApp.DATA.DataSet;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıTrenApp.UI
{
    public static class Reporter
    {
        //public static void Open<T>(Form frm) where T : Form, new()
        //{
        //    T t = new T();
        //    t.ShowIcon = false;
        //    t.MdiParent = frm;
        //    t.Show();
        //}

        // Örnek Kullanım 
        //Reporter.ReportFormCreate<BiletBilgi>(deneme, "BiletBilgiID", "AlimTarihi", "BiletTipi",
        //    "KoltukNo", "BiletFiyati", "BiletTarihi", "SeferSaati", "MusteriID", "SeferSeferSaatID");

        public static void Report<T>(ReportViewer RV, params string[] properties) where T : class
        {
            Context db = new Context();
            var type = typeof(T);
            string Name = type.Name;
            var Core = db.Set<T>().ToList();

            HizliTrenDbDataSet nds = new HizliTrenDbDataSet();
            var table = nds.Tables[$"{Name}"];

            foreach (var item in Core)
            {
                object[] list = new object[properties.Length];
                int index = 0;
                foreach (string property in properties)
                {
                    if (property[0] == '[')
                    {
                        int i = property.IndexOf(']');
                        string classname = property.Substring(1, i - 1);
                        string propertyname = property.Substring(i + 1, property.Length - i - 1);
                        object classitem = type.GetProperty(classname).GetValue(item);
                        object value = classitem.GetType().GetProperty(propertyname).GetValue(classitem);
                        list[index++] = value;
                    }
                    else
                    {
                        list[index++] = type.GetProperty(property).GetValue(item);
                    }
                }
                table.Rows.Add(list);
            }

            LocalReport lp = RV.LocalReport;
            RV.ProcessingMode = ProcessingMode.Local;
            lp.ReportPath = $"..//..//..//HızlıTrenApp.DATA/Reports/{Name}.rdlc";
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = $"{Name}DataSet";
            dataSource.Value = nds.Tables[$"{Name}"];
            RV.LocalReport.DataSources.Clear();
            lp.DataSources.Add(dataSource);
            RV.RefreshReport();
        }

        public static void ReportFormCreate<T>(GroupBox grp, params string[] properties) where T : class
        {
            //MetroForm mf = new MetroForm();
            //mf.Text = $"{typeof(T).Name} Report Form";
            //mf.ShowIcon = false;
            ReportViewer rv = new ReportViewer();
            rv.Dock = DockStyle.Fill;
            grp.Controls.Add(rv);
            Reporter.Report<T>(rv, properties);
            //foreach (Control item in mf.Controls)
            //{
            //    if (item is GroupBox)
            //    {
            //        grp.Controls.Add(rv);
            //    }
            //}
            //mf.Load += ((object sender, EventArgs e) =>
            //{
            //    Reporter.Report<T>(rv, properties);
            //});
            //f.MdiParent = frm;
            //mf.Show();
        }
    }
}
