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
        public MainForm()
        {
            InitializeComponent();
            

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
            loginControl.Login_Click -= btnLogin;
            loginControl.Signup_Click -= btnSignup_Click;
            // Đăng ký sự kiện cho loginControl
            loginControl.ClickForPassWord += OnClickForPassWord;
            loginControl.Login_Click += btnLogin;
            loginControl.Signup_Click += btnSignup_Click;
            Panel.Controls.Add(loginControl);
       
        
         }
        // nút đăng kí
        private void btnSignup_Click(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }
        // nút quên mật khẩu
        private void OnClickForPassWord(object sender, EventArgs e)
        {
            ShowSignInPanel();
        }
        // nút login 
        private void btnLogin(object sender, EventArgs e)
        {
            string username = loginControl.txtEmail.Text;
            string password = loginControl.txtPassword.Text;

            MessageBox.Show("tài khoản mk vừa nhập là : "+ username + "\n "+password);
        }


        // Đăng kí

        private void ShowSignInPanel()
        {

            Panel.Controls.Clear();
            // Hủy đăng ký sự kiện trước khi đăng ký lại
            signInControl.SignInClicked -= OnSignInClicked;
            signInControl.SignUpClicked -= btnSignUp;

            // Đăng ký sự kiện cho signInControl
            signInControl.SignInClicked += OnSignInClicked;
            signInControl.SignUpClicked += btnSignUp;
            Panel.Controls.Add(signInControl);
            
        }
        private void OnSignInClicked(object sender, EventArgs e)
        {
            ShowLoginPanel();
        }
        // nút đăng nhập
        private void btnSignUp(object sender, EventArgs e)
        {
           
            string username = signInControl.txtDKEmail.Text;
            string password = signInControl.txtDKPassword.Text;
            string repassword = signInControl.txtDKLaiPassword.Text;
            MessageBox.Show("tài khoản mk vừa nhập là : " + username + "\n " + password + "\n " + repassword);
        }



    }
}
