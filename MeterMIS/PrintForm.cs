using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MeterMIS
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {                      
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            ReportPageSettings p =  reportViewer1.LocalReport.GetDefaultPageSettings();
            Text += "-纸张" + p.PaperSize.PaperName + "大小(" + p.PaperSize.Width * 254 /1000 + "*" + p.PaperSize.Height * 254 /1000 + "mm)";
        }

        private void PrintForm_Resize(object sender, EventArgs e)
        {
            reportViewer1.Height = Height - 40;
            reportViewer1.Width = Width - 20;
        }
    }
}
