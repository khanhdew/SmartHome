namespace DesktopApp.Controls.Houses
{
    partial class HouseViewUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseViewUserControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnSuaNha = new Guna.UI2.WinForms.Guna2Button();
            btnXoaNha = new Guna.UI2.WinForms.Guna2Button();
            lblThongtinNha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTenNha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoSize = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSuaNha);
            guna2ShadowPanel1.Controls.Add(btnXoaNha);
            guna2ShadowPanel1.Controls.Add(lblThongtinNha);
            guna2ShadowPanel1.Controls.Add(lblTenNha);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Margin = new Padding(20);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Gray;
            guna2ShadowPanel1.Size = new Size(268, 170);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnSuaNha
            // 
            btnSuaNha.BorderRadius = 10;
            btnSuaNha.CustomizableEdges = customizableEdges1;
            btnSuaNha.DisabledState.BorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuaNha.FillColor = Color.FromArgb(0, 118, 212);
            btnSuaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNha.ForeColor = Color.White;
            btnSuaNha.Image = (Image)resources.GetObject("btnSuaNha.Image");
            btnSuaNha.Location = new Point(26, 107);
            btnSuaNha.Name = "btnSuaNha";
            btnSuaNha.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSuaNha.Size = new Size(46, 38);
            btnSuaNha.TabIndex = 3;
            // 
            // btnXoaNha
            // 
            btnXoaNha.BorderRadius = 10;
            btnXoaNha.CustomizableEdges = customizableEdges3;
            btnXoaNha.DisabledState.BorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaNha.FillColor = Color.Red;
            btnXoaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNha.ForeColor = Color.White;
            btnXoaNha.Image = (Image)resources.GetObject("btnXoaNha.Image");
            btnXoaNha.Location = new Point(87, 107);
            btnXoaNha.Name = "btnXoaNha";
            btnXoaNha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoaNha.Size = new Size(46, 38);
            btnXoaNha.TabIndex = 2;
            btnXoaNha.Click += btnXoaNha_Click;
            // 
            // lblThongtinNha
            // 
            lblThongtinNha.BackColor = Color.Transparent;
            lblThongtinNha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongtinNha.Location = new Point(26, 54);
            lblThongtinNha.Name = "lblThongtinNha";
            lblThongtinNha.Size = new Size(69, 23);
            lblThongtinNha.TabIndex = 1;
            lblThongtinNha.Text = "Thông tin";
            // 
            // lblTenNha
            // 
            lblTenNha.BackColor = Color.Transparent;
            lblTenNha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNha.Location = new Point(26, 24);
            lblTenNha.Name = "lblTenNha";
            lblTenNha.Size = new Size(55, 27);
            lblTenNha.TabIndex = 0;
            lblTenNha.Text = "Nhà 1";
            // 
            // HouseViewUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2ShadowPanel1);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "HouseViewUserControl";
            Size = new Size(268, 170);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXoaNha;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTenNha;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblThongtinNha;
        public Guna.UI2.WinForms.Guna2Button btnSuaNha;
    }
}
