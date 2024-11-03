namespace DesktopApp.Devices
{
    partial class NewsDevice
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
            btnHuy = new Button();
            btnLuu = new Button();
            txtTTDevice = new TextBox();
            label2 = new Label();
            txtNameDevice = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(443, 306);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 44);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(232, 306);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(108, 44);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // txtTTDevice
            // 
            txtTTDevice.Location = new Point(314, 189);
            txtTTDevice.Multiline = true;
            txtTTDevice.Name = "txtTTDevice";
            txtTTDevice.Size = new Size(347, 43);
            txtTTDevice.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 200);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 14;
            label2.Text = "Thông tin Thiết Bị  : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameDevice
            // 
            txtNameDevice.Location = new Point(314, 101);
            txtNameDevice.Multiline = true;
            txtNameDevice.Name = "txtNameDevice";
            txtNameDevice.Size = new Size(347, 43);
            txtNameDevice.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 111);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 12;
            label1.Text = "Name Thiết Bị : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewsDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtTTDevice);
            Controls.Add(label2);
            Controls.Add(txtNameDevice);
            Controls.Add(label1);
            Name = "NewsDevice";
            Text = "NewsDevice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnHuy;
        public Button btnLuu;
        public TextBox txtTTDevice;
        private Label label2;
        public TextBox txtNameDevice;
        private Label label1;
    }
}