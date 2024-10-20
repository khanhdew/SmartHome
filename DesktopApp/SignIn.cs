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
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        // Tạo sự kiện cho UserControl
        public event EventHandler SignUpClicked;
        public event EventHandler SignInClicked;

        protected virtual void OnSignUpClicked(EventArgs e)
        {
            SignUpClicked?.Invoke(this, e); // Kích hoạt sự kiện
        }

        protected virtual void OnSignInClicked(EventArgs e)
        {
            SignInClicked?.Invoke(this, e); // Kích hoạt sự kiện
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            OnSignUpClicked(EventArgs.Empty);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OnSignInClicked(EventArgs.Empty);
        }
    }
}
