namespace DesktopApp.Controls.Houses
{
    partial class HouseEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblHouseName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            lblHouseAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDetail = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            BtnInvCode = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDelMember = new Guna.UI2.WinForms.Guna2Button();
            dgvHouseMember = new Guna.UI2.WinForms.Guna2DataGridView();
            cellUsername = new DataGridViewTextBoxColumn();
            cellDisplayName = new DataGridViewTextBoxColumn();
            cellPhoneNumber = new DataGridViewTextBoxColumn();
            cellRole = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHouseMember).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoScroll = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel1.Controls.Add(lblHouseName);
            guna2ShadowPanel1.Controls.Add(btnConfirm);
            guna2ShadowPanel1.Controls.Add(lblHouseAddress);
            guna2ShadowPanel1.Controls.Add(txtDetail);
            guna2ShadowPanel1.Controls.Add(txtName);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.ForeColor = Color.FromArgb(0, 118, 212);
            guna2ShadowPanel1.Location = new Point(15, 72);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Silver;
            guna2ShadowPanel1.Size = new Size(327, 386);
            guna2ShadowPanel1.TabIndex = 1;
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
            // lblHouseName
            // 
            lblHouseName.BackColor = Color.Transparent;
            lblHouseName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHouseName.Location = new Point(17, 107);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(28, 22);
            lblHouseName.TabIndex = 6;
            lblHouseName.Text = "Tên";
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 15;
            btnConfirm.CustomizableEdges = customizableEdges11;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.FromArgb(0, 118, 212);
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(17, 284);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnConfirm.Size = new Size(297, 45);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblHouseAddress
            // 
            lblHouseAddress.BackColor = Color.Transparent;
            lblHouseAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHouseAddress.Location = new Point(17, 183);
            lblHouseAddress.Name = "lblHouseAddress";
            lblHouseAddress.Size = new Size(50, 22);
            lblHouseAddress.TabIndex = 7;
            lblHouseAddress.Text = "Địa chỉ";
            // 
            // txtDetail
            // 
            txtDetail.BorderRadius = 10;
            txtDetail.CustomizableEdges = customizableEdges13;
            txtDetail.DefaultText = "";
            txtDetail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDetail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDetail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDetail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDetail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDetail.Location = new Point(17, 211);
            txtDetail.Name = "txtDetail";
            txtDetail.PasswordChar = '\0';
            txtDetail.PlaceholderText = "";
            txtDetail.SelectedText = "";
            txtDetail.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtDetail.Size = new Size(297, 36);
            txtDetail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges15;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(17, 135);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtName.Size = new Size(297, 36);
            txtName.TabIndex = 8;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.AutoScroll = true;
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(BtnInvCode);
            guna2ShadowPanel2.Controls.Add(guna2HtmlLabel2);
            guna2ShadowPanel2.Controls.Add(btnDelMember);
            guna2ShadowPanel2.Controls.Add(dgvHouseMember);
            guna2ShadowPanel2.FillColor = Color.White;
            guna2ShadowPanel2.Location = new Point(348, 72);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Silver;
            guna2ShadowPanel2.Size = new Size(526, 386);
            guna2ShadowPanel2.TabIndex = 2;
            // 
            // BtnInvCode
            // 
            BtnInvCode.BorderRadius = 15;
            BtnInvCode.CustomizableEdges = customizableEdges17;
            BtnInvCode.DisabledState.BorderColor = Color.DarkGray;
            BtnInvCode.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnInvCode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnInvCode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnInvCode.FillColor = Color.FromArgb(0, 118, 212);
            BtnInvCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInvCode.ForeColor = Color.White;
            BtnInvCode.Location = new Point(41, 284);
            BtnInvCode.Name = "BtnInvCode";
            BtnInvCode.ShadowDecoration.CustomizableEdges = customizableEdges18;
            BtnInvCode.Size = new Size(135, 45);
            BtnInvCode.TabIndex = 13;
            BtnInvCode.Text = "Copy mã mời";
            BtnInvCode.Click += BtnInvCode_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(0, 118, 212);
            guna2HtmlLabel2.Location = new Point(193, 24);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(146, 22);
            guna2HtmlLabel2.TabIndex = 12;
            guna2HtmlLabel2.Text = "Thông tin thành viên";
            // 
            // btnDelMember
            // 
            btnDelMember.BorderRadius = 15;
            btnDelMember.CustomizableEdges = customizableEdges19;
            btnDelMember.DisabledState.BorderColor = Color.DarkGray;
            btnDelMember.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelMember.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelMember.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelMember.FillColor = Color.Red;
            btnDelMember.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelMember.ForeColor = Color.White;
            btnDelMember.Location = new Point(374, 284);
            btnDelMember.Name = "btnDelMember";
            btnDelMember.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnDelMember.Size = new Size(135, 45);
            btnDelMember.TabIndex = 1;
            btnDelMember.Text = "Xoá thành viên";
            btnDelMember.Click += btnDelMember_Click;
            // 
            // dgvHouseMember
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(189, 223, 251);
            dgvHouseMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvHouseMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvHouseMember.ColumnHeadersHeight = 17;
            dgvHouseMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHouseMember.Columns.AddRange(new DataGridViewColumn[] { cellUsername, cellDisplayName, cellPhoneNumber, cellRole });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvHouseMember.DefaultCellStyle = dataGridViewCellStyle6;
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
            // HouseEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ShadowPanel2);
            Name = "HouseEdit";
            Size = new Size(887, 526);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHouseMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHouseName;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHouseAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnDelMember;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHouseMember;
        private DataGridViewTextBoxColumn cellUsername;
        private DataGridViewTextBoxColumn cellDisplayName;
        private DataGridViewTextBoxColumn cellPhoneNumber;
        private DataGridViewTextBoxColumn cellRole;
        private Guna.UI2.WinForms.Guna2Button BtnInvCode;
    }
}