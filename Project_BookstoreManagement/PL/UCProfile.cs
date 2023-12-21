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
using System.Xml;

namespace Project_BookstoreManagement.PL
{
    public partial class UCProfile : UserControl
    {
        private EmployeeDTO thisuser;

        public UCProfile(EmployeeDTO user)
        {
            InitializeComponent();
            thisuser = user;
        }

        private void btnSave_Enter(object sender, EventArgs e)
        {
            EmployeeDTO nv = new EmployeeDTO();
            nv.EmplId = thisuser.EmplId;
            nv.EmplName = thisuser.EmplName;
            nv.EmplDegree = thisuser.EmplDegree;
            nv.EmplPosition = "NV";
            nv.EmplUsername = txtUsername.Text;
            nv.EmplPhone = txtSDT.Text;
            nv.EmplAddress = txtDiaChi.Text;
            nv.EmplPassword = thisuser.EmplPassword;

            if(EmloyeeBLL.Edit(nv))
            {
                MessageBox.Show("Thay đổi thông tin thành công",  "Thông báo");
            }
            else
            {
            MessageBox.Show("Không thể thay đổi thông tin",  "Thông báo");
            }
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {
            List<DegreeDTO> deg = DegreeBLL.GetDeg();

            combox_degree.DataSource = deg;
            combox_degree.DisplayMember = "DegName";
            combox_degree.ValueMember = "DegId";

            combox_degree.SelectedValue = thisuser.EmplDegree;
            txtDiaChi.Text = thisuser.EmplAddress;
            txtSDT.Text = thisuser.EmplPhone;
            txtUsername.Text = thisuser.EmplUsername;
            lblName.Text = thisuser.EmplName;
        }
    }
}
