using DAO.BaseModels;
using DAO.Exceptions.UserExceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public Login(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _signInManager = _serviceProvider.GetRequiredService<SignInManager<User>>();
            _userManager = _serviceProvider.GetRequiredService<UserManager<User>>();

            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
          
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Click += async (sender, e) => await btnLogin_Click(sender, e);
            Click += async (sender, e) => await btnLogin_Click(sender, e);
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent ;
            var newUserControl = _serviceProvider.GetRequiredService<SignUp>();
            parentForm.Controls.Clear();
            parentForm.Controls.Add(newUserControl);
            newUserControl.Dock = DockStyle.Fill;
          
        }

        private async Task btnLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var persistent = checkLogin.Checked;
            try
            {
                var user = await  _userManager.FindByNameAsync(username);
                if (user!=null)
                {
                    var result = await _userManager.CheckPasswordAsync(user, password);
                    if (result)
                    {
                        MainForm.LoggedInUser = user;
                        MessageBox.Show("Dang nhap thanh cong");
                        var newUserControl = _serviceProvider.GetRequiredService<DashBoard>();
                        var userRole = await _userManager.GetRolesAsync(user);
                        if (userRole.Contains("Admin"))
                        {
                            newUserControl.menuAdminPage.Visible = true;
                        }
                        newUserControl.btnNameUser.Text = "Hello, " + username;
                        parentForm.Controls.Clear();
                        parentForm.Controls.Add(newUserControl);
                        newUserControl.Dock = DockStyle.Fill;
                    }else
                    {
                        MessageBox.Show("Đăng nhập không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
