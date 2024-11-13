using Services.Services;
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
    public partial class SignUp : UserControl
    {
        private readonly IUserService _userService;

        public SignUp(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            if (parentForm != null)
            {
                var newUserControl = new Login(_userService);
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;
            var parentForm = this.Parent;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _userService.SignUp(username, password, email, confirmPassword);
                MessageBox.Show("Đăng ký thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var newUserControl = new Login(_userService);
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
