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
    public partial class EmployeeUC : UserControl
    {
        public EmployeeUC()
        {
            InitializeComponent();
            LoadForm();
            Customize();
        }

        private void Customize()
        {
            grid_NV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_NV.MultiSelect = false;
            grid_NV.ReadOnly = true;

            grid_NV.Columns["EmplId"].HeaderText = "Mã nhân viên";
            grid_NV.Columns["EmplName"].HeaderText = "Tên nhân viên";
            grid_NV.Columns["EmplDegree"].HeaderText = "Bằng cấp";
            grid_NV.Columns["EmplPosition"].HeaderText = "Chức vụ";
            grid_NV.Columns["EmplAddress"].HeaderText = "Địa chỉ";
            grid_NV.Columns["EmplPhone"].HeaderText = "Số điện thoại";
            grid_NV.Columns["EmplUsername"].HeaderText = "Tên người dùng";
            grid_NV.Columns["EmplPassword"].Visible = false;
            grid_NV.Columns["Status"].Visible = false;

            combox_NVchucvu.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_NVchucvu.SelectedItem = null;
            combox_deg.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_deg.SelectedItem = null;

            grid_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtbox_maNV.ReadOnly = true;
        }

        private void LoadForm()
        {
            List<EmployeeDTO> listNV = EmloyeeBLL.GetEmpl();
            grid_NV.DataSource = listNV;

            List<PositionDTO> listPos= PositionBLL.GetPos();
            List<DegreeDTO> listDeg = DegreeBLL.GetDeg();
            combox_deg.DataSource = listDeg;
            combox_NVchucvu.DataSource = listPos;

            combox_NVchucvu.DisplayMember = "PtnName";
            combox_NVchucvu.ValueMember = "PtnId";
            combox_deg.DisplayMember = "DegName";
            combox_deg.ValueMember = "DegId";
        }

        private void btn_refreshNV_Click(object sender, EventArgs e)
        {
            txtbox_maNV.Text = "";
            txtbox_tenNV.Text = "";
            txtbox_NVusername.Text = "";
            combox_NVchucvu.SelectedIndex = 0;
            combox_deg.SelectedIndex = 0;
            txtbox_NVsdt.Text = "";
            txtbox_diachi.Text = "";
            LoadForm();
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            //ten, username, sdt, email, diachi
            try
            {
                txtbox_maNV.ReadOnly = true;
                txtbox_maNV.Text = "N" + (EmloyeeBLL.CountEmpl() + 1).ToString("00");

                combox_NVchucvu.SelectedIndex = 0;

                if (txtbox_tenNV.Text != string.Empty || txtbox_NVusername.Text != string.Empty ||
                    txtbox_NVsdt.Text != string.Empty || txtbox_diachi.Text != string.Empty)
                {
                    EmployeeDTO newNV = new EmployeeDTO();
                    newNV.EmplId = txtbox_maNV.Text.Trim();
                    newNV.EmplName = txtbox_tenNV.Text.Trim();
                    newNV.EmplDegree = combox_deg.SelectedValue.ToString();
                    newNV.EmplPosition = combox_NVchucvu.SelectedValue.ToString();
                    newNV.EmplAddress = txtbox_diachi.Text.Trim();
                    newNV.EmplPhone = txtbox_NVsdt.Text.Trim();
                    newNV.EmplUsername = txtbox_NVusername.Text.Trim();
                    newNV.EmplPassword = "e10adc3949ba59abbe56e057f20f883e";
                    newNV.Status = true;
                    bool result = EmloyeeBLL.Add(newNV);

                    if (result)
                    {
                        lbl_notifNV.Text = "Thêm nhân viên mói thành công";
                        LoadForm();
                    }
                    else
                    {
                        lbl_notifNV.Text = "Thêm nhân viên mới thất bại";
                    }
                }
                else
                {
                    lbl_notifNV.Text = "Xin nhập đầy đủ dữ liệu";
                }
            }
            catch (Exception)
            {
                lbl_notifNV.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btn_deleteNV_Click(object sender, EventArgs e)
        {
            if (grid_NV.SelectedRows.Count == 0)
            {
                lbl_notifNV.Text = "Xin chọn nhân viên muốn xóa";
            }
            string entryID = txtbox_maNV.Text.Trim();
            bool result = EmloyeeBLL.Delete(entryID);

            if (result)
            {
                lbl_notifNV.Text = "Xóa nhân viên thành công";
                LoadForm();
            }
            else
            {
                lbl_notifNV.Text = "Xóa nhân viên thất bại";
            }
        }

        private void btn_editNV_Click(object sender, EventArgs e)
        {
            txtbox_maNV.ReadOnly = true;

            EmployeeDTO entry = new EmployeeDTO();
            entry.EmplId = txtbox_maNV.Text.Trim();
            entry.EmplName = txtbox_tenNV.Text.Trim();
            entry.EmplDegree = combox_deg.SelectedValue.ToString();
            entry.EmplPosition = combox_NVchucvu.SelectedValue.ToString();
            entry.EmplAddress = txtbox_diachi.Text.Trim();
            entry.EmplPhone = txtbox_NVsdt.Text.Trim();
            entry.EmplUsername = txtbox_NVusername.Text.Trim();
            entry.EmplPassword = "e10adc3949ba59abbe56e057f20f883e";
            entry.Status = true;
            bool result = EmloyeeBLL.Edit(entry);

            if (result)
            {
                lbl_notifNV.Text = "Chỉnh sửa nhân viên thành công";
                LoadForm();
            }
            else
            {
                lbl_notifNV.Text = "Chỉnh sửa nhân viên thất bại";            }
        }

        private void grid_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_maNV.ReadOnly = true;
                DataGridViewRow row = grid_NV.Rows[e.RowIndex];

                txtbox_maNV.Text = row.Cells["EmplId"].Value.ToString();
                txtbox_tenNV.Text = row.Cells["EmplName"].Value.ToString();
                combox_deg.SelectedValue = row.Cells["EmplDegree"].Value.ToString();
                combox_NVchucvu.SelectedValue = row.Cells["EmplPosition"].Value.ToString();
                txtbox_diachi.Text = row.Cells["EmplAddress"].Value.ToString();
                txtbox_NVsdt.Text = row.Cells["EmplPhone"].Value.ToString();
                txtbox_NVusername.Text = row.Cells["EmplUsername"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notifNV.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            string entryID = txtbox_maNV.Text.Trim();
            bool result = EmloyeeBLL.ResetPassword(entryID);

            if (result)
            {
                lbl_notifNV.Text = $"Đã đặt lại mật khẩu cho nhân viên có mã {txtbox_maNV.Text}";
                LoadForm();
            }
            else
            {
                lbl_notifNV.Text = "Đặt lại mật khẩu thất bại. Xin thử lại";
            }
        }
    }
}
