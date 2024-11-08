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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public event EventHandler? ClickForPassWord;
        public event EventHandler? Login_Click;
        public event EventHandler? Signup_Click;
        private void OnLinkClicked(EventArgs e)
        {
            ClickForPassWord?.Invoke(this, e);
        }

        private void OnLoginClicked(EventArgs e)
        {
            Login_Click?.Invoke(this, e);
        }

        private void OnSignupClicked(EventArgs e)
        {
            Signup_Click?.Invoke(this, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnLoginClicked(EventArgs.Empty);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            OnSignupClicked(EventArgs.Empty);
        }

        private void quenPassWord_LinkClicked(object sender, EventArgs e)
        {
            OnLinkClicked(EventArgs.Empty);
        }

        }
    }

