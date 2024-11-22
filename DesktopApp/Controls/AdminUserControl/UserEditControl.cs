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
                // Lấy thông tin người dùng từ database
                var existingUser = await _userManager.FindByIdAsync(_user.Id);

                if (existingUser != null)
                {
                    // Cập nhật các thông tin cần thay đổi
                    existingUser.DisplayName = txtNameUser.Text;
                    existingUser.Email = txtEmailNguoiDung.Text;
                    existingUser.PhoneNumber = txtSoDienThoai.Text;

                    // Cập nhật người dùng
                    var updateResult = await _userManager.UpdateAsync(existingUser);

                    if (updateResult.Succeeded)
                    {
                        // Xóa các role hiện tại
                        var userRoles = await _userManager.GetRolesAsync(existingUser);
                        var removeRoleResult = await _userManager.RemoveFromRolesAsync(existingUser, userRoles);

                        if (removeRoleResult.Succeeded)
                        {
                            // Thêm role mới
                            var addRoleResult = await _userManager.AddToRoleAsync(existingUser, cbRoleUser.Text);
                            if (addRoleResult.Succeeded)
                            {
                                MessageBox.Show("Cập nhật thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Lỗi khi thêm quyền: {string.Join(", ", addRoleResult.Errors.Select(e => e.Description))}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi khi xóa quyền: {string.Join(", ", removeRoleResult.Errors.Select(e => e.Description))}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi khi cập nhật người dùng: {string.Join(", ", updateResult.Errors.Select(e => e.Description))}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
