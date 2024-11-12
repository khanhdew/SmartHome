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
        public AdminControl()
        {
            InitializeComponent();
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ColapseMenu();
        }

        private void ColapseMenu()
        {
            if (PanelSB.Width >= 221)
            {
                PanelSB.Width = 60;
              
                foreach (Button menuButton in PanelSB.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                PanelSB.Width = 221;
                foreach (Button menuButton in PanelSB.Controls.OfType<Button>())
                {
                    // Kiểm tra nếu Tag không null trước khi sử dụng
                    if (menuButton.Tag != null)
                    {
                        menuButton.Text = " " + menuButton.Tag.ToString();
                    }
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }
    }
}
