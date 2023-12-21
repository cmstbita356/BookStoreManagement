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
    public partial class LiquidateUC : UserControl
    {
        public LiquidateUC()
        {
            InitializeComponent();
            LoadForm();
            Customizer();
        }

        private void Customizer()
        {
            grid_dmg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_dmg.MultiSelect = false;
            grid_dmg.ReadOnly = true;

            grid_dmg.Columns["BookId"].HeaderText = "Mã sách";
            grid_dmg.Columns["DamagedQuantity"].HeaderText = "Số lượng cần thanh lý";
            grid_dmg.Columns["DamagedTotal"].HeaderText = "Tổng hư hại";
            grid_dmg.Columns["Liquidated"].HeaderText = "Đã thanh lý";
            grid_dmg.Columns["Status"].Visible = false;
        }

        private void LoadForm()
        {
            List<DamagedBookDTO> listSP = DamagedBookBLL.GetDmgBook();
            grid_dmg.DataSource = listSP;
        }

        private void btn_refreshNV_Click(object sender, EventArgs e)
        {
            LoadForm();
            txtbox_masach.Text = "";
            txtbox_tongthiethai.Text = "";
            txtbox_dathanhly.Text = "";
            txtbox_tongthiethai.Text = "";
            txtbox_solg.Text = "";
        }

        //-------------------------------------------------------------

        private void btn_thanhly_Click(object sender, EventArgs e)
        {
            txtbox_masach.ReadOnly = true;

            if (int.Parse(txtbox_thanhly.Text.Trim()) > int.Parse(txtbox_tongthiethai.Text))
            {
                lbl_notiCus.Text = "Số tiền thanh lý vượt quá mức cần thiết";
                return;
            }

            bool result = DamagedBookBLL.Liquidate(txtbox_masach.Text.Trim(), int.Parse(txtbox_thanhly.Text.Trim()));

            if (result)
            {
                lbl_notiCus.Text = "Thanh lý thành công";
                LoadForm();
            }
            else
            {
                lbl_notiCus.Text = "Thanh lý thất bại";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DamagedBookBLL.Reset();
        }

        private void grid_dmg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_masach.ReadOnly = true;
                txtbox_dathanhly.ReadOnly = true;
                txtbox_tongthiethai.ReadOnly = true;
                DataGridViewRow row = grid_dmg.Rows[e.RowIndex];

                txtbox_masach.Text = row.Cells["BookId"].Value.ToString();
                txtbox_solg.Text = row.Cells["DamagedQuantity"].Value.ToString();
                txtbox_tongthiethai.Text = row.Cells["DamagedTotal"].Value.ToString();
                txtbox_dathanhly.Text = row.Cells["Liquidated"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notiCus.Text = "Đã có lỗi xảy ra";
            }
        }
    }
}
