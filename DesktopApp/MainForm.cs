using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
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
    public partial class MainForm : Form
    {
        Login loginControl = new Login();
        SignUp signUpControl = new SignUp();
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public MainForm(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }

        // Đăng nhập
        private void ShowLoginPanel()
        {
            Panel.Controls.Clear();

            // Hủy đăng ký sự kiện trước khi đăng ký lại
            loginControl.ClickForPassWord -= OnClickForPassWord;
            loginControl.Login_Click -= async (s, ev) => await BtnLogin_Click(s, ev);
            loginControl.Signup_Click -= LbSignup_Click;

            // Đăng ký sự kiện cho loginControl
            loginControl.ClickForPassWord += OnClickForPassWord;


            // Thiết lập thuộc tính Anchor và Dock để ngăn thay đổi kích thước
            loginControl.Anchor = AnchorStyles.None;
            loginControl.Dock = DockStyle.Fill;


            loginControl.Login_Click += async (s, ev) => await BtnLogin_Click(s, ev);
            loginControl.Signup_Click += LbSignup_Click;
            Panel.Controls.Add(loginControl);
        }

        // nút đăng kí
        private void LbSignup_Click(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }

        // nút quên mật khẩu
        private void OnClickForPassWord(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }

        // nút login 
        private async Task BtnLogin_Click(object sender, EventArgs e)
        {
            string username = loginControl.txtEmail.Text;
            string password = loginControl.txtPassword.Text;


            ShowDashBroadPanel();
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var result = await _userManager.CheckPasswordAsync(user, password);
                ShowDashBroadPanel();
                return;
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        // Đăng kí
        private void ShowSignInPanel()
        {
            Panel.Controls.Clear();
            // Hủy đăng ký sự kiện trước khi đăng ký lại
            signUpControl.SignInClicked -= OnSignUpClicked;
            signUpControl.SignUpClicked -= async (s, ev) => await BtnSignUp_Click(s, ev);

            // Đăng ký sự kiện cho signInControl
            signUpControl.SignInClicked += OnSignUpClicked;
            signUpControl.SignUpClicked += async (s, ev) => await BtnSignUp_Click(s, ev);
            // check if user is authenticated

            Panel.Controls.Add(signUpControl);
        }

        private void OnSignUpClicked(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }

        // nút đăng nhập
        private async Task BtnSignUp_Click(object sender, EventArgs e)
        {
            string username = signUpControl.txtDKEmail.Text;
            string password = signUpControl.txtDKPassword.Text;
            string repassword = signUpControl.txtDKLaiPassword.Text;
            // create user
            if (password == repassword)
            {
                var user = new User
                {
                    UserName = username,
                    Email = username
                };
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    ShowDashBroadPanel();
                    return;
                }
                else
                {
                    MessageBox.Show("Dang ki that bai");
                }
            }
            else
            {
                MessageBox.Show("Mat khau khong trung khop");
            }
        }

        // dashboard
        private void ShowDashBroadPanel()
        {
            Panel.Controls.Clear();
            DashBroad dashBroad = new DashBroad();
            dashBroad.Dock = DockStyle.Fill;
            Panel.Controls.Add(dashBroad);
        }

    }
}
