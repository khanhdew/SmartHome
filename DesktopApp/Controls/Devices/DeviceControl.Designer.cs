namespace DesktopApp.Controls.Devices
{
    partial class DeviceControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblNameRoom = new Label();
            btnAddDevice = new Guna.UI2.WinForms.Guna2CircleButton();
            flayoutHouse = new FlowLayoutPanel();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(lblNameRoom);
            guna2GradientPanel1.Controls.Add(btnAddDevice);
            guna2GradientPanel1.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Size = new Size(1218, 54);
            guna2GradientPanel1.TabIndex = 4;
            // 
            // lblNameRoom
            // 
            lblNameRoom.AutoSize = true;
            lblNameRoom.Location = new Point(61, 19);
            lblNameRoom.Name = "lblNameRoom";
            lblNameRoom.Size = new Size(52, 21);
            lblNameRoom.TabIndex = 1;
            lblNameRoom.Text = "label1";
            // 
            // btnAddDevice
            // 
            btnAddDevice.BackColor = Color.Transparent;
            btnAddDevice.BorderColor = Color.Silver;
            btnAddDevice.DisabledState.BorderColor = Color.DarkGray;
            btnAddDevice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddDevice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddDevice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddDevice.Dock = DockStyle.Right;
            btnAddDevice.FillColor = Color.Transparent;
            btnAddDevice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.HoverState.BorderColor = Color.LightGray;
            btnAddDevice.HoverState.CustomBorderColor = Color.LightGray;
            btnAddDevice.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            btnAddDevice.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnAddDevice.Image = (Image)resources.GetObject("btnAddDevice.Image");
            btnAddDevice.ImageOffset = new Point(1, 1);
            btnAddDevice.ImageSize = new Size(35, 35);
            btnAddDevice.Location = new Point(1162, 0);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.PressedColor = Color.Transparent;
            btnAddDevice.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAddDevice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAddDevice.Size = new Size(56, 54);
            btnAddDevice.TabIndex = 0;
            // 
            // flayoutHouse
            // 
            flayoutHouse.Dock = DockStyle.Fill;
            flayoutHouse.Location = new Point(0, 0);
            flayoutHouse.Name = "flayoutHouse";
            flayoutHouse.Size = new Size(1218, 567);
            flayoutHouse.TabIndex = 5;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2GradientPanel1);
            Controls.Add(flayoutHouse);
            Name = "DeviceControl";
            Size = new Size(1218, 567);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label lblNameRoom;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddDevice;
        private FlowLayoutPanel flayoutHouse;
    }
}
