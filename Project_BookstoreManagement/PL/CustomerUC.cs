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
    public partial class CustomerUC : UserControl
    {
        public CustomerUC()
        {
            InitializeComponent();
            LoadForm();
            Customizer();
        }

        private void Customizer()
        {
            grid_cus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_cus.MultiSelect = false;
            grid_cus.ReadOnly = true;

            grid_cus.Columns["CustomerId"].HeaderText = "Mã khách hàng";
            grid_cus.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            grid_cus.Columns["CustomerPhone"].HeaderText = "Số điện thoại";
            grid_cus.Columns["CustomerEmail"].HeaderText = "Email";
            grid_cus.Columns["Status"].Visible = false;

            grid_cus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtbox_cusid.ReadOnly = true;
        }

        private void LoadForm()
        {
            List<CustomerDTO> listcus = CustomerBLL.GetCustomer();
            grid_cus.DataSource = listcus;
        }

        private void btn_refreshCus_Click(object sender, EventArgs e)
        {
            LoadForm();
            txtbox_cusemail.Text = "";
            txtbox_cusid.Text = "";
            txtbox_cusname.Text = "";
            txtbox_cusphone.Text = "";
        }

        private void btn_themkhach_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox_cusid.ReadOnly = true;
                txtbox_cusid.Text = "C" + CustomerBLL.CountCustomer().ToString("00");

                if (txtbox_cusname.Text != string.Empty || txtbox_cusphone.Text != string.Empty ||
                    txtbox_cusemail.Text != string.Empty)
                {
                    CustomerDTO newcus = new CustomerDTO();
                    newcus.CustomerId = txtbox_cusid.Text.Trim();
                    newcus.CustomerName = txtbox_cusname.Text.Trim();
                    newcus.CustomerPhone = txtbox_cusphone.Text.Trim();
                    newcus.CustomerEmail = txtbox_cusemail.Text.Trim();
                    newcus.Status = true;
                    bool result = CustomerBLL.Add(newcus);

                    if (result)
                    {
                        lbl_notiCus.Text = "Thêm khách hàng mới thành công";
                        LoadForm();
                    }
                    else
                    {
                        lbl_notiCus.Text = "Thêm khách hàng mới thất bại";
                    }

                }
                else
                    lbl_notiCus.Text = "Xin nhập dữ liệu đầy đủ";
            }
            catch (Exception)
            {
                lbl_notiCus.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btn_xoakhach_Click(object sender, EventArgs e)
        {
            if (grid_cus.SelectedRows.Count == 0)
            {
                lbl_notiCus.Text = "Xin chọn khách hàng muốn xóa";
                return;
            }

            string entryID = txtbox_cusid.Text.Trim();
            bool result  = CustomerBLL.Delete(entryID);

            if (result)
            {
                lbl_notiCus.Text = "Xóa khách hàng thành công";
                LoadForm();
            }
            else
            {
                lbl_notiCus.Text = "Xóa khách hàng thất bại";
            }
        }

        private void btn_suakhach_Click(object sender, EventArgs e)
        {
            txtbox_cusid.ReadOnly = true;

            CustomerDTO entry = new CustomerDTO();
            entry.CustomerId = txtbox_cusid.Text.Trim();
            entry.CustomerName = txtbox_cusname.Text.Trim();
            entry.CustomerPhone = txtbox_cusphone.Text.Trim();
            entry.CustomerEmail = txtbox_cusemail.Text.Trim();
            entry.Status = true;
            bool result = CustomerBLL.Edit(entry);

            if (result)
            {
                lbl_notiCus.Text = "Chỉnh sửa khách hàng thành công";
                LoadForm();
            }
            else
            {
                lbl_notiCus.Text = "Chỉnh sửa khách hàng thất bại";
            }
        }

        private void grid_cus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_cusid.ReadOnly = true;
                DataGridViewRow row = grid_cus.Rows[e.RowIndex];

                txtbox_cusid.Text = row.Cells["CustomerId"].Value.ToString();
                txtbox_cusname.Text = row.Cells["CustomerName"].Value.ToString();
                txtbox_cusphone.Text = row.Cells["CustomerPhone"].Value.ToString();
                txtbox_cusemail.Text = row.Cells["CustomerEmail"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notiCus.Text = "Đã có lỗi xảy ra";
            }
        }

    }
}
