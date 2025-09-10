using Services.Services;

namespace DesktopApp
{
    public partial class SignUp : UserControl
    {
        private readonly IUserService _userService;
        private readonly Login _login;
        public SignUp(IUserService userService, Login login)
        {
            _userService = userService;
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            _login = login;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent;
            if (parentForm != null)
            {
                var newUserControl = _login;
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
                var newUserControl = _login;
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
