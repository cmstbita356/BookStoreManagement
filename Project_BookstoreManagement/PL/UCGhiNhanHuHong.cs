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
using Project_BookstoreManagement.DAL;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace Project_BookstoreManagement.PL
{
    public partial class UCGhiNhanHuHong : UserControl
    {
        public UCGhiNhanHuHong()
        {
            InitializeComponent();
            LoadForm();
            Customizer();
        }

        private void Customizer()
        {
            txtbox_bookid.ReadOnly = true;

            grid_book.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_book.MultiSelect = false;
            grid_book.ReadOnly = true;

            grid_book.Columns["BookId"].HeaderText = "Mã sách";
            grid_book.Columns["BookName"].HeaderText = "Tên sách";
            grid_book.Columns["BookType"].Visible = false;
            grid_book.Columns["BookAuthor"].Visible = false;
            grid_book.Columns["BookPublisher"].Visible = false;
            grid_book.Columns["BookPrice"].HeaderText = "Đơn giá";
            grid_book.Columns["Status"].Visible = false;

            grid_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadForm()
        {
            grid_book.DataSource = BookBLL.GetBook();
        }

        private void UCGhiNhanHuHong_Load(object sender, EventArgs e)
        {
            grid_book.DataSource = BookBLL.GetBook();
        }

        private void grid_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_book.Rows[e.RowIndex];
            txtbox_bookid.Text = row.Cells["BookId"].Value.ToString();
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            DamagedBookDTO book = DamagedBookBLL.GetBookById(txtbox_bookid.Text);
            book.BookId = txtbox_bookid.Text.Trim();
            book.DamagedQuantity = int.Parse(txtbox_quantity.Text);

            bool result = DamagedBookBLL.Edit(book);

            if (result)
            {
                lbl_notiCus.Text = "Ghi nhận thành công";
            }
            else
            {
                lbl_notiCus.Text = "Ghi nhận thất bại";
            }
        }
    }
}
