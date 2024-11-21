using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
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
using User = DAO.BaseModels.User;

namespace DesktopApp.Controls.AdminUserControl
{
    public partial class UserEditControl : UserControl
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private User _user;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        public UserEditControl(User user, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<IUserService>();
            _user = user;
            _roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            _userManager = _serviceProvider.GetRequiredService<UserManager<User>>();
            LoadUserData();
            this.AutoScaleMode = AutoScaleMode.None;
           

        }
        private async void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển trên giao diện
                string name = txtNameUser.Text;  // TextBox cho tên hiển thị
                string email = txtEmailNguoiDung.Text;  // TextBox cho email
                string phoneNumber = txtSoDienThoai.Text;  // TextBox cho số điện thoại
               
                
                _user.DisplayName = name;
                _user.Email = email;
                _user.PhoneNumber = phoneNumber;
                var updateResult = _userService.EditUser(_user);

                if (updateResult != null)
                {

                    // clear user roles
                    var userRoles = await _userManager.GetRolesAsync(_user);
                    var removeRoleResult = await _userManager.RemoveFromRolesAsync(_user, userRoles);
                    // add new role
                    var addRoleResult = await _userManager.AddToRoleAsync(_user, cbRoleUser.Text);
                    MessageBox.Show("Cập nhật thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                QuayLaiData();

            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"An error occurred: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            if (_user != null)
            {
                // Gán giá trị cho các control trên form
                txtNameUser.Text = _user.DisplayName;
                txtEmailNguoiDung.Text = _user.Email;
                txtSoDienThoai.Text = _user.PhoneNumber;
                var roles = _roleManager.Roles.ToList();
                cbRoleUser.Items.AddRange(roles.Select(r => r.Name).ToArray());
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuayLaiData()
        {
            var parent = this.Parent;
            var newUserControl = new NguoiDungControl(_serviceProvider);
            parent.Controls.Clear();
            parent.Controls.Add(newUserControl);
            newUserControl.Dock = DockStyle.Fill;
        }
    }
}
