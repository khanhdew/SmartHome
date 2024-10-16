namespace DesktopApp
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            lbSignin = new Krypton.Toolkit.KryptonLinkLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            checkAccept2 = new Krypton.Toolkit.KryptonCheckBox();
            checkAccept1 = new Krypton.Toolkit.KryptonCheckBox();
            txtDKpassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtDKEmail = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtLastName = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtFirstName = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            txtDKlaipass = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSignin
            // 
            lbSignin.Location = new Point(273, 707);
            lbSignin.Name = "lbSignin";
            lbSignin.OverrideVisited.ShortText.Color1 = Color.White;
            lbSignin.Size = new Size(58, 24);
            lbSignin.StateNormal.ShortText.Color1 = Color.Turquoise;
            lbSignin.StateNormal.ShortText.Color2 = Color.White;
            lbSignin.TabIndex = 37;
            lbSignin.Values.Text = "Sign In";
            lbSignin.Click += LbSignIn_LinkClicked;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(49, 707);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(215, 24);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 36;
            kryptonLabel1.Values.Text = "Already have an account?";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(49, 632);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(587, 34);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonButton1.TabIndex = 35;
            kryptonButton1.Values.ImageTransparentColor = Color.White;
            kryptonButton1.Values.Text = "Sign up";
            // 
            // checkAccept2
            // 
            checkAccept2.Location = new Point(122, 555);
            checkAccept2.Name = "checkAccept2";
            checkAccept2.Size = new Size(169, 21);
            checkAccept2.StateCommon.ShortText.Color1 = Color.White;
            checkAccept2.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkAccept2.TabIndex = 34;
            checkAccept2.Values.Text = "Accept Terms of Use";
            // 
            // checkAccept1
            // 
            checkAccept1.Location = new Point(122, 521);
            checkAccept1.Name = "checkAccept1";
            checkAccept1.Size = new Size(172, 21);
            checkAccept1.StateCommon.ShortText.Color1 = Color.White;
            checkAccept1.StateCommon.ShortText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkAccept1.TabIndex = 33;
            checkAccept1.Values.Text = "Accept Privacy Policy";
            // 
            // txtDKpassword
            // 
            txtDKpassword.Location = new Point(122, 408);
            txtDKpassword.Name = "txtDKpassword";
            txtDKpassword.PasswordChar = '*';
            txtDKpassword.Size = new Size(471, 27);
            txtDKpassword.TabIndex = 32;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(53, 401);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(45, 35);
            kryptonLabel2.TabIndex = 31;
            kryptonLabel2.Values.Image = (Image)resources.GetObject("kryptonLabel2.Values.Image");
            kryptonLabel2.Values.Text = "\r\n";
            // 
            // txtDKEmail
            // 
            txtDKEmail.Location = new Point(122, 356);
            txtDKEmail.Name = "txtDKEmail";
            txtDKEmail.Size = new Size(471, 27);
            txtDKEmail.TabIndex = 30;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(53, 356);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(39, 35);
            kryptonLabel3.TabIndex = 29;
            kryptonLabel3.Values.Image = (Image)resources.GetObject("kryptonLabel3.Values.Image");
            kryptonLabel3.Values.ImageTransparentColor = Color.White;
            kryptonLabel3.Values.Text = "";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(381, 305);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(213, 27);
            txtLastName.TabIndex = 28;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(122, 305);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 27);
            txtFirstName.TabIndex = 27;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(381, 269);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(108, 24);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel10.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 26;
            kryptonLabel10.Values.Text = "Last Name*\r\n";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(122, 269);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(109, 24);
            kryptonLabel11.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel11.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 25;
            kryptonLabel11.Values.Text = "First Name*\r\n";
            // 
            // txtDKlaipass
            // 
            txtDKlaipass.Location = new Point(122, 462);
            txtDKlaipass.Name = "txtDKlaipass";
            txtDKlaipass.PasswordChar = '*';
            txtDKlaipass.Size = new Size(471, 27);
            txtDKlaipass.TabIndex = 24;
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(53, 454);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(45, 35);
            kryptonLabel12.TabIndex = 23;
            kryptonLabel12.Values.Image = (Image)resources.GetObject("kryptonLabel12.Values.Image");
            kryptonLabel12.Values.Text = "\r\n";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.ErrorImage = null;
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(20, 54);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(641, 124);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 22;
            kryptonPictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(lbSignin);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonButton1);
            Controls.Add(checkAccept2);
            Controls.Add(checkAccept1);
            Controls.Add(txtDKpassword);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtDKEmail);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel11);
            Controls.Add(txtDKlaipass);
            Controls.Add(kryptonLabel12);
            Controls.Add(kryptonPictureBox1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SignIn";
            Size = new Size(693, 789);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLinkLabel lbSignin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCheckBox checkAccept2;
        private Krypton.Toolkit.KryptonCheckBox checkAccept1;
        private Krypton.Toolkit.KryptonTextBox txtDKpassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDKEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonMaskedTextBox txtLastName;
        private Krypton.Toolkit.KryptonMaskedTextBox txtFirstName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonTextBox txtDKlaipass;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}
