namespace DesktopApp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            btnSignIn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            panel4 = new Panel();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            txtDKPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            txtDKEmail = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnSignup = new Krypton.Toolkit.KryptonButton();
            panel5 = new Panel();
            panel6 = new Panel();
            kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            txtDKLaiPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(100, 563);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(155, 48);
            btnSignIn.StateCommon.Border.Color1 = Color.FromArgb(255, 192, 192);
            btnSignIn.StateCommon.Border.Color2 = Color.FromArgb(255, 192, 192);
            btnSignIn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSignIn.StateCommon.Border.Rounding = 10F;
            btnSignIn.StateNormal.Back.Color1 = Color.Red;
            btnSignIn.StateNormal.Back.Color2 = Color.Red;
            btnSignIn.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSignIn.StateNormal.Border.Rounding = 10F;
            btnSignIn.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSignIn.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.TabIndex = 83;
            btnSignIn.Values.Text = "Sign In";
            btnSignIn.Click += btnSignIn_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(321, 417);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(6, 2);
            kryptonLabel4.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 82;
            kryptonLabel4.Values.Text = "";
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
            // txtDKPassword
            // 
            txtDKPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDKPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            txtDKPassword.Location = new Point(84, 50);
            txtDKPassword.Multiline = true;
            txtDKPassword.Name = "txtDKPassword";
            txtDKPassword.PasswordChar = '*';
            txtDKPassword.Size = new Size(310, 41);
            txtDKPassword.StateCommon.Back.Color1 = Color.FromArgb(0, 29, 53);
            txtDKPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 29, 53);
            txtDKPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKPassword.StateCommon.Border.Rounding = 3F;
            txtDKPassword.StateCommon.Content.Color1 = Color.White;
            txtDKPassword.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKPassword.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKPassword.StateNormal.Border.Rounding = 3F;
            txtDKPassword.StateNormal.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKPassword.TabIndex = 67;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(84, 20);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(98, 24);
            kryptonLabel3.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel3.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 66;
            kryptonLabel3.Values.Text = "Pass Word";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(kryptonPictureBox2);
            panel3.Controls.Add(txtDKPassword);
            panel3.Controls.Add(kryptonLabel3);
            panel3.Location = new Point(53, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 108);
            panel3.TabIndex = 80;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(84, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 1);
            panel2.TabIndex = 69;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(kryptonPictureBox1);
            panel1.Controls.Add(txtDKEmail);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Location = new Point(53, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 108);
            panel1.TabIndex = 79;
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
            // txtDKEmail
            // 
            txtDKEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDKEmail.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            txtDKEmail.Location = new Point(84, 50);
            txtDKEmail.Multiline = true;
            txtDKEmail.Name = "txtDKEmail";
            txtDKEmail.Size = new Size(310, 44);
            txtDKEmail.StateCommon.Back.Color1 = Color.FromArgb(0, 29, 53);
            txtDKEmail.StateCommon.Border.Color1 = Color.FromArgb(0, 29, 53);
            txtDKEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKEmail.StateCommon.Border.Rounding = 3F;
            txtDKEmail.StateCommon.Content.Color1 = Color.White;
            txtDKEmail.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKEmail.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKEmail.StateNormal.Border.Rounding = 3F;
            txtDKEmail.StateNormal.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKEmail.TabIndex = 67;
            txtDKEmail.Text = "(Email)";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(84, 20);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(101, 24);
            kryptonLabel2.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel2.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 66;
            kryptonLabel2.Values.Text = "User Name";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(234, 87);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(104, 31);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel1.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 78;
            kryptonLabel1.Values.Text = "Đăng Kí";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(55, 697);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(207, 24);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 76;
            kryptonLabel6.Values.Text = "Do not have an account?";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(561, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(728, 685);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateNormal.Image = (Image)resources.GetObject("kryptonPanel1.StateNormal.Image");
            kryptonPanel1.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonPanel1.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonPanel1.TabIndex = 77;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(279, 563);
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
            btnSignup.TabIndex = 85;
            btnSignup.Values.Text = "Sign up";
            btnSignup.Click += btnSignup_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(kryptonPictureBox3);
            panel5.Controls.Add(txtDKLaiPassword);
            panel5.Controls.Add(kryptonLabel5);
            panel5.Location = new Point(53, 398);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 108);
            panel5.TabIndex = 86;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(84, 93);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 1);
            panel6.TabIndex = 69;
            // 
            // kryptonPictureBox3
            // 
            kryptonPictureBox3.Image = (Image)resources.GetObject("kryptonPictureBox3.Image");
            kryptonPictureBox3.InitialImage = null;
            kryptonPictureBox3.Location = new Point(18, 46);
            kryptonPictureBox3.Name = "kryptonPictureBox3";
            kryptonPictureBox3.Size = new Size(56, 45);
            kryptonPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox3.TabIndex = 68;
            kryptonPictureBox3.TabStop = false;
            // 
            // txtDKLaiPassword
            // 
            txtDKLaiPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDKLaiPassword.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            txtDKLaiPassword.Location = new Point(84, 50);
            txtDKLaiPassword.Multiline = true;
            txtDKLaiPassword.Name = "txtDKLaiPassword";
            txtDKLaiPassword.PasswordChar = '*';
            txtDKLaiPassword.Size = new Size(322, 41);
            txtDKLaiPassword.StateCommon.Back.Color1 = Color.FromArgb(0, 29, 53);
            txtDKLaiPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 29, 53);
            txtDKLaiPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKLaiPassword.StateCommon.Border.Rounding = 3F;
            txtDKLaiPassword.StateCommon.Content.Color1 = Color.White;
            txtDKLaiPassword.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKLaiPassword.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDKLaiPassword.StateNormal.Border.Rounding = 3F;
            txtDKLaiPassword.StateNormal.Content.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDKLaiPassword.TabIndex = 67;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(84, 20);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(187, 24);
            kryptonLabel5.StateNormal.ShortText.Color1 = Color.White;
            kryptonLabel5.StateNormal.ShortText.Color2 = Color.White;
            kryptonLabel5.StateNormal.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 66;
            kryptonLabel5.Values.Text = "Reapet your password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 29, 53);
            Controls.Add(panel5);
            Controls.Add(btnSignup);
            Controls.Add(btnSignIn);
            Controls.Add(kryptonLabel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonPanel1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SignUp";
            Size = new Size(1289, 685);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSignIn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Panel panel4;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnSignup;
        private Panel panel5;
        private Panel panel6;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public Krypton.Toolkit.KryptonTextBox txtDKPassword;
        public Krypton.Toolkit.KryptonTextBox txtDKEmail;
        public Krypton.Toolkit.KryptonTextBox txtDKLaiPassword;
    }
}
