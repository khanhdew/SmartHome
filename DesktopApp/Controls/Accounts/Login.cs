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

        
        public Login()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent ;
           
                var newUserControl = new SignUp(); 
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent ;
            
                var newUserControl = new DashBoard(); 
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;
          
        }
    }
}
