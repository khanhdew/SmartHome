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
    public partial class Login : UserControl
    {

        private MainForm mainForm;
        public Login(MainForm form)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.mainForm = form;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            mainForm.Panel.Controls.Clear();
            SignUp signUp = new SignUp(mainForm);
            signUp.Dock = DockStyle.Fill;
            mainForm.Panel.Controls.Add(signUp);
        }
    }
}
