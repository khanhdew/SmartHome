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

namespace DesktopApp
{
    public partial class DashBoard : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        public DashBoard(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            ColapseMenu();
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
                PanelSideBar.Width = 210;
                btnLogo.Text = "Smart Home";
                PanelLogo.Width = 210;
                foreach (Button menuButton in PanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = " " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;



                }

            }

        }

        private void menuAdminPage_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            var newUserControl = new AdminControl();
            parentForm.Controls.Clear();
            parentForm.Controls.Add(newUserControl);
            newUserControl.Dock = DockStyle.Fill;
        }

        private void menuHouse_Click(object sender, EventArgs e)
        {
            GoiUserControl(new HouseControl(_serviceProvider));
        }

        private void menuRoom_Click(object sender, EventArgs e)
        {
            GoiUserControl(new RoomControl(_serviceProvider));
        }

        private void menuDevice_Click(object sender, EventArgs e)
        {
            GoiUserControl(new DeviceControl());
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            GoiUserControl(new SettingControl());
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
                    //case "RoomControl":
                    //    var roomControl = (RoomControl)PanelMain.Controls[0];
                    //    roomControl.SearchRooms(guna2TextBox1.Text);
                    //    break;
                    //case "DeviceControl":
                    //    var deviceControl = (DeviceControl)PanelMain.Controls[0];
                    //    deviceControl.SearchDevices(guna2TextBox1.Text);
                    //    break;
                    default:
                        break;
                }
            }
        }
    }
}
