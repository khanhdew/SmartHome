using DAO.BaseModels;
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

namespace DesktopApp.Controls.AdminUserControl
{
    public partial class UserEditControl : UserControl
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        private User _user;

        public UserEditControl(User user, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<IUserService>();
            _user = user;
            LoadUserData();
            this.AutoScaleMode = AutoScaleMode.None;


        }
        private  void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển trên giao diện
                string name = txtNameUser.Text;  // TextBox cho tên hiển thị
                string email = txtEmailNguoiDung.Text;  // TextBox cho email
                string phoneNumber = txtSoDienThoai.Text;  // TextBox cho số điện thoại
                string role = cbRoleUser.SelectedItem?.ToString();  // ComboBox cho vai trò

                // Cập nhật thuộc tính của đối tượng User
                _user.UserName = name;
                _user.Email = email;
                _user.PhoneNumber = phoneNumber;
                _user.DisplayName = role;

                 _userService.EditUser(_user);  
                QuayLaiData();

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            if (_user != null)
            {
                // Gán giá trị cho các control trên form
                txtNameUser.Text = _user.UserName;
                txtEmailNguoiDung.Text = _user.Email;
                cbRoleUser.Text = _user.DisplayName;
                txtSoDienThoai.Text = _user.PhoneNumber; // TextBox để chỉnh sửa số điện thoại
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
