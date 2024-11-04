using DesktopApp.Devices;
using DesktopApp.Rooms;
using FontAwesome.Sharp;
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
    public partial class DashBroad : UserControl
    {
        public DashBroad()
        {
            InitializeComponent();
            ColaspMenu();
            HienTenUser();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColaspMenu();
        }
        private void ColaspMenu()
        {
            if (this.PanelMenu.Width > 200)
            {
                PanelMenu.Width = 100;
                AnhLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                PanelMenu.Width = 250;
                AnhLogo.Visible = true;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ControlHouse controlHouse = new ControlHouse();
            controlHouse.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlHouse);

        }

        private void menuRoom_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ControlRoom controlRoom = new ControlRoom();
            controlRoom.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlRoom);
        }

        private void menuDevice_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ControlDevice controlDevice = new ControlDevice();
            controlDevice.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlDevice);
        }

        private void HienTenUser()
        {
            Login login = new Login();
            navTenUser.Text = login.txtEmail.Text;
        }

        private void navBacham_Click(object sender, EventArgs e)
        {
            MenuBaCham.Show(navBacham, 0, navBacham.Height);
        }
        // chế độ tối sáng 
        private bool isDarkMode = false;
       

        private void DashMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                PanelMenu.StateNormal.Color1 = Color.FromArgb(0, 29, 53);
                PanelTitleBar.StateNormal.Color1 = Color.FromArgb(0, 29, 53);
                PanelTitleBar.StateNormal.Color2 = Color.FromArgb(0, 29, 53);
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.BackColor = Color.FromArgb(0, 29, 53);
                }
                DashMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOff; 
            }
            else
            {
                PanelMenu.StateNormal.Color1 = Color.FromArgb(0, 105, 91);
                PanelTitleBar.StateNormal.Color1 = Color.FromArgb(0, 105, 91);
                PanelTitleBar.StateNormal.Color2 = Color.FromArgb(0, 105, 91);
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.BackColor = Color.FromArgb(0, 105, 91);
                }
                DashMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOn; 
            }
        }
    }
}
