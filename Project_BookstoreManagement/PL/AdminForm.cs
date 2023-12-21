using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Web.HtmlReportRender;
using Microsoft.Reporting.WinForms;
using Project_BookstoreManagement.DTO;


namespace Project_BookstoreManagement.PL
{
    public partial class AdminForm : Form
    {
        private EmployeeDTO currentuser;

        public AdminForm(EmployeeDTO user)
        {
            InitializeComponent();
            currentuser = user;
            Customizer();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // --------------------- Functions -------------------

        private void Customizer()
        {
            panel_nhaphangcontainer.Visible = false;
            panel_ReportContainer.Visible = false;
            //lbl_adminName.Text = currentuser.TenNV;
        }

        private void HideSubMenu()
        {
            if (panel_nhaphangcontainer.Visible) panel_nhaphangcontainer.Visible = false;
            if (panel_ReportContainer.Visible) panel_ReportContainer.Visible = false;
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void RemoveAllUC()
        {
            foreach (Control ctrl in panel_view.Controls)
            {
                panel_view.Controls.Remove(ctrl);
            }
        }

        // --------------------- Tab buttons ----------------------
        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Quản lý sách";
            BookUC newSP = new BookUC();
            newSP.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newSP);
            HideSubMenu();
        }

        private void btn_SanPham_MouseHover(object sender, EventArgs e)
        {
            btn_SanPham.ForeColor = Color.Cyan;
        }

        private void btn_SanPham_MouseLeave(object sender, EventArgs e)
        {
            btn_SanPham.ForeColor = Color.Black;
        }



        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Quản lý khách hàng thân thiết";
            CustomerUC newSP = new CustomerUC();
            newSP.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newSP);
            HideSubMenu();
        }

        private void btn_khachhang_MouseHover(object sender, EventArgs e)
        {
            btn_khachhang.ForeColor = Color.Green;

        }

        private void btn_khachhang_MouseLeave(object sender, EventArgs e)
        {
            btn_khachhang.ForeColor = Color.Black;
        }




        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Quản lý nhân viên";
            EmployeeUC newNV = new EmployeeUC();
            newNV.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newNV);
            HideSubMenu();
        }

        private void btn_NhanVien_MouseHover(object sender, EventArgs e)
        {
            btn_NhanVien.ForeColor = Color.Red;
        }

        private void btn_NhanVien_MouseLeave(object sender, EventArgs e)
        {
            btn_NhanVien.ForeColor = Color.Black;
        }



        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_nhaphangcontainer);
        }

        private void btn_NhapHang_MouseHover(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = Color.DarkOrange;
        }

        private void btn_NhapHang_MouseLeave(object sender, EventArgs e)
        {
            btn_NhapHang.ForeColor = Color.Black;

        }

        private void btn_nhaphanginfo_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Ghi nhận đơn hàng";
            ImportUC newNH = new ImportUC();
            newNH.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newNH);
            HideSubMenu();
        }

        private void btn_nhaphangdetail_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Chi tiết đơn hàng";
            ImportDetailUC newCT = new ImportDetailUC();
            newCT.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newCT);
            HideSubMenu();
        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Thanh lý sách";
            LiquidateUC newTK = new LiquidateUC();
            newTK.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newTK);
            HideSubMenu();
        }


        private void btBC_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panel_ReportContainer);
        }

        private void btn_BCTK_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Báo cáo tồn kho";
            StockReportUC newTK = new StockReportUC();
            newTK.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newTK);
            HideSubMenu();
        }

        private void btn_BCDT_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Báo cáo doanh thu bán hàng";
            RevenueReportUC newTK = new RevenueReportUC();
            newTK.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newTK);
            HideSubMenu();
        }

        private void btn_BCTL_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            lbl_title.Text = "Báo cáo thanh lý sách";
            LiquidationReportUC newTK = new LiquidationReportUC();
            newTK.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newTK);
            HideSubMenu();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------------
    }
}
