﻿using System;
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
       
        public SignUp()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            var parentForm = this.Parent ;
            if (parentForm != null)
            {
                var newUserControl = new Login(); 
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newUserControl);
                newUserControl.Dock = DockStyle.Fill;
            }
        }
    }
}
