using Microsoft.Reporting.WinForms;
using Project_BookstoreManagement.BLL;
using Project_BookstoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BookstoreManagement.PL
{
    public partial class StockReportUC : UserControl
    {
        public StockReportUC()
        {
            InitializeComponent();
        }

        private void rpt_viewer_Load(object sender, EventArgs e)
        {
            rpt_viewer.LocalReport.DataSources.Clear();
            List<StockDTO> list = StockBLL.GetStock();
            rpt_viewer.LocalReport.DataSources.Add(new ReportDataSource("StockList", list));
            rpt_viewer.RefreshReport();
        }
    }
}
