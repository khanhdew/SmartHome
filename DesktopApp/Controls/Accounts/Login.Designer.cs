namespace DesktopApp
{
    partial class Login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblSignup = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            lblQuenPass = new Label();
            label1 = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            checkLogin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Rotate;
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            guna2Transition1.DefaultAnimation = animation1;
            guna2Transition1.Interval = 5;
            guna2Transition1.MaxAnimationTime = 1000;
            guna2Transition1.TimeStep = 0.01F;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(0, 118, 212);
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.Controls.Add(lblSignup);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(lblQuenPass);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnLogin);
            guna2Panel1.Controls.Add(checkLogin);
            guna2Panel1.Controls.Add(txtPassword);
            guna2Panel1.Controls.Add(txtUsername);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Transition1.SetDecoration(guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.ForeColor = Color.Teal;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(941, 452);
            guna2Panel1.TabIndex = 0;
            // 
            // lblSignup
            // 
            lblSignup.Anchor = AnchorStyles.None;
            lblSignup.BackColor = Color.Transparent;
            lblSignup.BorderRadius = 10;
            lblSignup.CustomizableEdges = customizableEdges1;
            guna2Transition1.SetDecoration(lblSignup, Guna.UI2.AnimatorNS.DecorationType.None);
            lblSignup.DisabledState.BorderColor = Color.DarkGray;
            lblSignup.DisabledState.CustomBorderColor = Color.DarkGray;
            lblSignup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblSignup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblSignup.FillColor = Color.Transparent;
            lblSignup.FocusedColor = Color.Red;
            lblSignup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignup.ForeColor = Color.White;
            lblSignup.Image = (Image)resources.GetObject("lblSignup.Image");
            lblSignup.ImageAlign = HorizontalAlignment.Right;
            lblSignup.ImageSize = new Size(40, 40);
            lblSignup.Location = new Point(357, 373);
            lblSignup.Margin = new Padding(3, 2, 3, 2);
            lblSignup.Name = "lblSignup";
            lblSignup.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lblSignup.Size = new Size(204, 36);
            lblSignup.TabIndex = 32;
            lblSignup.Text = "Create Account";
            lblSignup.Click += lblSignup_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            guna2Transition1.SetDecoration(label3, Guna.UI2.AnimatorNS.DecorationType.None);
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(397, 44);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 31;
            label3.Text = "User Login";
            // 
            // lblQuenPass
            // 
            lblQuenPass.Anchor = AnchorStyles.None;
            lblQuenPass.AutoSize = true;
            lblQuenPass.BackColor = Color.Transparent;
            guna2Transition1.SetDecoration(lblQuenPass, Guna.UI2.AnimatorNS.DecorationType.None);
            lblQuenPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuenPass.ForeColor = Color.White;
            lblQuenPass.Location = new Point(357, 340);
            lblQuenPass.Name = "lblQuenPass";
            lblQuenPass.Size = new Size(232, 20);
            lblQuenPass.TabIndex = 30;
            lblQuenPass.Text = "Forgot Username or password ?";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(410, 236);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 29;
            label1.Text = "Remember me";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderRadius = 20;
            btnLogin.CustomizableEdges = customizableEdges3;
            guna2Transition1.SetDecoration(btnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.White;
            btnLogin.FillColor2 = Color.White;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(0, 118, 212);
            btnLogin.Location = new Point(340, 277);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(260, 42);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "LOGIN";
            // 
            // checkLogin
            // 
            checkLogin.Anchor = AnchorStyles.None;
            checkLogin.BackColor = Color.Transparent;
            checkLogin.CheckedState.BorderColor = Color.White;
            checkLogin.CheckedState.FillColor = Color.White;
            checkLogin.CheckedState.InnerBorderColor = Color.FromArgb(0, 118, 212);
            checkLogin.CheckedState.InnerColor = Color.FromArgb(0, 118, 212);
            checkLogin.CustomizableEdges = customizableEdges5;
            guna2Transition1.SetDecoration(checkLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            checkLogin.Location = new Point(343, 236);
            checkLogin.Margin = new Padding(3, 2, 3, 2);
            checkLogin.Name = "checkLogin";
            checkLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            checkLogin.Size = new Size(38, 19);
            checkLogin.TabIndex = 27;
            checkLogin.UncheckedState.BorderColor = Color.White;
            checkLogin.UncheckedState.FillColor = Color.Silver;
            checkLogin.UncheckedState.InnerBorderColor = Color.FromArgb(0, 118, 212);
            checkLogin.UncheckedState.InnerColor = Color.FromArgb(0, 118, 212);
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderColor = Color.Transparent;
            txtPassword.BorderRadius = 8;
            txtPassword.BorderThickness = 0;
            txtPassword.CustomizableEdges = customizableEdges7;
            guna2Transition1.SetDecoration(txtPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            txtPassword.DefaultText = "123456";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(0, 118, 212);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(25, 25);
            txtPassword.Location = new Point(322, 170);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.FromArgb(0, 118, 212);
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(292, 41);
            txtPassword.TabIndex = 26;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderColor = Color.Transparent;
            txtUsername.BorderRadius = 8;
            txtUsername.BorderThickness = 0;
            txtUsername.CustomizableEdges = customizableEdges9;
            guna2Transition1.SetDecoration(txtUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            txtUsername.DefaultText = "khanh@gmail.com";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(0, 118, 212);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.IconLeftSize = new Size(25, 25);
            txtUsername.Location = new Point(322, 105);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.FromArgb(0, 118, 212);
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtUsername.Size = new Size(292, 41);
            txtUsername.TabIndex = 25;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(guna2Panel1);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Size = new Size(941, 452);
            Load += Login_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button lblSignup;
        private Label label3;
        private Label lblQuenPass;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch checkLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}
