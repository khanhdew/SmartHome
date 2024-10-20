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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            quenPassWord = new Krypton.Toolkit.KryptonLinkWrapLabel();
            btnSignup = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            SuspendLayout();
            // 

            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(79, 733);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(167, 19);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 62;
            kryptonLabel6.Values.Text = "Do not have an account?";
            // 
            // kryptonPanel1
            // 

            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(533, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(756, 685);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateNormal.Image = (Image)resources.GetObject("kryptonPanel1.StateNormal.Image");
            kryptonPanel1.TabIndex = 64;
            // 
            // kryptonLabel1
            // 

            kryptonLabel1.Location = new Point(220, 120);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(79, 31);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel1.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 65;
            kryptonLabel1.Values.Text = "Login";
            // 
            // kryptonLabel2
            // 

            kryptonLabel2.Location = new Point(84, 20);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(87, 24);
            kryptonLabel2.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel2.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel2.TabIndex = 66;
            kryptonLabel2.Values.Text = "User Name";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            txtEmail.Location = new Point(84, 50);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 44);
            txtEmail.StateCommon.Back.Color1 = Color.FromArgb(0, 29, 53);
            txtEmail.StateCommon.Border.Color1 = Color.FromArgb(0, 29, 53);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.Rounding = 3F;
            txtEmail.StateCommon.Content.Color1 = Color.White;
            txtEmail.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateNormal.Border.Rounding = 3F;
            txtEmail.StateNormal.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.TabIndex = 67;
            txtEmail.Text = "UserName (Email)";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(kryptonPictureBox1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Location = new Point(48, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 108);
            panel1.TabIndex = 68;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(84, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 1);
            panel2.TabIndex = 69;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.InitialImage = null;
            kryptonPictureBox1.Location = new Point(18, 46);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(56, 45);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 68;
            kryptonPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(kryptonPictureBox2);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(kryptonLabel3);
            panel3.Location = new Point(48, 305);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 108);
            panel3.TabIndex = 69;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(84, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(310, 1);
            panel4.TabIndex = 69;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Image = (Image)resources.GetObject("kryptonPictureBox2.Image");

            kryptonPictureBox2.InitialImage = null;
            kryptonPictureBox2.Location = new Point(18, 46);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(56, 45);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox2.TabIndex = 68;
            kryptonPictureBox2.TabStop = false;
            // 
            // txtPassword
            // 

            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            txtPassword.Location = new Point(84, 50);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(310, 44);
            txtPassword.StateCommon.Back.Color1 = Color.FromArgb(0, 29, 53);
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 29, 53);
            txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.Rounding = 3F;
            txtPassword.StateCommon.Content.Color1 = Color.White;
            txtPassword.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateNormal.Border.Rounding = 3F;
            txtPassword.StateNormal.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.TabIndex = 67;
            txtPassword.Text = "Password";

            kryptonLabel3.Location = new Point(84, 20);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(83, 24);
            kryptonLabel3.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel3.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel3.TabIndex = 66;
            kryptonLabel3.Values.Text = "Pass Word";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(93, 522);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 48);
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(255, 192, 192);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(255, 192, 192);
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Border.Rounding = 10F;
            btnLogin.StateNormal.Back.Color1 = Color.Red;
            btnLogin.StateNormal.Back.Color2 = Color.Red;
            btnLogin.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateNormal.Border.Rounding = 10F;
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.TabIndex = 70;
            btnLogin.Values.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(316, 448);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(6, 2);
            kryptonLabel4.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 71;
            kryptonLabel4.Values.Text = "";
            // 
            // quenPassWord
            // 
            quenPassWord.ActiveLinkColor = Color.White;
            quenPassWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            quenPassWord.ForeColor = Color.FromArgb(30, 57, 91);
            quenPassWord.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            quenPassWord.LinkColor = Color.White;
            quenPassWord.Location = new Point(289, 448);
            quenPassWord.Margin = new Padding(1);
            quenPassWord.Name = "quenPassWord";
            quenPassWord.Size = new Size(153, 20);
            quenPassWord.Text = "Forgot to Password?";
            quenPassWord.LinkClicked += quenPassWord_LinkClicked;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(270, 522);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(155, 48);
            btnSignup.StateCommon.Border.Color1 = Color.FromArgb(255, 192, 192);
            btnSignup.StateCommon.Border.Color2 = Color.FromArgb(255, 192, 192);
            btnSignup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSignup.StateCommon.Border.Rounding = 10F;
            btnSignup.StateNormal.Back.Color1 = Color.Red;
            btnSignup.StateNormal.Back.Color2 = Color.Red;
            btnSignup.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSignup.StateNormal.Border.Rounding = 10F;
            btnSignup.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSignup.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.TabIndex = 74;
            btnSignup.Values.Text = "Sign up";
            btnSignup.Click += btnSignup_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(0, 29, 53);
            Controls.Add(quenPassWord);
            Controls.Add(btnSignup);
            Controls.Add(kryptonLabel4);
            Controls.Add(btnLogin);

            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonLabel6);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "Login";
            Size = new Size(1289, 685);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Panel panel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Panel panel5;
        private Krypton.Toolkit.KryptonLinkWrapLabel quenPassWord;
        private Krypton.Toolkit.KryptonButton btnSignup;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox3;
        public Krypton.Toolkit.KryptonTextBox txtEmail;
        public Krypton.Toolkit.KryptonTextBox txtPassword;
    }
}
