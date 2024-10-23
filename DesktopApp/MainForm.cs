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
        SignIn signInControl = new SignIn();
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
            loginControl.Signup_Click -= BtnSignup_Click;

            // Đăng ký sự kiện cho loginControl
            loginControl.ClickForPassWord += OnClickForPassWord;


            // Thiết lập thuộc tính Anchor và Dock để ngăn thay đổi kích thước
            loginControl.Anchor = AnchorStyles.None;
            loginControl.Dock = DockStyle.Fill;


            loginControl.Login_Click += async (s, ev) => await BtnLogin_Click(s, ev);
            loginControl.Signup_Click += BtnSignup_Click;
            Panel.Controls.Add(loginControl);
        }

        // nút đăng kí
        private void BtnSignup_Click(object sender, EventArgs e)
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
                MessageBox.Show("Dang nhap " + result );
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
            signInControl.SignInClicked -= OnSignInClicked;
            signInControl.SignUpClicked -= async (s, ev) => await BtnSignUp_Click(s, ev);

            // Đăng ký sự kiện cho signInControl
            signInControl.SignInClicked += OnSignInClicked;
            signInControl.SignUpClicked += async (s, ev) => await BtnSignUp_Click(s, ev);
            // check if user is authenticated

            Panel.Controls.Add(signInControl);
        }

        private void OnSignInClicked(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }

        // nút đăng nhập
        private async Task BtnSignUp_Click(object sender, EventArgs e)
        {
            string username = signInControl.txtDKEmail.Text;
            string password = signInControl.txtDKPassword.Text;
            string repassword = signInControl.txtDKLaiPassword.Text;
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
                    MessageBox.Show("Dang ki thanh cong");
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
