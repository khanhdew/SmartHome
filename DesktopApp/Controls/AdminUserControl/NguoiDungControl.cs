using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
    public partial class NguoiDungControl : UserControl
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        IEnumerable<User> userList;
        private readonly RoleManager<IdentityRole> _roleManager;

        private User selectedUser;
        public NguoiDungControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<IUserService>();
            userList = _userService.GetUsers();
            _roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        }


        private void NguoiDungControl_Load(object sender, EventArgs e)
        {

            LoadUsersToDataGridView(userList);
        }
        private async void LoadUsersToDataGridView(IEnumerable<User> users)
        {
            try
            {

                SetupDataGridView();
                // Xóa hết dữ liệu cũ trong DataGridView
                dgvNguoiDung.Rows.Clear();

                // Duyệt qua danh sách người dùng và thêm vào DataGridView
                foreach (var user in users)
                {
                    // Thêm dữ liệu vào DataGridView
                    dgvNguoiDung.Rows.Add(user.UserName, user.Email,user.DisplayName , user.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SetupDataGridView()
        {
            // Xóa các cột cũ nếu có
            dgvNguoiDung.Columns.Clear();

            dgvNguoiDung.Columns.Add("UserName", "Username");
            dgvNguoiDung.Columns.Add("Email", "Email");
            dgvNguoiDung.Columns.Add("DisplayName", "Display Name");
            dgvNguoiDung.Columns.Add("PhoneNumber", "Phone Number");

            // Đặt các thuộc tính khác nếu cần
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SearchUser(string s)
        {
            var users = _userService.GetUsers();

            // Lọc người dùng theo từ khóa tìm kiếm, kiểm tra null cho mỗi thuộc tính
            var filteredUsers = users.Where(user =>
                (user.UserName != null && user.UserName.ToLower().Contains(s)) ||
                (user.PhoneNumber != null && user.PhoneNumber.Contains(s)) ||
                (user.Email != null && user.Email.ToLower().Contains(s))
            ).ToList();

            LoadUsersToDataGridView(filteredUsers);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                // Kiểm tra Parent
                var parent = this.Parent;
                
                var newUserControl = new UserEditControl(selectedUser, _serviceProvider );
                parent.Controls.Clear();
                parent.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;

            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có chọn một dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã chọn
                var userNameCell = dgvNguoiDung.Rows[e.RowIndex].Cells["UserName"];
                var emailCell = dgvNguoiDung.Rows[e.RowIndex].Cells["Email"];
                var phoneNumberCell = dgvNguoiDung.Rows[e.RowIndex].Cells["PhoneNumber"];
                var displayNameCell = dgvNguoiDung.Rows[e.RowIndex].Cells["DisplayName"];

                // Kiểm tra null trước khi truy cập giá trị
                var userName = userNameCell?.Value?.ToString();
                var email = emailCell?.Value?.ToString();
                var phoneNumber = phoneNumberCell?.Value?.ToString();
                var displayName = displayNameCell?.Value?.ToString();

                // Lưu thông tin để sử dụng khi chuyển đến UserControl mới
                selectedUser = new User
                {
                    UserName = userName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    DisplayName = displayName,
                };
            }
        }
    }
}
