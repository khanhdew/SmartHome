namespace DesktopApp.Houses
{
    partial class NewsHouse
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
            label1 = new Label();
            txtNameHouse = new TextBox();
            txtTTHouse = new TextBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 86);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 0;
            label1.Text = "Name House : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameHouse
            // 
            txtNameHouse.Location = new Point(202, 75);
            txtNameHouse.Multiline = true;
            txtNameHouse.Name = "txtNameHouse";
            txtNameHouse.Size = new Size(347, 43);
            txtNameHouse.TabIndex = 1;
            // 
            // txtTTHouse
            // 
            txtTTHouse.Location = new Point(202, 154);
            txtTTHouse.Multiline = true;
            txtTTHouse.Name = "txtTTHouse";
            txtTTHouse.Size = new Size(347, 43);
            txtTTHouse.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 165);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Thông tin : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(202, 269);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(108, 44);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(380, 269);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 44);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // NewsHouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 389);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtTTHouse);
            Controls.Add(label2);
            Controls.Add(txtNameHouse);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NewsHouse";
            Text = "NewsHouse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtNameHouse;
        public TextBox txtTTHouse;
        public Button btnLuu;
        public Button btnHuy;
    }
}