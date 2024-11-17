namespace DesktopApp.Controls.Rooms
{
    partial class RoomEdit
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
            dgvHouseMember = new Guna.UI2.WinForms.Guna2DataGridView();
            cellUsername = new DataGridViewTextBoxColumn();
            cellDisplayName = new DataGridViewTextBoxColumn();
            cellPhoneNumber = new DataGridViewTextBoxColumn();
            cellRole = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            lblDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtHouseAddress = new Guna.UI2.WinForms.Guna2TextBox();
            txtHouseName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDelMember = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvHouseMember).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHouseMember
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            dgvHouseMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHouseMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHouseMember.ColumnHeadersHeight = 17;
            dgvHouseMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHouseMember.Columns.AddRange(new DataGridViewColumn[] { cellUsername, cellDisplayName, cellPhoneNumber, cellRole });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHouseMember.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHouseMember.GridColor = Color.FromArgb(187, 222, 251);
            dgvHouseMember.Location = new Point(13, 52);
            dgvHouseMember.Name = "dgvHouseMember";
            dgvHouseMember.RowHeadersVisible = false;
            dgvHouseMember.RowTemplate.Height = 25;
            dgvHouseMember.Size = new Size(496, 216);
            dgvHouseMember.TabIndex = 0;
            dgvHouseMember.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            dgvHouseMember.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            dgvHouseMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHouseMember.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHouseMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHouseMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHouseMember.ThemeStyle.BackColor = Color.White;
            dgvHouseMember.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            dgvHouseMember.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            dgvHouseMember.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHouseMember.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHouseMember.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHouseMember.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHouseMember.ThemeStyle.HeaderStyle.Height = 17;
            dgvHouseMember.ThemeStyle.ReadOnly = false;
            dgvHouseMember.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            dgvHouseMember.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHouseMember.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHouseMember.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvHouseMember.ThemeStyle.RowsStyle.Height = 25;
            dgvHouseMember.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dgvHouseMember.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // cellUsername
            // 
            cellUsername.DataPropertyName = "Username";
            cellUsername.HeaderText = "Username";
            cellUsername.Name = "cellUsername";
            cellUsername.ReadOnly = true;
            // 
            // cellDisplayName
            // 
            cellDisplayName.DataPropertyName = "DisplayName";
            cellDisplayName.HeaderText = "Họ Tên";
            cellDisplayName.Name = "cellDisplayName";
            cellDisplayName.ReadOnly = true;
            // 
            // cellPhoneNumber
            // 
            cellPhoneNumber.DataPropertyName = "PhoneNumber";
            cellPhoneNumber.HeaderText = "Số điện thoại";
            cellPhoneNumber.Name = "cellPhoneNumber";
            cellPhoneNumber.ReadOnly = true;
            // 
            // cellRole
            // 
            cellRole.DataPropertyName = "Role";
            cellRole.HeaderText = "Role";
            cellRole.Name = "cellRole";
            cellRole.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoScroll = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel1.Controls.Add(lblName);
            guna2ShadowPanel1.Controls.Add(btnConfirm);
            guna2ShadowPanel1.Controls.Add(lblDetail);
            guna2ShadowPanel1.Controls.Add(txtHouseAddress);
            guna2ShadowPanel1.Controls.Add(txtHouseName);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.ForeColor = Color.FromArgb(0, 118, 212);
            guna2ShadowPanel1.Location = new Point(29, 64);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(327, 386);
            guna2ShadowPanel1.TabIndex = 3;
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
            lblName.Location = new Point(17, 107);
            lblName.Name = "lblName";
            lblName.Size = new Size(28, 22);
            lblName.TabIndex = 6;
            lblName.Text = "Tên";
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 15;
            btnConfirm.CustomizableEdges = customizableEdges1;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.FromArgb(0, 118, 212);
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(17, 284);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnConfirm.Size = new Size(297, 45);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Xác nhận";
            // 
            // lblDetail
            // 
            lblDetail.BackColor = Color.Transparent;
            lblDetail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetail.Location = new Point(17, 183);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(51, 22);
            lblDetail.TabIndex = 7;
            lblDetail.Text = "Chi tiết";
            // 
            // txtHouseAddress
            // 
            txtHouseAddress.BorderRadius = 10;
            txtHouseAddress.CustomizableEdges = customizableEdges3;
            txtHouseAddress.DefaultText = "";
            txtHouseAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHouseAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHouseAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHouseAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHouseAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHouseAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouseAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHouseAddress.Location = new Point(17, 211);
            txtHouseAddress.Name = "txtHouseAddress";
            txtHouseAddress.PasswordChar = '\0';
            txtHouseAddress.PlaceholderText = "";
            txtHouseAddress.SelectedText = "";
            txtHouseAddress.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHouseAddress.Size = new Size(297, 36);
            txtHouseAddress.TabIndex = 9;
            // 
            // txtHouseName
            // 
            txtHouseName.BorderRadius = 10;
            txtHouseName.CustomizableEdges = customizableEdges5;
            txtHouseName.DefaultText = "";
            txtHouseName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHouseName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHouseName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHouseName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHouseName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHouseName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouseName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHouseName.Location = new Point(17, 135);
            txtHouseName.Name = "txtHouseName";
            txtHouseName.PasswordChar = '\0';
            txtHouseName.PlaceholderText = "";
            txtHouseName.SelectedText = "";
            txtHouseName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtHouseName.Size = new Size(297, 36);
            txtHouseName.TabIndex = 8;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.AutoScroll = true;
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(guna2HtmlLabel2);
            guna2ShadowPanel2.Controls.Add(btnDelMember);
            guna2ShadowPanel2.Controls.Add(dgvHouseMember);
            guna2ShadowPanel2.FillColor = Color.White;
            guna2ShadowPanel2.Location = new Point(362, 64);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Black;
            guna2ShadowPanel2.Size = new Size(526, 386);
            guna2ShadowPanel2.TabIndex = 4;
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
            // btnDelMember
            // 
            btnDelMember.BorderRadius = 15;
            btnDelMember.CustomizableEdges = customizableEdges7;
            btnDelMember.DisabledState.BorderColor = Color.DarkGray;
            btnDelMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelMember.FillColor = Color.Red;
            btnDelMember.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelMember.ForeColor = Color.White;
            btnDelMember.Location = new Point(374, 284);
            btnDelMember.Name = "btnDelMember";
            btnDelMember.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDelMember.Size = new Size(135, 45);
            btnDelMember.TabIndex = 1;
            btnDelMember.Text = "Xoá thành viên";
            // 
            // RoomEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ShadowPanel2);
            Name = "RoomEdit";
            Size = new Size(904, 514);
            ((System.ComponentModel.ISupportInitialize)dgvHouseMember).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvHouseMember;
        private DataGridViewTextBoxColumn cellUsername;
        private DataGridViewTextBoxColumn cellDisplayName;
        private DataGridViewTextBoxColumn cellPhoneNumber;
        private DataGridViewTextBoxColumn cellRole;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtHouseAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtHouseName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnDelMember;
    }
}
