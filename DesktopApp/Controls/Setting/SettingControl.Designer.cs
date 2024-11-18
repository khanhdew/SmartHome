namespace DesktopApp.Controls.Setting
{
    partial class SettingControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowLayoutPanel1 = new FlowLayoutPanel();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnThayDoi = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flowLayoutPanel1.SuspendLayout();
            guna2ShadowPanel3.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(guna2ShadowPanel3);
            flowLayoutPanel1.Controls.Add(guna2ShadowPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50, 20, 20, 20);
            flowLayoutPanel1.Size = new Size(1218, 500);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.Controls.Add(btnThayDoi);
            guna2ShadowPanel3.Controls.Add(guna2HtmlLabel2);
            guna2ShadowPanel3.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel3.FillColor = Color.White;
            guna2ShadowPanel3.Location = new Point(53, 23);
            guna2ShadowPanel3.Margin = new Padding(3, 3, 20, 3);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 10;
            guna2ShadowPanel3.ShadowColor = Color.Silver;
            guna2ShadowPanel3.Size = new Size(265, 214);
            guna2ShadowPanel3.TabIndex = 4;
            // 
            // btnThayDoi
            // 
            btnThayDoi.AutoRoundedCorners = true;
            btnThayDoi.BorderRadius = 18;
            btnThayDoi.CustomizableEdges = customizableEdges1;
            btnThayDoi.DisabledState.BorderColor = Color.DarkGray;
            btnThayDoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThayDoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThayDoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThayDoi.FillColor = Color.FromArgb(60, 145, 230);
            btnThayDoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThayDoi.ForeColor = Color.White;
            btnThayDoi.Location = new Point(45, 146);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThayDoi.Size = new Size(180, 38);
            btnThayDoi.TabIndex = 3;
            btnThayDoi.Text = "Thay đổi";
            btnThayDoi.Click += btnThayDoi_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(28, 59);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(197, 17);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Thay đổi thông tin tài khoản của bạn";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(60, 145, 230);
            guna2HtmlLabel1.Location = new Point(28, 24);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(170, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Thông tin tài khoản";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2ComboBox1);
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel3);
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel4);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(341, 23);
            guna2ShadowPanel1.Margin = new Padding(3, 3, 20, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Silver;
            guna2ShadowPanel1.Size = new Size(265, 214);
            guna2ShadowPanel1.TabIndex = 5;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Tiếng Việt", "English" });
            guna2ComboBox1.AutoRoundedCorners = true;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderRadius = 17;
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FillColor = Color.FromArgb(60, 145, 230);
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.White;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "Tiếng Việt", "English" });
            guna2ComboBox1.ItemsAppearance.BackColor = Color.FromArgb(224, 224, 224);
            guna2ComboBox1.ItemsAppearance.ForeColor = Color.White;
            guna2ComboBox1.ItemsAppearance.SelectedBackColor = Color.FromArgb(60, 145, 230);
            guna2ComboBox1.Location = new Point(28, 148);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(210, 36);
            guna2ComboBox1.StartIndex = 0;
            guna2ComboBox1.TabIndex = 3;
            guna2ComboBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Location = new Point(28, 59);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(165, 17);
            guna2HtmlLabel3.TabIndex = 2;
            guna2HtmlLabel3.Text = "Chọn ngôn ngữ cho ứng dụng";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(60, 145, 230);
            guna2HtmlLabel4.Location = new Point(28, 24);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(90, 27);
            guna2HtmlLabel4.TabIndex = 1;
            guna2HtmlLabel4.Text = "Ngôn ngữ";
            // 
            // SettingControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Name = "SettingControl";
            Size = new Size(1218, 500);
            flowLayoutPanel1.ResumeLayout(false);
            guna2ShadowPanel3.ResumeLayout(false);
            guna2ShadowPanel3.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        internal Guna.UI2.WinForms.Guna2Button btnThayDoi;
    }
}
