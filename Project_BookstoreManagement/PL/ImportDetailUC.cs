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
using Project_BookstoreManagement.BLL;

namespace Project_BookstoreManagement.PL
{
    public partial class ImportDetailUC : UserControl
    {
        public ImportDetailUC()
        {
            InitializeComponent();
            LoadForm();
            Customize();
        }

        private void Customize()
        {
            grid_ChitietHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_ChitietHD.MultiSelect = false;
            grid_ChitietHD.ReadOnly = true;

            grid_kho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_kho.MultiSelect = false;
            grid_kho.ReadOnly = true;

            grid_import.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_import.MultiSelect = false;
            grid_import.ReadOnly = true;

            grid_ChitietHD.Columns["ImportId"].HeaderText = "Mã hóa đơn";
            grid_ChitietHD.Columns["BookId"].HeaderText = "Mã sản phẩm";
            grid_ChitietHD.Columns["BookQuantity"].HeaderText = "Số lượng";
            grid_ChitietHD.Columns["UnitCost"].HeaderText = "Giá mua";
            grid_ChitietHD.Columns["Status"].Visible = false;

            grid_kho.Columns["BookId"].HeaderText = "Mã sản phẩm";
            grid_kho.Columns["BookQuantity"].HeaderText = "Số lượng";
            grid_kho.Columns["Status"].Visible = false;

            grid_import.Columns["EmplId"].Visible = false;
            grid_import.Columns["VendorId"].Visible = false;
            grid_import.Columns["ImportDate"].Visible = false;
            grid_import.Columns["ImportTotal"].Visible = false;
            grid_import.Columns["Status"].Visible = false;

            grid_ChitietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_import.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_kho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadForm()
        {
            List<StockDTO> newSP = StockBLL.GetStock();
            grid_kho.DataSource = newSP;

            List<ImportDetailDTO> newCT = ImportDetailBLL.GetImpDetail();
            grid_ChitietHD.DataSource = newCT;

            List<ImportDTO> imports = ImportBLL.GetImport();
            grid_import.DataSource = imports;

        }

        private void btn_themSP_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox_maHD.ReadOnly = true;

                if (txtbox_giamua.Text != string.Empty && txtbox_maHD.Text != string.Empty && txtbox_maSP.Text != string.Empty &&
                    txtbox_SoLg.Text != string.Empty)
                {
                    ImportDetailDTO newCT = new ImportDetailDTO();
                    newCT.ImportId = txtbox_maHD.Text.Trim();
                    newCT.BookId = txtbox_maSP.Text.Trim();
                    newCT.BookQuantity = int.Parse(txtbox_SoLg.Text.Trim());
                    newCT.UnitCost = int.Parse(txtbox_giamua.Text.Trim());
                    newCT.Status = true;
                    bool result = ImportDetailBLL.Add(newCT);

                    if (result)
                    {
                        lbl_notifDetail.Text = "Thêm chi tiết hóa đơn mới thành công";
                        LoadForm();
                    }
                    else
                        lbl_notifDetail.Text = "Thêm chi tiết hóa đơn mới thất bại";
                }
                else
                    lbl_notifDetail.Text = "Xin nhập đầy đủ thông tin";
            
            }
            catch (Exception)
            {
                lbl_notifDetail.Text = "Đã xảy ra lỗi";
            }
        }

        private void btn_deleteSP_Click(object sender, EventArgs e)
        {
            if (grid_ChitietHD.SelectedRows.Count == 0)
            {
                lbl_notifDetail.Text = "Xin chọn chi tiết hóa đơn muốn xóa";
                return;
            }

            string entryID = txtbox_maHD.Text.Trim();
            string entryId2 = txtbox_maSP.Text.Trim();
            bool result = ImportDetailBLL.Delete(entryID, entryId2);

            if (result)
            {
                lbl_notifDetail.Text = "Xóa chi tiết thành công";
                LoadForm();
            }
            else
                lbl_notifDetail.Text = "Xóa chi tiết thất bại";
        }

        private void btn_editSP_Click(object sender, EventArgs e)
        {
            ImportDetailDTO newCT = new ImportDetailDTO();
            newCT.ImportId = txtbox_maHD.Text.Trim();
            newCT.BookId = txtbox_maSP.Text.Trim();
            newCT.BookQuantity = int.Parse(txtbox_SoLg.Text.Trim());
            newCT.UnitCost = int.Parse(txtbox_giamua.Text.Trim());
            newCT.Status = true;
            bool result = ImportDetailBLL.Edit(newCT);

            if (result)
            {
                lbl_notifDetail.Text = "Chỉnh sửa chi tiết hóa đơn thành công";
                LoadForm();
            }
            else
                lbl_notifDetail.Text = "Chỉnh sửa chi tiết hóa đơn thất bại";
        }

        private void btn_themvaoSP_Click(object sender, EventArgs e)
        {
            if (grid_ChitietHD.SelectedRows.Count == 0)
            {
                lbl_notifDetail.Text = "Xin chọn hóa đơn muốn nhập kho";
                return;
            }

            string entryID = txtbox_maSP.Text.Trim();
            int amount = int.Parse(txtbox_SoLg.Text.Trim());
            bool result = StockBLL.Import(amount, entryID);

            if (result)
            {
                lbl_notifDetail.Text = "Nhập số lượng thành công";

                string entryId = txtbox_maHD.Text.Trim();
                string entryId2 = txtbox_maSP.Text.Trim();
                bool a = ImportDetailBLL.Delete(entryId, entryId2);

                LoadForm();
            }
            else
                lbl_notifDetail.Text = "Nhập số lượng thất bại";
        }

        private void grid_ChitietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = grid_ChitietHD.Rows[e.RowIndex];
                txtbox_maHD.Text = row.Cells["ImportId"].Value.ToString();
                txtbox_maSP.Text = row.Cells["BookId"].Value.ToString();
                txtbox_SoLg.Text = row.Cells["BookQuantity"].Value.ToString();
                txtbox_giamua.Text = row.Cells["UnitCost"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notifDetail.Text = "Đã xảy ra lỗi";
            }
        }

        private void btn_refreshNV_Click(object sender, EventArgs e)
        {
            txtbox_maHD.Text = "";
            txtbox_maSP.Text = "";
            txtbox_SoLg.Text = "";
            txtbox_giamua.Text = "";
        }

        private void grid_import_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_import.Rows[e.RowIndex];
            List<ImportDetailDTO> newCT = ImportDetailBLL.GetImpDetailByImport(row.Cells["ImportId"].Value.ToString());
            grid_ChitietHD.DataSource = newCT;
            txtbox_maHD.Text = row.Cells["ImportId"].Value.ToString();
        }

        private void grid_kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_kho.Rows[e.RowIndex];
            txtbox_maSP.Text = row.Cells["BookId"].Value.ToString();
        }
    }
}
