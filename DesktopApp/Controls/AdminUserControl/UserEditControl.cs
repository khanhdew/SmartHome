using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;
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
                var updateResult = await _userManager.UpdateAsync(_user);

                if (updateResult.Succeeded)
                {
                    // Xóa các role hiện tại
                    var userRoles = await _userManager.GetRolesAsync(_user);
                    var removeRoleResult = await _userManager.RemoveFromRolesAsync(_user, userRoles);

                    if (removeRoleResult.Succeeded)
                    {
                        // Thêm role mới
                        var addRoleResult = await _userManager.AddToRoleAsync(_user, cbRoleUser.Text);
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
                //QuayLaiData();
            }
            
               
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
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
                cbRoleUser.SelectedItem = roles[0].Name;
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
