namespace DesktopApp.Controls.Rooms
{
    partial class RoomViewUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomViewUserControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblThongtinPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTenPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSuaNha = new Guna.UI2.WinForms.Guna2Button();
            btnXoaNha = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnXoaNha);
            guna2ShadowPanel1.Controls.Add(btnSuaNha);
            guna2ShadowPanel1.Controls.Add(lblThongtinPhong);
            guna2ShadowPanel1.Controls.Add(lblTenPhong);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(268, 170);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // lblThongtinPhong
            // 
            lblThongtinPhong.BackColor = Color.Transparent;
            lblThongtinPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongtinPhong.Location = new Point(26, 54);
            lblThongtinPhong.Name = "lblThongtinPhong";
            lblThongtinPhong.Size = new Size(87, 30);
            lblThongtinPhong.TabIndex = 5;
            lblThongtinPhong.Text = "Thông tin";
            // 
            // lblTenPhong
            // 
            lblTenPhong.BackColor = Color.Transparent;
            lblTenPhong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenPhong.Location = new Point(26, 24);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(92, 33);
            lblTenPhong.TabIndex = 4;
            lblTenPhong.Text = "Phòng 1";
            // 
            // btnSuaNha
            // 
            btnSuaNha.BorderRadius = 10;
            btnSuaNha.CustomizableEdges = customizableEdges3;
            btnSuaNha.DisabledState.BorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuaNha.FillColor = Color.FromArgb(60, 145, 230);
            btnSuaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaNha.ForeColor = Color.White;
            btnSuaNha.Image = (Image)resources.GetObject("btnSuaNha.Image");
            btnSuaNha.Location = new Point(26, 107);
            btnSuaNha.Name = "btnSuaNha";
            btnSuaNha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSuaNha.Size = new Size(46, 38);
            btnSuaNha.TabIndex = 8;
            // 
            // btnXoaNha
            // 
            btnXoaNha.BorderRadius = 10;
            btnXoaNha.CustomizableEdges = customizableEdges1;
            btnXoaNha.DisabledState.BorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaNha.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaNha.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaNha.FillColor = Color.FromArgb(219, 80, 74);
            btnXoaNha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNha.ForeColor = Color.White;
            btnXoaNha.Image = (Image)resources.GetObject("btnXoaNha.Image");
            btnXoaNha.Location = new Point(86, 107);
            btnXoaNha.Name = "btnXoaNha";
            btnXoaNha.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXoaNha.Size = new Size(46, 38);
            btnXoaNha.TabIndex = 9;
            // 
            // RoomViewUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "RoomViewUserControl";
            Size = new Size(268, 170);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThongtinPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhong;
        public Guna.UI2.WinForms.Guna2Button btnSuaNha;
        private Guna.UI2.WinForms.Guna2Button btnXoaNha;
    }
}
