using DesktopApp.Controls.AdminUserControl;
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
        public AdminControl()
        {
            lblNameUser.Text = MainForm.LoggedInUser.UserName;
            InitializeComponent();
            ColapseMenu();
            SaveControls();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColapseMenu();
        }

        private void ColapseMenu()
        {
            if (PanelSB.Width >= 210)
            {
                PanelSB.Width = 60;
                
                cbQuanLy.Visible = false;
                cbThongKe.Visible = false;
                
                
            }
            else
            {
                PanelSB.Width = 215;
                PanelQuanLy.Dock = DockStyle.Top;
                PanelThongKe.Dock = DockStyle.Top;
                btniconQL.Dock = DockStyle.Top;
                btniconTK.Dock = DockStyle.Top;
                cbQuanLy.Visible = true;
                cbThongKe.Visible = true;

            }
        }
        // Hiển thị UserControl tương ứng 
        private void GoiUserControl(Panel p,UserControl userControl)
        {
            p.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            p.Controls.Add(userControl);
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
                GoiUserControl(PanelMainAdmin, new NguoiDungControl());
            }
            else if (cbQuanLy.SelectedItem.ToString() == "Nhà")
            {
               GoiUserControl(PanelMainAdmin, new NhaControl());
            }
            else if (cbQuanLy.SelectedItem.ToString()=="Thiết bị") 
            {
               GoiUserControl(PanelMainAdmin, new ThietBiControl());
            }
        }
    }
}
