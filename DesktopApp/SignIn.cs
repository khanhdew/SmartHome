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
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }
       
        // Tạo sự kiện cho UserControl
        public event EventHandler LinkClicked;

        protected virtual void OnLinkClicked(EventArgs e)
        {
            LinkClicked?.Invoke(this, e); // Kích hoạt sự kiện
        }

        private void LbSignIn_LinkClicked(object sender, EventArgs e)
        {
            OnLinkClicked(EventArgs.Empty);
        }
    }
}