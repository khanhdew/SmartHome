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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseViewUserControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblTenNha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblThongtinNha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnXoaNha = new Guna.UI2.WinForms.Guna2Button();
            btnSuaNha = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSuaNha);
            guna2ShadowPanel1.Controls.Add(btnXoaNha);
            guna2ShadowPanel1.Controls.Add(lblThongtinNha);
            guna2ShadowPanel1.Controls.Add(lblTenNha);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(180, 140);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblTenNha
            // 
            lblTenNha.BackColor = Color.Transparent;
            lblTenNha.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNha.Location = new Point(30, 20);
            lblTenNha.Name = "lblTenNha";
            lblTenNha.Size = new Size(63, 27);
            lblTenNha.TabIndex = 0;
            lblTenNha.Text = "Nhà 1";
            // 
            // lblThongtinNha
            // 
            lblThongtinNha.BackColor = Color.Transparent;
            lblThongtinNha.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongtinNha.Location = new Point(30, 50);
            lblThongtinNha.Name = "lblThongtinNha";
            lblThongtinNha.Size = new Size(77, 24);
            lblThongtinNha.TabIndex = 1;
            lblThongtinNha.Text = "Thông tin";
            // 
            // btnXoaNha
            // 
            btnXoaNha.BorderRadius = 10;
            btnXoaNha.CustomizableEdges = customizableEdges5;
            btnXoaNha.DisabledState.BorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaNha.FillColor = Color.DeepSkyBlue;
            btnXoaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNha.ForeColor = Color.White;
            btnXoaNha.Image = (Image)resources.GetObject("btnXoaNha.Image");
            btnXoaNha.Location = new Point(100, 80);
            btnXoaNha.Name = "btnXoaNha";
            btnXoaNha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnXoaNha.Size = new Size(46, 38);
            btnXoaNha.TabIndex = 2;
            // 
            // btnSuaNha
            // 
            btnSuaNha.BorderRadius = 10;
            btnSuaNha.CustomizableEdges = customizableEdges7;
            btnSuaNha.DisabledState.BorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuaNha.FillColor = Color.DeepSkyBlue;
            btnSuaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNha.ForeColor = Color.White;
            btnSuaNha.Image = (Image)resources.GetObject("btnSuaNha.Image");
            btnSuaNha.Location = new Point(30, 80);
            btnSuaNha.Name = "btnSuaNha";
            btnSuaNha.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSuaNha.Size = new Size(46, 38);
            btnSuaNha.TabIndex = 3;
            // 
            // HouseViewUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2ShadowPanel1);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "HouseViewUserControl";
            Size = new Size(180, 140);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThongtinNha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNha;
        private Guna.UI2.WinForms.Guna2Button btnXoaNha;
        private Guna.UI2.WinForms.Guna2Button btnSuaNha;
    }
}
