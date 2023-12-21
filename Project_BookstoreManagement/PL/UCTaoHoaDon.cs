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

namespace Project_BookstoreManagement.PL
{
    public partial class UCTaoHoaDon : UserControl
    {
        private EmployeeDTO thisuser;

        public UCTaoHoaDon(EmployeeDTO user)
        {
            InitializeComponent();
            grid_khachhang.DataSource = CustomerBLL.GetCustomer();

            grid_khachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_khachhang.MultiSelect = false;
            grid_khachhang.ReadOnly = true;

            grid_khachhang.Columns["CustomerId"].HeaderText = "Mã khách hàng";
            grid_khachhang.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            grid_khachhang.Columns["CustomerPhone"].HeaderText = "Số điện thoại";
            grid_khachhang.Columns["CustomerEmail"].HeaderText = "Email";
            grid_khachhang.Columns["Status"].Visible = false;

            grid_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            thisuser = user;
            danhsachsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void addItems(AutoCompleteStringCollection col)
        {
            List<BookDTO> a = BookBLL.GetBook();
            foreach (BookDTO sp in a)
            {
                col.Add(sp.BookName);
            }
        }

        //Load
        private void Load_danhsachSP()
        {
            //Tạo datagridview
            danhsachsp.ColumnCount = 5;
            danhsachsp.Columns[0].Name = "Mã sản phẩm";
            danhsachsp.Columns[1].Name = "Tên sản phẩm";
            danhsachsp.Columns[2].Name = "Số lượng";
            danhsachsp.Columns[3].Name = "Đơn giá";
            danhsachsp.Columns[4].Name = "Thành tiền";
        }

        private void taodonmoi_Click(object sender, EventArgs e)
        {
            makh.Text = "";
            tenkh.Text = "";
            txtboxtensp.Text = "";
            soluong.Text = "1";
            tongtien.Text = "";
            danhsachsp.Rows.Clear();
            danhsachsp.Refresh();
            Load_danhsachSP();
        }

        private void them_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(soluong.Text);
            List<BookDTO> a = BookBLL.GetBookByName(txtboxtensp.Text.ToString());
            foreach (BookDTO sp in a)
            {
                string masp = sp.BookId;
                int gia = sp.BookPrice;
                int thanhtien = sl * gia;
                string[] row = { masp, txtboxtensp.Text.ToString(), soluong.Text, gia.ToString(), thanhtien.ToString() };
                danhsachsp.Rows.Add(row);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (this.danhsachsp.SelectedRows.Count > 0)
            {
                danhsachsp.Rows.RemoveAt(this.danhsachsp.SelectedRows[0].Index);
            }
        }

        private void thanhtien_Click(object sender, EventArgs e)
        {
            double thanhtien = 0;
            for (int i = 0; i < danhsachsp.Rows.Count - 1; i++)
            {
                thanhtien += int.Parse(danhsachsp.Rows[i].Cells[4].Value.ToString());
            }
            if(makh.Text != "OneTime") thanhtien *= 0.9;
            tongtien.Text = thanhtien.ToString();
        }

        private void UCTaoHoaDon_Load(object sender, EventArgs e)
        {
            Load_danhsachSP();

            manv.Text = thisuser.EmplId;
            tennv.Text = thisuser.EmplName;
            manv.ReadOnly = true;
            tennv.ReadOnly = true;


            //autocomplete
            txtboxtensp.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtboxtensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection);
            txtboxtensp.AutoCompleteCustomSource = DataCollection;
        }

        private void xuathoadon_Click(object sender, EventArgs e)
        {
            //Hiện hóa đơn
            try
            {
                Hóa_đơn hoadon = new Hóa_đơn(tennv.Text, tenkh.Text, DateTime.Now.ToString("dd/MM/yyyy"), tongtien.Text, danhsachsp.Rows);

                string MaHD = ReceiptBLL.GetMaHD();

                ReceiptDTO dto1 = new ReceiptDTO(MaHD, manv.Text, makh.Text, DateTime.Now.ToString("dd/MM/yyyy"), Convert.ToInt32(tongtien.Text), true);
                ReceiptBLL.EF_AddData(dto1);

                foreach (DataGridViewRow row in danhsachsp.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ReceiptDetailDTO dto2 = new ReceiptDetailDTO(MaHD, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()), true);
                        bool result = ReceiptDetailBLL.AddData(dto2);
                    }
                }
                hoadon.ShowDialog();             
            }
            catch (Exception)
            {
                MessageBox.Show("Không được bỏ trống trường thông tin", "Error");
                return;
            }
        }

        private void grid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                makh.ReadOnly = true;
                tenkh.ReadOnly = true;
                DataGridViewRow row = grid_khachhang.Rows[e.RowIndex];

                makh.Text = row.Cells["CustomerId"].Value.ToString();
                tenkh.Text = row.Cells["CustomerName"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
