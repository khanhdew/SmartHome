using DAO.Exceptions.UserExceptions;
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
    public partial class Login : UserControl
    {

        private readonly IUserService _userService;
        public Login(IUserService userService)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            _userService = userService;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent ;
            var newUserControl = new SignUp(_userService); 
            parentForm.Controls.Clear();
            parentForm.Controls.Add(newUserControl);
            newUserControl.Dock = DockStyle.Fill;
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var persistent = checkLogin.Checked;
            try
            {
                _userService.Login(username, password, persistent);
                MessageBox.Show("Dang nhap thanh cong");
                var newUserControl = new DashBoard();
                newUserControl.btnNameUser.Text ="Hello, "+ username;
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;

            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("Đăng nhập không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $" {username} {password} {persistent}");
            }
          
        }
    }
}
