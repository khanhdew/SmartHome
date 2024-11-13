namespace DesktopApp.Controls.Devices
{
    partial class DeviceViewControlLight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceViewControlLight));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lightBulbPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            powerButton = new Guna.UI2.WinForms.Guna2Button();
            TrackBarLight = new Guna.UI2.WinForms.Guna2TrackBar();
            btnSuaDen = new Guna.UI2.WinForms.Guna2Button();
            btnXoaDen = new Guna.UI2.WinForms.Guna2Button();
            lblTenDen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.BackgroundImageLayout = ImageLayout.Center;
            guna2ShadowPanel1.Controls.Add(lightBulbPanel);
            guna2ShadowPanel1.Controls.Add(powerButton);
            guna2ShadowPanel1.Controls.Add(TrackBarLight);
            guna2ShadowPanel1.Controls.Add(btnSuaDen);
            guna2ShadowPanel1.Controls.Add(btnXoaDen);
            guna2ShadowPanel1.Controls.Add(lblTenDen);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(219, 225);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // lightBulbPanel
            // 
            lightBulbPanel.AutoRoundedCorners = true;
            lightBulbPanel.BackColor = Color.Transparent;
            lightBulbPanel.BackgroundImage = (Image)resources.GetObject("lightBulbPanel.BackgroundImage");
            lightBulbPanel.BackgroundImageLayout = ImageLayout.Center;
            lightBulbPanel.BorderColor = Color.Transparent;
            lightBulbPanel.BorderRadius = 41;
            lightBulbPanel.BorderThickness = 2;
            lightBulbPanel.CustomizableEdges = customizableEdges1;
            lightBulbPanel.Enabled = false;
            lightBulbPanel.Location = new Point(63, 53);
            lightBulbPanel.Name = "lightBulbPanel";
            lightBulbPanel.ShadowDecoration.Color = Color.Transparent;
            lightBulbPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lightBulbPanel.ShadowDecoration.Enabled = true;
            lightBulbPanel.Size = new Size(96, 85);
            lightBulbPanel.TabIndex = 16;
            lightBulbPanel.UseTransparentBackground = true;
            // 
            // powerButton
            // 
            powerButton.BackColor = Color.Transparent;
            powerButton.BackgroundImage = (Image)resources.GetObject("powerButton.BackgroundImage");
            powerButton.BackgroundImageLayout = ImageLayout.Zoom;
            powerButton.CustomizableEdges = customizableEdges3;
            powerButton.DisabledState.BorderColor = Color.DarkGray;
            powerButton.DisabledState.CustomBorderColor = Color.DarkGray;
            powerButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            powerButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            powerButton.FillColor = Color.Transparent;
            powerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            powerButton.ForeColor = Color.White;
            powerButton.Location = new Point(92, 183);
            powerButton.Name = "powerButton";
            powerButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            powerButton.Size = new Size(36, 39);
            powerButton.TabIndex = 15;
            powerButton.Click += powerButton_Click;
            // 
            // TrackBarLight
            // 
            TrackBarLight.Location = new Point(18, 156);
            TrackBarLight.Margin = new Padding(3, 2, 3, 2);
            TrackBarLight.Name = "TrackBarLight";
            TrackBarLight.Size = new Size(178, 22);
            TrackBarLight.TabIndex = 13;
            TrackBarLight.ThumbColor = Color.DeepSkyBlue;
            TrackBarLight.ValueChanged += setLedDim;
            // 
            // btnSuaDen
            // 
            btnSuaDen.BorderRadius = 10;
            btnSuaDen.CustomizableEdges = customizableEdges5;
            btnSuaDen.DisabledState.BorderColor = Color.DarkGray;
            btnSuaDen.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuaDen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuaDen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuaDen.FillColor = Color.White;
            btnSuaDen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaDen.ForeColor = Color.White;
            btnSuaDen.Image = (Image)resources.GetObject("btnSuaDen.Image");
            btnSuaDen.Location = new Point(119, 20);
            btnSuaDen.Margin = new Padding(3, 2, 3, 2);
            btnSuaDen.Name = "btnSuaDen";
            btnSuaDen.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSuaDen.Size = new Size(40, 28);
            btnSuaDen.TabIndex = 12;
            // 
            // btnXoaDen
            // 
            btnXoaDen.BorderRadius = 10;
            btnXoaDen.CustomizableEdges = customizableEdges7;
            btnXoaDen.DisabledState.BorderColor = Color.DarkGray;
            btnXoaDen.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaDen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaDen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaDen.FillColor = Color.White;
            btnXoaDen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaDen.ForeColor = Color.White;
            btnXoaDen.Image = (Image)resources.GetObject("btnXoaDen.Image");
            btnXoaDen.Location = new Point(156, 20);
            btnXoaDen.Margin = new Padding(3, 2, 3, 2);
            btnXoaDen.Name = "btnXoaDen";
            btnXoaDen.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnXoaDen.Size = new Size(40, 28);
            btnXoaDen.TabIndex = 11;
            // 
            // lblTenDen
            // 
            lblTenDen.BackColor = Color.Transparent;
            lblTenDen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenDen.Location = new Point(29, 20);
            lblTenDen.Margin = new Padding(3, 2, 3, 2);
            lblTenDen.Name = "lblTenDen";
            lblTenDen.Size = new Size(48, 22);
            lblTenDen.TabIndex = 9;
            lblTenDen.Text = "Đèn 1";
            // 
            // DeviceViewControlLight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeviceViewControlLight";
            Size = new Size(219, 225);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button powerButton;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarLight;
        private Guna.UI2.WinForms.Guna2Button btnSuaDen;
        private Guna.UI2.WinForms.Guna2Button btnXoaDen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenDen;
        private Guna.UI2.WinForms.Guna2GradientPanel lightBulbPanel;
    }
}
