namespace DesktopApp.Controls.Rooms
{
    partial class RoomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flayoutHouse = new FlowLayoutPanel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnAddRoom = new Guna.UI2.WinForms.Guna2CircleButton();
            lblNameHouse = new Label();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flayoutHouse
            // 
            flayoutHouse.Dock = DockStyle.Fill;
            flayoutHouse.Location = new Point(0, 54);
            flayoutHouse.Name = "flayoutHouse";
            flayoutHouse.Size = new Size(1218, 513);
            flayoutHouse.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(btnAddRoom);
            guna2GradientPanel1.Controls.Add(lblNameHouse);
            guna2GradientPanel1.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Size = new Size(1218, 54);
            guna2GradientPanel1.TabIndex = 2;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.Transparent;
            btnAddRoom.BorderColor = Color.Silver;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.Dock = DockStyle.Right;
            btnAddRoom.FillColor = Color.Transparent;
            btnAddRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.HoverState.BorderColor = Color.LightGray;
            btnAddRoom.HoverState.CustomBorderColor = Color.LightGray;
            btnAddRoom.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            btnAddRoom.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnAddRoom.Image = (Image)resources.GetObject("btnAddRoom.Image");
            btnAddRoom.ImageOffset = new Point(1, 1);
            btnAddRoom.ImageSize = new Size(35, 35);
            btnAddRoom.Location = new Point(1154, 0);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.PressedColor = Color.Transparent;
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAddRoom.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAddRoom.Size = new Size(64, 54);
            btnAddRoom.TabIndex = 2;
            // 
            // lblNameHouse
            // 
            lblNameHouse.AutoSize = true;
            lblNameHouse.Location = new Point(61, 19);
            lblNameHouse.Name = "lblNameHouse";
            lblNameHouse.Size = new Size(52, 21);
            lblNameHouse.TabIndex = 1;
            lblNameHouse.Text = "label1";
            // 
            // RoomControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flayoutHouse);
            Controls.Add(guna2GradientPanel1);
            Name = "RoomControl";
            Size = new Size(1218, 567);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flayoutHouse;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label lblNameHouse;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddRoom;
    }
}
