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
    public partial class SignUp : UserControl
    {
        private MainForm mainForm;
        public SignUp(MainForm form)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.mainForm = form;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            mainForm.Panel.Controls.Clear();
            Login login = new Login(mainForm);
            login.Dock = DockStyle.Fill;
            mainForm.Panel.Controls.Add(login);
        }
    }
}
