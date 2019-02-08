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
            ReportViewer rv = new ReportViewer();
            rv.Dock = DockStyle.Fill;
            grp.Controls.Add(rv);
            Reporter.Report<T>(rv, properties);
        }
    }
}
