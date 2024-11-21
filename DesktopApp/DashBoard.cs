using DesktopApp.Controls.Devices;
using DesktopApp.Controls.Houses;
using DesktopApp.Controls.Rooms;
using DesktopApp.Controls.Setting;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace DesktopApp
{
    public partial class DashBoard1 : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        public DashBoard1(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            ColapseMenu();
            CollapseAll();
            menuHouse.Width += 30;
            GoiUserControl(new HouseControl(_serviceProvider));
        }
       
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColapseMenu();
        }
        private void ColapseMenu()
        {
            if (PanelSideBar.Width >= 210)
            {
                PanelSideBar.Width = 80;
                btnLogo.Text = "";
                PanelLogo.Width = 80;
                foreach (Button menuButton in PanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }


            }
            else
            {
                PanelSideBar.Width = 238;
                btnLogo.Text = "Smart Home";
                PanelLogo.Width = 238;
                foreach (Button menuButton in PanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = " " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;

                }

            }

        }

        private void CollapseAll()
        {
            menuHouse.Width = 215;
            menuRoom.Width = 215;
            menuDevice.Width = 215;
            menuSettings.Width = 215;
            menuAdminPage.Width = 215;
        }

        private void menuAdminPage_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            var newUserControl = new AdminControl(_serviceProvider,this);
            parentForm.Controls.Clear();
            parentForm.Controls.Add(newUserControl);
            newUserControl.Dock = DockStyle.Fill;
        }

        private void menuHouse_Click(object sender, EventArgs e)
        {
            CollapseAll();
            menuHouse.Width += 30;
            GoiUserControl(new HouseControl(_serviceProvider));
        }

        private void menuRoom_Click(object sender, EventArgs e)
        {
            CollapseAll();
            menuRoom.Width += 30;
            GoiUserControl(new RoomControl(_serviceProvider));
        }

        private void menuDevice_Click(object sender, EventArgs e)
        {
            CollapseAll();
            menuDevice.Width += 30;
            GoiUserControl(new DeviceControl(_serviceProvider));

        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            CollapseAll();
            menuSettings.Width += 30;
            var settingControl = new SettingControl(_serviceProvider);
            GoiUserControl(settingControl);
        }

        private void GoiUserControl(UserControl userControl)
        {
            PanelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(userControl);
        }

        private void Search(object sender, KeyEventArgs e)
        {
            //check if the enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                var userControl = PanelMain.Controls[0];
                switch (userControl.GetType().Name)
                {

                    case "HouseControl":

                        var houseControl = (HouseControl)userControl;
                        houseControl.SearchHouses(guna2TextBox1.Text);
                        break;
                    case "RoomControl":
                        var roomControl = (RoomControl)PanelMain.Controls[0];
                        roomControl.SearchRooms(guna2TextBox1.Text);
                        break;
                    case "DeviceControl":
                        var deviceControl = (DeviceControl)PanelMain.Controls[0];
                        deviceControl.SearchDevices(guna2TextBox1.Text);
                        break;
                    default:
                        break;
                }
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void showDropdownMenu()
        {

            if (Panel4DropdownMenu.Visible == false)
            {
                Panel4DropdownMenu.Visible = true;
            }
            else
            {
                Panel4DropdownMenu.Visible = false;
            }
        }

        private void btndropdownMenu_Click(object sender, EventArgs e)
        {
            showDropdownMenu();
            Panel4DropdownMenu.BringToFront();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            Panel4DropdownMenu.Visible = false;
        }
        
    }
}
