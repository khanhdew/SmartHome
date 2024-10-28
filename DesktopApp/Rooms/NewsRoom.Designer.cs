namespace DesktopApp.Rooms
{
    partial class NewsRoom
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
            txtTTRoom = new TextBox();
            label2 = new Label();
            txtNameRoom = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(435, 311);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 44);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(224, 311);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(108, 44);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTTRoom
            // 
            txtTTRoom.Location = new Point(306, 194);
            txtTTRoom.Multiline = true;
            txtTTRoom.Name = "txtTTRoom";
            txtTTRoom.Size = new Size(347, 43);
            txtTTRoom.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(132, 205);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 8;
            label2.Text = "Thông tin Room  : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameRoom
            // 
            txtNameRoom.Location = new Point(306, 106);
            txtNameRoom.Multiline = true;
            txtNameRoom.Name = "txtNameRoom";
            txtNameRoom.Size = new Size(347, 43);
            txtNameRoom.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 116);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 6;
            label1.Text = "Name Room : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewsRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 430);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtTTRoom);
            Controls.Add(label2);
            Controls.Add(txtNameRoom);
            Controls.Add(label1);
            Name = "NewsRoom";
            Text = "NewsRoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnHuy;
        public Button btnLuu;
        public TextBox txtTTRoom;
        private Label label2;
        public TextBox txtNameRoom;
        private Label label1;
    }
}