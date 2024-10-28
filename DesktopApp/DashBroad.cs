<<<<<<< Updated upstream
﻿using DAO.BaseModels;
=======
﻿using DesktopApp.Devices;
using DesktopApp.Rooms;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public User user;
=======
        ControlHouse controlHouse = new ControlHouse();
        ControlRoom controlRoom = new ControlRoom();
        ControlDevice controlDevice = new ControlDevice();
>>>>>>> Stashed changes
        public DashBroad()
        { 
            InitializeComponent();
            ColaspMenu();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColaspMenu();
        }

        // Thu gọn hoặc mở rộng menu
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
<<<<<<< Updated upstream
        
=======
      
        // Hiển thị control House
        private void ShowControlHouse()
        {
            PanelMain.Controls.Clear();
            controlHouse.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlHouse);

        }
        // Hiển thị control Room
        private void ShowControlRoom()
        {
            PanelMain.Controls.Clear();
            controlRoom.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlRoom);
        }
        // Hiển thị control Device
        private void ShowControlDevice()
        {
            PanelMain.Controls.Clear();
            controlDevice.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(controlDevice);
        }

        // click vào menu Home
        private void menuHome_Click(object sender, EventArgs e)
        {
            ShowControlHouse();
        }

        private void iconBaCham_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(iconBaCham, new Point(0, iconBaCham.Height));
        }
        // click vào menu Room
        private void menuRoom_Click(object sender, EventArgs e)
        {
            ShowControlRoom();
        }
        // click vào menu Device
        private void menuDevice_Click(object sender, EventArgs e)
        {
            ShowControlDevice();
        }

        private void menuSetting_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            
        }
>>>>>>> Stashed changes
    }
}
