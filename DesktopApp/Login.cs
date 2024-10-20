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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

        }
        public event EventHandler? ClickForPassWord;
        public event EventHandler? Login_Click;
        public event EventHandler? Signup_Click;
        private void OnLinkClicked(EventArgs e)
        {
            ClickForPassWord?.Invoke(this, e);
        }

        private void OnLoginClicked(EventArgs e)
        {
            Login_Click?.Invoke(this, e);
        }

        private void OnSignupClicked(EventArgs e)
        {
            Signup_Click?.Invoke(this, e);
        }

        private void quenPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkClicked(EventArgs.Empty);
<<<<<<< HEAD

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
=======
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnLoginClicked(EventArgs.Empty);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            OnSignupClicked(EventArgs.Empty);
        }
>>>>>>> df3af0565a0b1ce6a5feaa17e90a6e5765382270
    }
}
