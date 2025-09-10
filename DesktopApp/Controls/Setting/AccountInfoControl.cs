using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace DesktopApp.Controls.Setting
{
    public partial class AccountInfoControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;
        private readonly UserManager<User> userManager;
        public AccountInfoControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = _serviceProvider.GetRequiredService<IUserService>();
            userManager = _serviceProvider.GetRequiredService<UserManager<User>>();

        }

        private void AccountInfoControl_Load(object sender, EventArgs e)
        {
            var user = MainForm.LoggedInUser;
            txtUsername.Text = user.UserName;
            txtDisplayName.Text = user.DisplayName;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.LoggedInUser.DisplayName = txtDisplayName.Text;
                MainForm.LoggedInUser.Email = txtEmail.Text;
                MainForm.LoggedInUser.PhoneNumber = txtPhoneNumber.Text;
                var result = userManager.UpdateAsync(MainForm.LoggedInUser);
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                var currentPassword = txtCurrentPassword.Text;
                var newPassword = txtNewPassword.Text;
                var confirmPassword = txtConfirmPassword.Text;
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var result = userManager.ChangePasswordAsync(MainForm.LoggedInUser, currentPassword, newPassword);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
