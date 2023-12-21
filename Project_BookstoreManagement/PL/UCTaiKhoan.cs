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
using System.Security.Cryptography;


namespace Project_BookstoreManagement.PL
{
    public partial class UCTaiKhoan : UserControl
    {
        private EmployeeDTO thisuser;

        public static string GetMD5Password(string input)
        {
            string strResult = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                strResult = GetMd5Hash(md5Hash, input);
            }
            return strResult;
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        public UCTaiKhoan(EmployeeDTO user)
        {
            InitializeComponent();
            txtOldPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtCheck.UseSystemPasswordChar = true;
            thisuser = user;
        }

        private void mkcu_Click(object sender, EventArgs e)
        {
            if (txtOldPass.UseSystemPasswordChar == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
            }
            else { txtOldPass.UseSystemPasswordChar = true; }
        }

        private void mkmoi_Click(object sender, EventArgs e)
        {
            if (txtNewPass.UseSystemPasswordChar == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else { txtNewPass.UseSystemPasswordChar = true; }
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            if (txtCheck.UseSystemPasswordChar == true)
            {
                txtCheck.UseSystemPasswordChar = false;
            }
            else { txtCheck.UseSystemPasswordChar = true; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtCheck.Text == txtNewPass.Text && txtNewPass.Text != txtOldPass.Text && GetMD5Password(txtOldPass.Text.Trim()) == thisuser.EmplPassword)
            {
                string newpassword = GetMD5Password(txtNewPass.Text.Trim());
                bool result = EmloyeeBLL.ChangePassword(newpassword, thisuser.EmplId);
                if (result)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "thông báo!");
                }
                else
                    MessageBox.Show("Đổi mật khẩu thất bại", "thông báo!");
            }
            else
                MessageBox.Show("Không thể đổi, kiểm tra lại mật khẩu", "thông báo!");
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            lblName.Text = thisuser.EmplName;
        }
    }
}
