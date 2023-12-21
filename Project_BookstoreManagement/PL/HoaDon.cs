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
    public partial class Hóa_đơn : Form
    {
        public Hóa_đơn()
        {
            InitializeComponent();
        }
        public Hóa_đơn(string tennv, string tenkh, string ngaygiao, string thanhtien, DataGridViewRowCollection dgvrow)
        {
            InitializeComponent();
            lbTennv.Text = tennv; lbTennv.AutoSize = true;
            lbTenkh.Text = tenkh; lbTenkh.AutoSize = true;
            lbNgayGiao.Text = ngaygiao; lbNgayGiao.AutoSize = true;
            lbThanhTien.Text = thanhtien; lbThanhTien.AutoSize = true;

            this.dgv.ColumnCount = 6;
            this.dgv.Columns[0].Name = "Mã sản phẩm";
            this.dgv.Columns[1].Name = "Tên sản phẩm";
            this.dgv.Columns[2].Name = "Số lượng";
            this.dgv.Columns[3].Name = "Đơn giá";
            this.dgv.Columns[4].Name = "Thành tiền";

            foreach (DataGridViewRow row in dgvrow)
            {
                if (row.Cells[0].Value != null)
                {
                    string[] s = new string[]
                    {
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    };
                    this.dgv.Rows.Add(s);
                }
            }
        }
    }
}
