namespace DesktopApp.Controls.Devices
{
    partial class DeviceEdit
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvDevice = new Guna.UI2.WinForms.Guna2DataGridView();
            Action = new DataGridViewTextBoxColumn();
            TimeStamp = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDeviceToken = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            lblDeviceType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDeviceType = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDevice).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDevice
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            dgvDevice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDevice.ColumnHeadersHeight = 17;
            dgvDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDevice.Columns.AddRange(new DataGridViewColumn[] { Action, TimeStamp });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDevice.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDevice.GridColor = Color.FromArgb(187, 222, 251);
            dgvDevice.Location = new Point(13, 52);
            dgvDevice.Name = "dgvDevice";
            dgvDevice.RowHeadersVisible = false;
            dgvDevice.RowTemplate.Height = 25;
            dgvDevice.Size = new Size(496, 216);
            dgvDevice.TabIndex = 0;
            dgvDevice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            dgvDevice.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            dgvDevice.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDevice.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDevice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDevice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDevice.ThemeStyle.BackColor = Color.White;
            dgvDevice.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            dgvDevice.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            dgvDevice.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDevice.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDevice.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDevice.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDevice.ThemeStyle.HeaderStyle.Height = 17;
            dgvDevice.ThemeStyle.ReadOnly = false;
            dgvDevice.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            dgvDevice.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDevice.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDevice.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvDevice.ThemeStyle.RowsStyle.Height = 25;
            dgvDevice.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dgvDevice.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // Action
            // 
            Action.DataPropertyName = "Body";
            Action.HeaderText = "Hành động";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // TimeStamp
            // 
            TimeStamp.DataPropertyName = "Timestamp";
            TimeStamp.HeaderText = "Thời gian";
            TimeStamp.Name = "TimeStamp";
            TimeStamp.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoScroll = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel3);
            guna2ShadowPanel1.Controls.Add(txtDeviceToken);
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel1.Controls.Add(lblName);
            guna2ShadowPanel1.Controls.Add(btnConfirm);
            guna2ShadowPanel1.Controls.Add(lblDeviceType);
            guna2ShadowPanel1.Controls.Add(txtDeviceType);
            guna2ShadowPanel1.Controls.Add(txtName);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.ForeColor = Color.FromArgb(0, 118, 212);
            guna2ShadowPanel1.Location = new Point(16, 63);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(327, 386);
            guna2ShadowPanel1.TabIndex = 5;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(17, 214);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(91, 22);
            guna2HtmlLabel3.TabIndex = 12;
            guna2HtmlLabel3.Text = "DeviceToken";
            // 
            // txtDeviceToken
            // 
            txtDeviceToken.BorderRadius = 10;
            txtDeviceToken.CustomizableEdges = customizableEdges1;
            txtDeviceToken.DefaultText = "";
            txtDeviceToken.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDeviceToken.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDeviceToken.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDeviceToken.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDeviceToken.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeviceToken.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeviceToken.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeviceToken.Location = new Point(17, 242);
            txtDeviceToken.Name = "txtDeviceToken";
            txtDeviceToken.PasswordChar = '\0';
            txtDeviceToken.PlaceholderText = "";
            txtDeviceToken.ReadOnly = true;
            txtDeviceToken.SelectedText = "";
            txtDeviceToken.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtDeviceToken.Size = new Size(297, 36);
            txtDeviceToken.TabIndex = 13;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 118, 212);
            guna2HtmlLabel1.Location = new Point(105, 39);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(137, 22);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Chỉnh sửa thông tin";
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(17, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(28, 22);
            lblName.TabIndex = 6;
            lblName.Text = "Tên";
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 15;
            btnConfirm.CustomizableEdges = customizableEdges3;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.FromArgb(0, 118, 212);
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(17, 304);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnConfirm.Size = new Size(297, 45);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblDeviceType
            // 
            lblDeviceType.BackColor = Color.Transparent;
            lblDeviceType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeviceType.Location = new Point(17, 144);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(31, 22);
            lblDeviceType.TabIndex = 7;
            lblDeviceType.Text = "Loại";
            // 
            // txtDeviceType
            // 
            txtDeviceType.BorderRadius = 10;
            txtDeviceType.CustomizableEdges = customizableEdges5;
            txtDeviceType.DefaultText = "";
            txtDeviceType.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDeviceType.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDeviceType.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDeviceType.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDeviceType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeviceType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDeviceType.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeviceType.Location = new Point(17, 172);
            txtDeviceType.Name = "txtDeviceType";
            txtDeviceType.PasswordChar = '\0';
            txtDeviceType.PlaceholderText = "";
            txtDeviceType.ReadOnly = true;
            txtDeviceType.SelectedText = "";
            txtDeviceType.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDeviceType.Size = new Size(297, 36);
            txtDeviceType.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(17, 96);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(297, 36);
            txtName.TabIndex = 8;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.AutoScroll = true;
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(guna2HtmlLabel2);
            guna2ShadowPanel2.Controls.Add(dgvDevice);
            guna2ShadowPanel2.FillColor = Color.White;
            guna2ShadowPanel2.Location = new Point(349, 63);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Black;
            guna2ShadowPanel2.Size = new Size(526, 386);
            guna2ShadowPanel2.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(0, 118, 212);
            guna2HtmlLabel2.Location = new Point(193, 24);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(121, 22);
            guna2HtmlLabel2.TabIndex = 12;
            guna2HtmlLabel2.Text = "Thông tin thiết bị";
            // 
            // DeviceEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ShadowPanel2);
            Name = "DeviceEdit";
            Size = new Size(878, 513);
            ((System.ComponentModel.ISupportInitialize)dgvDevice).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDevice;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceToken;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDeviceType;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceType;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn TimeStamp;
    }
}
