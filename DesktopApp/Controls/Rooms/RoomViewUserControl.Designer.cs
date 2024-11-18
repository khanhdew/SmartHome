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
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            lblThongtinPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTenPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoSize = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnXoa);
            guna2ShadowPanel1.Controls.Add(btnSua);
            guna2ShadowPanel1.Controls.Add(lblThongtinPhong);
            guna2ShadowPanel1.Controls.Add(lblTenPhong);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Silver;
            guna2ShadowPanel1.Size = new Size(268, 170);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 10;
            btnXoa.CustomizableEdges = customizableEdges1;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(219, 80, 74);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(86, 107);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXoa.Size = new Size(46, 38);
            btnXoa.TabIndex = 9;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 10;
            btnSua.CustomizableEdges = customizableEdges3;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.FromArgb(60, 145, 230);
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(26, 107);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSua.Size = new Size(46, 38);
            btnSua.TabIndex = 8;
            // 
            // lblThongtinPhong
            // 
            lblThongtinPhong.BackColor = Color.Transparent;
            lblThongtinPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongtinPhong.Location = new Point(26, 54);
            lblThongtinPhong.Name = "lblThongtinPhong";
            lblThongtinPhong.Size = new Size(69, 23);
            lblThongtinPhong.TabIndex = 5;
            lblThongtinPhong.Text = "Thông tin";
            // 
            // lblTenPhong
            // 
            lblTenPhong.BackColor = Color.Transparent;
            lblTenPhong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenPhong.Location = new Point(26, 24);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(73, 27);
            lblTenPhong.TabIndex = 4;
            lblTenPhong.Text = "Phòng 1";
            // 
            // RoomViewUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(20, 2, 3, 2);
            Name = "RoomViewUserControl";
            Size = new Size(268, 170);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblThongtinPhong;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhong;
        public Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}
