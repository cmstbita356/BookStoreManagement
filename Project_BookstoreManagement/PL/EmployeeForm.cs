using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.PL
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDTO currentuser;

        public EmployeeForm(EmployeeDTO user)
        {
            InitializeComponent();
            currentuser = user;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            UCTaoHoaDon uchome = new UCTaoHoaDon(currentuser);
            panel.Controls.Add(uchome);
            uchome.BringToFront();
        }

        private void RemoveAllUC()
        {
            foreach (Control ctrl in panel.Controls)
            {
                panel.Controls.Remove(ctrl);
            }
        }


        private void thôngTinCủaTôiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void càiĐặtTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        private void frmNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            UCTaoHoaDon newHD = new UCTaoHoaDon(currentuser);
            newHD.Dock = DockStyle.Fill;
            panel.Controls.Add(newHD);
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            UCProfile newPr = new UCProfile(currentuser);
            newPr.Dock = DockStyle.Fill;
            panel.Controls.Add(newPr);
        }

        private void đặtLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            UCTaiKhoan newTK = new UCTaiKhoan(currentuser);
            newTK.Dock = DockStyle.Fill;
            panel.Controls.Add(newTK);
        }

        private void ghiNhậnSáchBịHoànTrảHoặcHưHỏngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllUC();
            UCGhiNhanHuHong newTK = new UCGhiNhanHuHong();
            newTK.Dock = DockStyle.Fill;
            panel.Controls.Add(newTK);
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
