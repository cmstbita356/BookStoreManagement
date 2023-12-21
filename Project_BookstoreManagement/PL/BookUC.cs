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
    public partial class BookUC : UserControl
    {
        public BookUC()
        {
            InitializeComponent();
            LoadForm();
            Customizer();
        }

        private void Customizer()
        {
            // Book
            grid_SP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_SP.MultiSelect = false;
            grid_SP.ReadOnly = true;

            grid_SP.Columns["BookId"].HeaderText = "Mã sách";
            grid_SP.Columns["BookName"].HeaderText = "Tên sách";
            grid_SP.Columns["BookType"].HeaderText = "Mã loại";
            grid_SP.Columns["BookAuthor"].HeaderText = "Tác giả";
            grid_SP.Columns["BookPublisher"].HeaderText = "Nhà xuất bản";
            grid_SP.Columns["BookPrice"].HeaderText = "Đơn giá";
            grid_SP.Columns["Status"].Visible = false;

            combox_booktype.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_booktype.SelectedItem = null;

            grid_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtbox_bookid.ReadOnly = true;

            // BookType
            grid_LSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_LSP.MultiSelect = false;
            grid_LSP.ReadOnly = true;

            grid_LSP.Columns["TypeId"].HeaderText = "Mã loại";
            grid_LSP.Columns["TypeName"].HeaderText = "Tên loại";
            grid_LSP.Columns["Status"].Visible = false;

            txtbox_maLSP.ReadOnly = true;
        }

        private void btn_refreshSP_Click(object sender, EventArgs e)
        {
            LoadForm();
            txtbox_bookid.Text = "";
            txtbox_bookname.Text = "";
            txtbox_author.Text = "";
            txtbox_publisher.Text = "";
            txtbox_price.Text = "";
            lbl_notifSP.Text = "";
            txtbox_maLSP.Text = "";
            txtbox_tenLSP.Text = "";
            combox_booktype.SelectedItem = null;
        }

        private void LoadForm()
        {
            //Book
            List<BookDTO> listSP = BookBLL.GetBook();
            grid_SP.DataSource = listSP;

            List<BookTypeDTO> listLSP = BookTypeBLL.GetBookType();
            combox_booktype.DataSource = listLSP;
            grid_LSP.DataSource = listLSP;
            combox_booktype.DisplayMember = "TypeName";
            combox_booktype.ValueMember = "TypeId";
        }

        // ------------------ Book functions -------------------------
        private void btn_themSP_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox_bookid.ReadOnly = true;
                txtbox_bookid.Text = "B" + (BookBLL.CountBook() + 1).ToString("000");
                
                if (txtbox_bookname.Text != string.Empty || txtbox_author.Text != string.Empty ||
                    txtbox_publisher.Text != string.Empty || txtbox_price.Text != string.Empty ||
                    combox_booktype.SelectedItem != null)
                {
                    BookDTO newbook = new BookDTO();
                    newbook.BookId = txtbox_bookid.Text.Trim();
                    newbook.BookName = txtbox_bookname.Text.Trim();
                    newbook.BookAuthor = txtbox_author.Text.Trim();
                    newbook.BookPublisher = txtbox_publisher.Text.Trim();
                    newbook.BookPrice = int.Parse(txtbox_price.Text.Trim());
                    newbook.BookType = combox_booktype.SelectedValue.ToString();
                    newbook.Status = true;

                    StockDTO newstock = new StockDTO();
                    newstock.BookId = txtbox_bookid.Text.Trim();
                    newstock.BookQuantity = 0;

                    bool result = BookBLL.Add(newbook);
                    bool result2 = StockBLL.Add(newstock);

                    if (result && result2)
                    {
                        lbl_notifSP.Text = "Thêm sách mới thành công";
                        LoadForm();
                    }
                    else
                    {
                        lbl_notifSP.Text = "Thêm sách mới thất bại";
                    }
                        
                }
                else
                    lbl_notifSP.Text = "Xin nhập dữ liệu đầy đủ";
            }
            catch (Exception)
            {
                lbl_notifSP.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btn_deleteSP_Click(object sender, EventArgs e)
        {
            if (grid_SP.SelectedRows.Count == 0)
            {
                lbl_notifSP.Text = "Xin chọn sách muốn xóa";
                return;
            }

            string entryID = txtbox_bookid.Text.Trim();
            bool result = BookBLL.Delete(entryID);
            bool result2 = StockBLL.Delete(entryID);

            if (result)
            {
                lbl_notifSP.Text = "Xóa sách thành công";
                combox_booktype.SelectedItem = null;
                LoadForm();
            }
            else
            {
                lbl_notifSP.Text = "Xóa sách thất bại";
            }
                
        }

        private void btn_editSP_Click(object sender, EventArgs e)
        {
            txtbox_bookid.ReadOnly = true;

            BookDTO entry = new BookDTO();
            entry.BookId = txtbox_bookid.Text.Trim();
            entry.BookName = txtbox_bookname.Text.Trim();
            entry.BookAuthor = txtbox_author.Text.Trim();
            entry.BookPublisher = txtbox_publisher.Text.Trim();
            entry.BookPrice = int.Parse(txtbox_price.Text.Trim());
            entry.BookType = combox_booktype.SelectedValue.ToString();
            entry.Status = true;
            bool result = BookBLL.Edit(entry);

            if (result)
            {
                lbl_notifSP.Text = "Chỉnh sửa sách thành công";
                combox_booktype.SelectedItem = null;
                LoadForm();
            }
            else
            {
                lbl_notifSP.Text = "Chỉnh sửa sách thất bại";
            }
        }

        private void grid_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_bookid.ReadOnly = true;
                DataGridViewRow row = grid_SP.Rows[e.RowIndex];

                txtbox_bookid.Text = row.Cells["BookId"].Value.ToString();
                txtbox_bookname.Text = row.Cells["BookName"].Value.ToString();
                txtbox_author.Text = row.Cells["BookAuthor"].Value.ToString();
                txtbox_publisher.Text = row.Cells["BookPublisher"].Value.ToString();
                txtbox_price.Text = row.Cells["BookPrice"].Value.ToString();
                combox_booktype.SelectedValue = row.Cells["BookType"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notifSP.Text = "Đã có lỗi xảy ra";
            }
        }
        // ------------------------------------------------------------------------------

        // ------------------ BookType functions -------------------------
        private void btn_themLSP_Click(object sender, EventArgs e)
        {
            txtbox_maLSP.ReadOnly = true;
            txtbox_maLSP.Text = "T" + (BookTypeBLL.CountBookType() + 1).ToString("00");

            try
            {
                if (txtbox_tenLSP.Text != string.Empty)
                {
                    BookTypeDTO newLSP = new BookTypeDTO();
                    newLSP.TypeId = txtbox_maLSP.Text.Trim();
                    newLSP.TypeName = txtbox_tenLSP.Text.Trim();
                    newLSP.Status = true;

                    bool result = BookTypeBLL.Add(newLSP);

                    if (result)
                    {
                        lbl_notifLSP.Text = "Thêm loại sách mới thành công";
                        LoadForm();
                    }
                    else
                        lbl_notifLSP.Text = "Thêm loại sách mới thất bại";

                }
                else
                {
                    lbl_notifLSP.Text = "Xin nhập đầy đủ dữ liệu";
                }
            }
            catch (Exception)
            {
                lbl_notifLSP.Text = "Đã có lỗi xảy ra";
            }
        }

        private void btn_deleteLSP_Click(object sender, EventArgs e)
        {
            if (grid_LSP.SelectedRows.Count == 0)
            {
                lbl_notifLSP.Text = "Xin chọn loại sách muốn xóa";
                return;
            }
            string entryID = txtbox_maLSP.Text;
            bool result = BookTypeBLL.Delete(entryID);

            if (result)
            {
                lbl_notifLSP.Text = "Xóa loại sách thành công";
                LoadForm();
            }
            else
            {
                lbl_notifLSP.Text = "Xóa loại sách thất bại";
            }
        }

        private void btn_editLSP_Click(object sender, EventArgs e)
        {
            BookTypeDTO entry = new BookTypeDTO();
            entry.TypeId = txtbox_maLSP.Text.Trim();
            entry.TypeName = txtbox_tenLSP.Text.Trim();
            entry.Status = true;
            bool result = BookTypeBLL.Edit(entry);

            if (result)
            {
                lbl_notifLSP.Text = "Chỉnh sửa loại sách thành công";
                LoadForm();
            }
            else
                lbl_notifLSP.Text = "Chỉnh sửa loại sách thất bại";
        }

        private void grid_LSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_maLSP.ReadOnly = true;
                DataGridViewRow row = grid_LSP.Rows[e.RowIndex];

                txtbox_maLSP.Text = row.Cells["TypeId"].Value.ToString();
                txtbox_tenLSP.Text = row.Cells["Typename"].Value.ToString();
            }
            catch (Exception)
            {
                lbl_notifLSP.Text = "Đã có lỗi xảy ra";
            }
        }
        // ------------------------------------------------------------------------------

    }
}
