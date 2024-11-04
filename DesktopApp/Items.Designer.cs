namespace DesktopApp.Houses
{
    partial class Items
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
            panel1 = new Panel();
            itemThongTin = new Label();
            itemTitle = new Krypton.Toolkit.KryptonLabel();
            btnSua = new Button();
            btnXoa = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(itemThongTin);
            panel1.Controls.Add(itemTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 82);
            panel1.TabIndex = 0;
            // 
            // itemThongTin
            // 
            itemThongTin.Dock = DockStyle.Fill;
            itemThongTin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            itemThongTin.Location = new Point(0, 55);
            itemThongTin.Name = "itemThongTin";
            itemThongTin.Size = new Size(290, 27);
            itemThongTin.TabIndex = 1;
            itemThongTin.Text = "thông tin chung";
            // 
            // itemTitle
            // 
            itemTitle.AutoSize = false;
            itemTitle.Dock = DockStyle.Top;
            itemTitle.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            itemTitle.Location = new Point(0, 0);
            itemTitle.Name = "itemTitle";
            itemTitle.Size = new Size(290, 55);
            itemTitle.StateNormal.ShortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            itemTitle.TabIndex = 0;
            itemTitle.Values.Text = "House 1";
            itemTitle.Click += itemTitle_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightCoral;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Transparent;
            btnSua.Location = new Point(60, 104);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Indigo;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(177, 104);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(panel1);
            Name = "Items";
            Padding = new Padding(5);
            Size = new Size(300, 180);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Button btnSua;
        public Button btnXoa;
        public Krypton.Toolkit.KryptonLabel itemTitle;
        public Label itemThongTin;
    }
}
