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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }

        private void lblinkSignup_LinkClicked(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }

        private void ShowLoginPanel()
        {
            Panel.Controls.Clear();
            Login loginControl = new Login();
            SetControlSizeAndPosition(loginControl, 0.57, 1);
            loginControl.LinkClicked += Login_LinkClicked;
            Panel.Controls.Add(loginControl);
       
        
         }

        private void ShowSignInPanel()
        {
            Panel.Controls.Clear();
            SignIn signInControl = new SignIn();
            signInControl.LinkClicked += SignInControl_LinkClicked;
            SetControlSizeAndPosition(signInControl, 0.56, 1.05);
            Panel.Controls.Add(signInControl);
            
        }

        private void SignInControl_LinkClicked(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }
        private void Login_LinkClicked(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }

        private void SetControlSizeAndPosition(Control control, double widthPercent, double heightPercent)
        {
            control.Width = (int)(Panel.Width * widthPercent);
            control.Height = (int)(Panel.Height * heightPercent);
            control.Location = new Point(
                (Panel.Width - control.Width) / 2,
                (Panel.Height - control.Height) / 2
            );
        }
    }
}
