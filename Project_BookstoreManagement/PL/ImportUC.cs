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
using static System.Net.Mime.MediaTypeNames;

namespace Project_BookstoreManagement.PL
{
    public partial class ImportUC : UserControl
    {
        public ImportUC()
        {
            InitializeComponent();
            LoadForm();
            Customize();
        }

        private void Customize()
        {
            grid_HD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_HD.MultiSelect = false;
            grid_HD.ReadOnly = true;

            grid_NCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_NCC.MultiSelect = false;
            grid_NCC.ReadOnly = true;

            grid_HD.Columns["ImportId"].HeaderText = "Mã hóa đơn";
            grid_HD.Columns["EmplId"].HeaderText = "Người nhận";
            grid_HD.Columns["VendorId"].HeaderText = "Mã nhà cung cấp";
            grid_HD.Columns["ImportDate"].HeaderText = "Ngày giao";
            grid_HD.Columns["ImportTotal"].HeaderText = "Thành tiền";
            grid_HD.Columns["Status"].Visible = false;

            grid_NCC.Columns["VendorId"].HeaderText = "Mã nhà cung cấp";
            grid_NCC.Columns["VendorName"].HeaderText = "Tên nhà cung cấp";
            grid_NCC.Columns["VendorPhone"].HeaderText = "Số điện thoại liên lạc";
            grid_NCC.Columns["Status"].Visible = false;

            grid_details.Columns["ImportId"].Visible = false;
            grid_details.Columns["Status"].Visible = false;

            grid_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadForm()
        {
            List<ImportDetailDTO> newdetail = ImportDetailBLL.GetImpDetail();
            grid_details.DataSource = newdetail;

            List<ImportDTO> newHD = ImportBLL.GetImport();
            grid_HD.DataSource = newHD;

            List<VendorDTO> newNCC = VendorBLL.GetVendor();
            grid_NCC.DataSource = newNCC;
            combox_vendor.DataSource = newNCC;
            combox_vendor.ValueMember = "VendorId";
            combox_vendor.DisplayMember = "VendorName";

            List<EmployeeDTO> newem = EmloyeeBLL.GetEmplByPosition();
            combox_empl.DataSource = newem;
            combox_empl.ValueMember = "EmplId";
            combox_empl.DisplayMember = "EmplName";
        }

        private void btn_refreshSP_Click(object sender, EventArgs e)
        {
            txtbox_dthCC.Text = "";
            txtbox_maCC.Text = "";
            txtbox_maHD.Text = "";
            combox_empl.SelectedIndex = 0;
            txtbox_tenCC.Text = "";
            txtbox_thanhtien.Text = "";
            combox_vendor.SelectedIndex = 0;
            date_nhan.Value = DateTime.Now;
        }

        private void btn_themHD_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox_maHD.ReadOnly = true;
                List<ImportDTO> listHD = ImportBLL.GetImport();
                txtbox_maHD.Text = "Imp" + (ImportBLL.CountImp() + 1).ToString("000");

                if (txtbox_thanhtien.Text != string.Empty)
                {
                    ImportDTO entry = new ImportDTO();
                    entry.ImportId = txtbox_maHD.Text.Trim();
                    entry.EmplId = combox_empl.SelectedValue.ToString();
                    entry.VendorId = combox_vendor.SelectedValue.ToString();
                    entry.ImportDate = date_nhan.Value.ToString("dd/MM/yyyy");
                    entry.ImportTotal = int.Parse(txtbox_thanhtien.Text.Trim());
                    entry.Status = true;
                    bool result = ImportBLL.Add(entry);

                    if (result)
                    {
                        lbl_notifNhapHang.Text = "Thêm đơn mới thành công";
                        LoadForm();
                    }
                    else
                        lbl_notifNhapHang.Text = "Thêm đơn mới thất bại";
                }
                else
                    lbl_notifNhapHang.Text = "Xin nhập đầy đủ thông tin hóa đơn";
            }
            catch (Exception)
            {
                lbl_notifNhapHang.Text = "Đã xảy ra lỗi";
            }
        }

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            if (grid_HD.SelectedRows.Count == 0)
            {
                lbl_notifNhapHang.Text = "Xin chọn đơn muốn xóa";
                return;
            }

            string entryID = txtbox_maHD.Text.Trim();
            bool result = ImportBLL.Delete(entryID);

            if (result)
            {
                lbl_notifNhapHang.Text = "Xóa đơn thành công";
                LoadForm();
            }
            else
                lbl_notifNhapHang.Text = "Xóa đơn thất bại";
        }

        private void btn_suaHD_Click(object sender, EventArgs e)
        {
            txtbox_maHD.ReadOnly = true;
            ImportDTO entry = new ImportDTO();
            entry.ImportId = txtbox_maHD.Text.Trim();
            entry.EmplId = combox_empl.SelectedValue.ToString();
            entry.VendorId = combox_vendor.SelectedValue.ToString();
            entry.ImportDate = date_nhan.Value.ToString("dd/MM/yyyy");
            entry.ImportTotal = int.Parse(txtbox_thanhtien.Text.Trim());
            entry.Status = true;

            bool result = ImportBLL.Edit(entry);
            if (result)
            {
                lbl_notifNhapHang.Text = "Chỉnh sửa hóa đơn thành công";
                LoadForm();
            }
            else
                lbl_notifNhapHang.Text = "Chỉnh sửa hóa đơn thất bại";
        }

        private void grid_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_maHD.ReadOnly = true;
                DataGridViewRow row = grid_HD.Rows[e.RowIndex];
                txtbox_maHD.Text = row.Cells["ImportId"].Value.ToString();
                combox_vendor.SelectedValue = row.Cells["VendorId"].Value.ToString();
                combox_empl.SelectedValue = row.Cells["EmplId"].Value.ToString();
                date_nhan.Value = DateTime.ParseExact(row.Cells["ImportDate"].Value.ToString(), "dd/MM/yyyy", null);
                txtbox_thanhtien.Text = row.Cells["ImportTotal"].Value.ToString();

                List<ImportDetailDTO> listdetail = new List<ImportDetailDTO>();
                listdetail = ImportDetailBLL.GetImpDetailByImport(txtbox_maHD.Text);
                grid_details.DataSource = listdetail;
            }
            catch (Exception)
            {
                lbl_notifNhapHang.Text = "Đã xảy ra lỗi";
            }
        }

        private void btn_themNCC_Click(object sender, EventArgs e)
        {
            try
            {
                List<VendorDTO> listNCC = VendorBLL.GetVendor();
                txtbox_maCC.ReadOnly = true;
                txtbox_maCC.Text = "V" + (VendorBLL.CountVendor() + 1).ToString("00");

                if (txtbox_maCC.Text != string.Empty && txtbox_tenCC.Text != string.Empty && txtbox_dthCC.Text != string.Empty)
                {
                    VendorDTO entry = new VendorDTO();
                    entry.VendorId = txtbox_maCC.Text.Trim();
                    entry.VendorName = txtbox_tenCC.Text.Trim();
                    entry.VendorPhone = txtbox_dthCC.Text.Trim();
                    entry.Status = true;
                    bool result = VendorBLL.Add(entry);

                    if (result)
                    {
                        lbl_notifNhapHang.Text = "Thêm nhà cung cấp mới thành công";
                        LoadForm();
                    }
                    else
                        lbl_notifNhapHang.Text = "Thêm nhà cung cấp mới thất bại";
                }
                else
                    lbl_notifNhapHang.Text = "Xin nhập dầy đủ thông tin nhà cung cấp";
            }
            catch (Exception)
            {
                lbl_notifNhapHang.Text = "Đã xảy ra lỗi";
            }
        }

        private void btn_deleteNCC_Click(object sender, EventArgs e)
        {
            if (grid_NCC.SelectedRows.Count == 0)
            {
                lbl_notifNhapHang.Text = "Xin chọn nhà cung cấp muốn xóa";
                return;
            }

            string entryID = txtbox_maCC.Text.Trim();
            bool result = VendorBLL.Delete(entryID);

            if (result)
            {
                lbl_notifNhapHang.Text = "Xóa nhà cung cấp thành công";
                LoadForm();
            }
            else
                lbl_notifNhapHang.Text = "Xóa nhà cung cấp thất bại";
        }

        private void btn_editNCC_Click(object sender, EventArgs e)
        {
            txtbox_maCC.ReadOnly = true;
            VendorDTO entry = new VendorDTO();
            entry.VendorId = txtbox_maCC.Text.Trim();
            entry.VendorName = txtbox_tenCC.Text.Trim();
            entry.VendorPhone = txtbox_dthCC.Text.Trim();
            entry.Status = true;
            bool result = VendorBLL.Edit(entry);
            if (result)
            {
                lbl_notifNhapHang.Text = "Chỉnh sửa nhà cung cấp thành công";
                LoadForm();
            }
            else
                lbl_notifNhapHang.Text = "Chỉnh sửa nhà cung cấp thất bại";
        }

        private void grid_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_maCC.ReadOnly = true;
                DataGridViewRow row = grid_NCC.Rows[e.RowIndex];
                txtbox_maCC.Text = row.Cells["VendorId"].Value.ToString();
                txtbox_tenCC.Text = row.Cells["VendorName"].Value.ToString();
                txtbox_dthCC.Text = row.Cells["VendorPhone"].Value.ToString();

            }
            catch
            {
                lbl_notifNhapHang.Text = "Đã xảy ra lỗi";
            }
        }
    }
}
