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
    public partial class DashBoard : UserControl
    {
       
        public DashBoard()
        {
            InitializeComponent();
          
            ColapseMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColapseMenu();
        }
        private void ColapseMenu()
        {
            if (this.PanelSideBar.Width >= 250)
            {
                //thu gọn menu
                this.PanelSideBar.Width = 100;
               btnLogo.Text = "";
                


                foreach (Button menuButton in PanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {                 
                this.PanelSideBar.Width = 250;
                
               

                foreach (Button menuButton in PanelSideBar.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

      
    }

  
}
