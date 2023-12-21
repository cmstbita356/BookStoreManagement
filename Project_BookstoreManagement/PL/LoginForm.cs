using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Project_BookstoreManagement.BLL;
using Project_BookstoreManagement.DTO;


namespace Project_BookstoreManagement.PL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtTaiKhoan.Text = "nhatquang";
            txtMatKhau.Text = "nhatquang";
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string matkhau = GetMD5Password(txtMatKhau.Text.Trim());
            EmployeeDTO user = EmloyeeBLL.CheckLogin(username, matkhau);

            if (user != null)
            {
                if (user.EmplPosition == "QL")
                {
                    AdminForm newadmin = new AdminForm(user);
                    this.Visible = false;     
                    newadmin.StartPosition = FormStartPosition.CenterScreen;
                    newadmin.Show();

                }

                if (user.EmplPosition == "NV")
                {
                    EmployeeForm newemployee = new EmployeeForm(user);
                    this.Visible = false;            
                    newemployee.StartPosition = FormStartPosition.CenterScreen;
                    newemployee.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
