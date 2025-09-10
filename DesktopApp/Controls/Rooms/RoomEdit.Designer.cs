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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvDevice = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            cellDeviceName = new DataGridViewTextBoxColumn();
            cellDeviceType = new DataGridViewTextBoxColumn();
            cellOwner = new DataGridViewTextBoxColumn();
            cellAction = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            lblDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDetail = new Guna.UI2.WinForms.Guna2TextBox();
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(189, 223, 251);
            dgvDevice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDevice.ColumnHeadersHeight = 17;
            dgvDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDevice.Columns.AddRange(new DataGridViewColumn[] { Id, cellDeviceName, cellDeviceType, cellOwner, cellAction });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDevice.DefaultCellStyle = dataGridViewCellStyle6;
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
            dgvDevice.CellDoubleClick += dgvDevice_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // cellDeviceName
            // 
            cellDeviceName.DataPropertyName = "Name";
            cellDeviceName.HeaderText = "Tên";
            cellDeviceName.Name = "cellDeviceName";
            cellDeviceName.ReadOnly = true;
            // 
            // cellDeviceType
            // 
            cellDeviceType.DataPropertyName = "Type";
            cellDeviceType.HeaderText = "Loại";
            cellDeviceType.Name = "cellDeviceType";
            cellDeviceType.ReadOnly = true;
            // 
            // cellOwner
            // 
            cellOwner.DataPropertyName = "Owner";
            cellOwner.HeaderText = "Chủ sở hữu";
            cellOwner.Name = "cellOwner";
            cellOwner.ReadOnly = true;
            // 
            // cellAction
            // 
            cellAction.DataPropertyName = "Action";
            cellAction.HeaderText = "Hành động";
            cellAction.Name = "cellAction";
            cellAction.Resizable = DataGridViewTriState.True;
            cellAction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.AutoScroll = true;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel1.Controls.Add(lblName);
            guna2ShadowPanel1.Controls.Add(btnConfirm);
            guna2ShadowPanel1.Controls.Add(lblDetail);
            guna2ShadowPanel1.Controls.Add(txtDetail);
            guna2ShadowPanel1.Controls.Add(txtName);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.ForeColor = Color.FromArgb(0, 118, 212);
            guna2ShadowPanel1.Location = new Point(29, 64);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Silver;
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
            btnConfirm.CustomizableEdges = customizableEdges7;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.FromArgb(0, 118, 212);
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(17, 284);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnConfirm.Size = new Size(297, 45);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Click += btnConfirm_Click;
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
            // txtDetail
            // 
            txtDetail.BorderRadius = 10;
            txtDetail.CustomizableEdges = customizableEdges9;
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
            txtDetail.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDetail.Size = new Size(297, 36);
            txtDetail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges11;
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
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            guna2ShadowPanel2.Location = new Point(362, 64);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Silver;
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
            // RoomEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ShadowPanel2);
            Name = "RoomEdit";
            Size = new Size(904, 514);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnDelMember;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn cellDeviceName;
        private DataGridViewTextBoxColumn cellDeviceType;
        private DataGridViewTextBoxColumn cellOwner;
        private DataGridViewTextBoxColumn cellAction;
    }
}
