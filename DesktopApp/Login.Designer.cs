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
            txtDNPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            progressBarLoading = new Krypton.Toolkit.KryptonProgressBar();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            lblinkSignup = new Krypton.Toolkit.KryptonLinkLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            lbQuenMK = new Krypton.Toolkit.KryptonWrapLabel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            txtDNEmail = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtDNPassword
            // 
            txtDNPassword.Location = new Point(141, 468);
            txtDNPassword.Name = "txtDNPassword";
            txtDNPassword.PasswordChar = '*';
            txtDNPassword.Size = new Size(419, 27);
            txtDNPassword.TabIndex = 67;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(141, 425);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(95, 24);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 66;
            kryptonLabel4.Values.Text = "Password";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(141, 329);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(155, 24);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 65;
            kryptonLabel5.Values.Text = "UserName(email)";
            // 
            // progressBarLoading
            // 
            progressBarLoading.Location = new Point(0, 193);
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(673, 10);
            progressBarLoading.StateCommon.Back.Color1 = Color.Green;
            progressBarLoading.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBarLoading.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBarLoading.TabIndex = 64;
            progressBarLoading.Values.Text = "";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(20, 283);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(617, 1);
            kryptonBorderEdge1.Text = "OR";
            // 
            // lblinkSignup
            // 
            lblinkSignup.Location = new Point(240, 689);
            lblinkSignup.Name = "lblinkSignup";
            lblinkSignup.OverrideVisited.ShortText.Color1 = Color.White;
            lblinkSignup.Size = new Size(65, 24);
            lblinkSignup.StateNormal.ShortText.Color1 = Color.Turquoise;
            lblinkSignup.StateNormal.ShortText.Color2 = Color.White;
            lblinkSignup.TabIndex = 63;
            lblinkSignup.Values.Text = "Sign Up";
            lblinkSignup.LinkClicked += lblinkSignup_LinkClicked;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(41, 689);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(207, 24);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 62;
            kryptonLabel6.Values.Text = "Do not have an account?";
            // 
            // lbQuenMK
            // 
            lbQuenMK.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuenMK.ForeColor = Color.White;
            lbQuenMK.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            lbQuenMK.Location = new Point(404, 539);
            lbQuenMK.Name = "lbQuenMK";
            lbQuenMK.Size = new Size(155, 19);
            lbQuenMK.StateCommon.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuenMK.StateCommon.TextColor = Color.White;
            lbQuenMK.Text = "Forgot Password?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(67, 604);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(522, 36);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 0);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(255, 128, 0);
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(192, 255, 192);
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.TabIndex = 61;
            btnLogin.Values.ImageTransparentColor = Color.White;
            btnLogin.Values.Text = "Login";
            // 
            // txtDNEmail
            // 
            txtDNEmail.Location = new Point(140, 374);
            txtDNEmail.Name = "txtDNEmail";
            txtDNEmail.Size = new Size(419, 27);
            txtDNEmail.TabIndex = 60;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.ErrorImage = null;
            kryptonPictureBox2.Image = (Image)resources.GetObject("kryptonPictureBox2.Image");
            kryptonPictureBox2.Location = new Point(20, 31);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Size = new Size(617, 130);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox2.TabIndex = 57;
            kryptonPictureBox2.TabStop = false;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(79, 460);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(45, 35);
            kryptonLabel7.TabIndex = 59;
            kryptonLabel7.Values.Image = (Image)resources.GetObject("kryptonLabel7.Values.Image");
            kryptonLabel7.Values.Text = "\r\n";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(79, 374);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(39, 35);
            kryptonLabel8.TabIndex = 58;
            kryptonLabel8.Values.Image = (Image)resources.GetObject("kryptonLabel8.Values.Image");
            kryptonLabel8.Values.ImageTransparentColor = Color.White;
            kryptonLabel8.Values.Text = "";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(txtDNPassword);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel5);
            Controls.Add(progressBarLoading);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(lblinkSignup);
            Controls.Add(kryptonLabel6);
            Controls.Add(lbQuenMK);
            Controls.Add(btnLogin);
            Controls.Add(txtDNEmail);
            Controls.Add(kryptonPictureBox2);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel8);
            Name = "Login";
            Size = new Size(676, 789);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtDNPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonProgressBar progressBarLoading;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonLinkLabel lblinkSignup;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonWrapLabel lbQuenMK;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonMaskedTextBox txtDNEmail;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}
