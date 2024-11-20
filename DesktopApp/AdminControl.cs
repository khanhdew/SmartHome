using DAO.BaseModels;
using DesktopApp.Controls.AdminUserControl;
using DesktopApp.Controls.Devices;
using DesktopApp.Controls.Houses;
using DesktopApp.Controls.Rooms;
using Guna.UI2.WinForms;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class AdminControl : UserControl
    {
        private List<Control> trangThaiControls;
       
        private DashBoard _dashBoard;
        private readonly IServiceProvider _serviceProvider;
     
        public AdminControl(IServiceProvider serviceProvider, DashBoard dashBoard)
        {
            InitializeComponent();
            _dashBoard = dashBoard;
            lblNameUser.Text = MainForm.LoggedInUser.UserName;
            _serviceProvider = serviceProvider;
          
            SaveControls();
           

        }
       
        // Hiển thị UserControl tương ứng 
        private void GoiUserControl(UserControl userControl)
        {
            PanelMainAdmin.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            PanelMainAdmin.Controls.Add(userControl);
        }

        private void SaveControls()
        {
            trangThaiControls = new List<Control>();
            foreach (Control control in PanelMainAdmin.Controls)
            {
                trangThaiControls.Add(control);
            }
        }
        private void CbQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelMainAdmin.Controls.Clear();

            if (cbQuanLy.SelectedItem.ToString() == "Quản lý")
            {
                PanelMainAdmin.Controls.AddRange(trangThaiControls.ToArray());

                return;
            }
            else
            if (cbQuanLy.SelectedItem.ToString() == "Người dùng")
            {
               
                GoiUserControl( new NguoiDungControl(_serviceProvider));
               
            }
            else if (cbQuanLy.SelectedItem.ToString() == "Nhà")
            {
                GoiUserControl( new NhaControl(_serviceProvider));
            }
            else if (cbQuanLy.SelectedItem.ToString() == "Thiết bị")
            {
                GoiUserControl( new ThietBiControl(_serviceProvider));
            }
        }

        private void btnAdminPro_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            if (parentForm == null)
            {
                MessageBox.Show("Parent form is null. Cannot navigate to DashBoard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parentForm.Controls.Clear();
            parentForm.Controls.Add(_dashBoard); 
            _dashBoard.Dock = DockStyle.Fill;
        }

        private void btnSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ ô tìm kiếm
            string searchTerm = btnSearchAdmin.Text.Trim().ToLower();

            // Lấy user control hiện tại
            var userControl = PanelMainAdmin.Controls[0];
            switch (userControl.GetType().Name)
            {
                case "NguoiDungControl":
                    var nguoidungControl = (NguoiDungControl)userControl;
                    nguoidungControl.SearchUser(searchTerm); 
                    break;
                case "NhaControl":
                    var nhaControl = (NhaControl)PanelMainAdmin.Controls[0];
                    nhaControl.SearchHouses(searchTerm);  
                    break;
                case "ThietBiControl":
                    var thietbiControl = (ThietBiControl)userControl;
                    thietbiControl.SearchThietBi(searchTerm);
                    break;
                default:
                    break;
            }
        }
    }
}
