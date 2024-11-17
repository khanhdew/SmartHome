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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomViewUserControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnSuaPhong = new Guna.UI2.WinForms.Guna2Button();
            btnXoaPhong = new Guna.UI2.WinForms.Guna2Button();
            lblThongtinPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTenPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSuaPhong);
            guna2ShadowPanel1.Controls.Add(btnXoaPhong);
            guna2ShadowPanel1.Controls.Add(lblThongtinPhong);
            guna2ShadowPanel1.Controls.Add(lblTenPhong);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(158, 105);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BorderRadius = 10;
            btnSuaPhong.CustomizableEdges = customizableEdges1;
            btnSuaPhong.DisabledState.BorderColor = Color.DarkGray;
            btnSuaPhong.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuaPhong.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuaPhong.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuaPhong.FillColor = Color.DeepSkyBlue;
            btnSuaPhong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaPhong.ForeColor = Color.White;
            btnSuaPhong.Image = (Image)resources.GetObject("btnSuaPhong.Image");
            btnSuaPhong.Location = new Point(26, 60);
            btnSuaPhong.Margin = new Padding(3, 2, 3, 2);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSuaPhong.Size = new Size(40, 28);
            btnSuaPhong.TabIndex = 7;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.BorderRadius = 10;
            btnXoaPhong.CustomizableEdges = customizableEdges3;
            btnXoaPhong.DisabledState.BorderColor = Color.DarkGray;
            btnXoaPhong.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaPhong.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaPhong.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaPhong.FillColor = Color.DeepSkyBlue;
            btnXoaPhong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaPhong.ForeColor = Color.White;
            btnXoaPhong.Image = (Image)resources.GetObject("btnXoaPhong.Image");
            btnXoaPhong.Location = new Point(88, 60);
            btnXoaPhong.Margin = new Padding(3, 2, 3, 2);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoaPhong.Size = new Size(40, 28);
            btnXoaPhong.TabIndex = 6;
            // 
            // lblThongtinPhong
            // 
            lblThongtinPhong.BackColor = Color.Transparent;
            lblThongtinPhong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongtinPhong.Location = new Point(26, 38);
            lblThongtinPhong.Margin = new Padding(3, 2, 3, 2);
            lblThongtinPhong.Name = "lblThongtinPhong";
            lblThongtinPhong.Size = new Size(59, 21);
            lblThongtinPhong.TabIndex = 5;
            lblThongtinPhong.Text = "Thông tin";
            // 
            // lblTenPhong
            // 
            lblTenPhong.BackColor = Color.Transparent;
            lblTenPhong.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenPhong.Location = new Point(26, 15);
            lblTenPhong.Margin = new Padding(3, 2, 3, 2);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(66, 22);
            lblTenPhong.TabIndex = 4;
            lblTenPhong.Text = "Phòng 1";
            // 
            // RoomViewUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomViewUserControl";
            Size = new Size(158, 105);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhong;
        public Guna.UI2.WinForms.Guna2Button btnSuaPhong;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblThongtinPhong;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhong;
    }
}
