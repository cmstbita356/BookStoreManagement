using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_BookstoreManagement.BLL;
using Project_BookstoreManagement.DTO;
using Microsoft.Reporting.WinForms;

namespace Project_BookstoreManagement.PL
{
    public partial class RevenueReportUC : UserControl
    {
        public RevenueReportUC()
        {
            InitializeComponent();
            this.rpt_viewer.RefreshReport();
        }

        private void rpt_viewer_Load(object sender, EventArgs e)
        {
            rpt_viewer.LocalReport.DataSources.Clear();
            List <ReceiptDTO> list = ReceiptBLL.EF_GetAll();
            rpt_viewer.LocalReport.DataSources.Add(new ReportDataSource("ReceiptList", list));
            rpt_viewer.RefreshReport();
        }

        //private void BtSub_Click(object sender, EventArgs e)
        //{
        //    rpt_viewer.LocalReport.ReportEmbeddedResource = "Project_BookstoreManagement.Reports.RVSub.rdlc";
        //    rpt_viewer.LocalReport.DataSources.Clear();
        //    ReportDataSource source = new ReportDataSource("DSLoaiSP", BookTypeBLL.getProductType());
        //    rpt_viewer.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        //    rpt_viewer.LocalReport.DataSources.Add(source);

        //    this.rpt_viewer.RefreshReport();
        //}

        //private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        //{
        //    string maloai = e.Parameters["paMaLoai"].Values[0];
        //    ReportDataSource source = new ReportDataSource("DSSanPham", BookBLL.getProductByType(maloai));
        //    e.DataSources.Add(source);
        //}

        //private void BtLoaiSP_Click(object sender, EventArgs e)
        //{
        //    rpt_viewer.LocalReport.ReportEmbeddedResource = "Project_BookstoreManagement.Reports.RVSanPham2.rdlc";
        //    rpt_viewer.LocalReport.DataSources.Clear();
        //    ReportDataSource source = new ReportDataSource("DSSanPham", BookBLL.getProductByType(cbbLoaiSP.SelectedValue.ToString()));
        //    rpt_viewer.LocalReport.DataSources.Add(source);
        //    this.rpt_viewer.RefreshReport();
        //}

        //private void BtXem_Click(object sender, EventArgs e)
        //{
        //    rpt_viewer.LocalReport.ReportEmbeddedResource = "Project_BookstoreManagement.Reports.RVSanPham2.rdlc";
        //    rpt_viewer.LocalReport.DataSources.Clear();
        //    ReportDataSource source = new ReportDataSource("DSSanPham", BookBLL.getProduct());
        //    rpt_viewer.LocalReport.DataSources.Add(source);
        //    this.rpt_viewer.RefreshReport();
        //}

        //private void BCSanPham_Load(object sender, EventArgs e)
        //{

        //    this.rpt_viewer.RefreshReport();
        //    this.rpt_viewer.RefreshReport();
        //}
    }
}
