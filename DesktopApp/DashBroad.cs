using DAO.BaseModels;
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
        public User user;
        public DashBroad()
        { 
            InitializeComponent();
           ColaspMenu();

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
        
    }
}
