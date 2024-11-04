namespace DesktopApp.Devices
{
    partial class ControlDevice
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
            addDevice = new FontAwesome.Sharp.IconButton();
            flayoutDevice = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(addDevice);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 56);
            panel1.TabIndex = 2;
            // 
            // addDevice
            // 
            addDevice.AutoSize = true;
            addDevice.BackColor = Color.Transparent;
            addDevice.Dock = DockStyle.Left;
            addDevice.FlatAppearance.BorderColor = Color.White;
            addDevice.FlatAppearance.BorderSize = 0;
            addDevice.FlatAppearance.MouseDownBackColor = Color.Black;
            addDevice.FlatStyle = FlatStyle.Flat;
            addDevice.ForeColor = Color.White;
            addDevice.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addDevice.IconColor = Color.Black;
            addDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addDevice.Location = new Point(0, 0);
            addDevice.Name = "addDevice";
            addDevice.Size = new Size(54, 56);
            addDevice.TabIndex = 3;
            addDevice.UseVisualStyleBackColor = false;
            addDevice.Click += addDevice_Click;
            // 
            // flayoutDevice
            // 
            flayoutDevice.BackColor = Color.Transparent;
            flayoutDevice.Dock = DockStyle.Fill;
            flayoutDevice.Location = new Point(0, 56);
            flayoutDevice.Name = "flayoutDevice";
            flayoutDevice.Size = new Size(1082, 615);
            flayoutDevice.TabIndex = 3;
            // 
            // ControlDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flayoutDevice);
            Controls.Add(panel1);
            Name = "ControlDevice";
            Size = new Size(1082, 671);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton addDevice;
        private FlowLayoutPanel flayoutDevice;
    }
}
