using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.AdminUserControl
{
    public partial class NguoiDungControl : UserControl
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        IEnumerable<User> userList;
        private readonly UserManager<User> _userManager;

        private User selectedUser;
        public NguoiDungControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<IUserService>();
            userList = _userService.GetUsers();
            _userManager = _serviceProvider.GetRequiredService<UserManager<User>>();
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

                // Duyệt qua danh sách người dùng và thêm vào DataGridView
                foreach (var user in users)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);
                    string role = "";
                    foreach (var userRole in userRoles)
                    {
                        // Thêm dữ liệu vào DataGridView
                        role += userRole;
                        
                    }
                    dgvNguoiDung.Rows.Add(user.UserName, user.Email, user.DisplayName, user.PhoneNumber, role);
                
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
            dgvNguoiDung.Columns.Add("Roles", "Roles");
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

                var newUserControl = new UserEditControl(selectedUser, _serviceProvider);
                parent.Controls.Clear();
                parent.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;

            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private async void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
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
                selectedUser = await _userManager.FindByNameAsync(userName);
            }
        }

        private async void btnLoginasUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn chưa
                if (selectedUser == null)
                {
                    MessageBox.Show("Vui lòng chọn một người dùng trước khi đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tìm người dùng dựa trên ID
                var user = await _userManager.FindByIdAsync(selectedUser.Id);

                if (user == null)
                {
                    // Người dùng không tìm thấy, hiển thị thông báo lỗi
                    MessageBox.Show("Không tìm thấy người dùng với ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Đặt người dùng đã đăng nhập
                MainForm.LoggedInUser = user;

                // Hiển thị thông báo thành công
                MessageBox.Show("Đăng nhập thành công với người dùng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var newUserControl = _serviceProvider.GetRequiredService<DashBoard>();
                // Cập nhật tên người dùng hiển thị trên dashboard
                newUserControl.btnNameUser.Text = "Hello, " + user.UserName;

                // Kiểm tra vai trò người dùng
                var userRole = await _userManager.GetRolesAsync(user);
                if (userRole.Contains("Admin"))
                {
                    newUserControl.menuAdminPage.Visible = true;
                }
                else
                {
                    newUserControl.menuAdminPage.Visible = false;
                }
                var mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                {
                    // Xóa tất cả các điều khiển cũ trong panelMain
                    mainForm.Panel.Controls.Clear();
                    
                    // Thêm DashBoard mới vào panelMain
                    mainForm.Panel.Controls.Add(newUserControl);
                    newUserControl.Dock = DockStyle.Fill;
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy MainForm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
