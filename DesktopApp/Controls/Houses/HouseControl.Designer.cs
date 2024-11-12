namespace DesktopApp.Controls.Houses
{
    partial class HouseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnAddHouse = new Guna.UI2.WinForms.Guna2CircleButton();
            flayoutHouse = new FlowLayoutPanel();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(btnAddHouse);
            guna2GradientPanel1.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Size = new Size(1218, 54);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // btnAddHouse
            // 
            btnAddHouse.BackColor = Color.Transparent;
            btnAddHouse.BorderColor = Color.Silver;
            btnAddHouse.DisabledState.BorderColor = Color.DarkGray;
            btnAddHouse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddHouse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddHouse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddHouse.Dock = DockStyle.Right;
            btnAddHouse.FillColor = Color.Transparent;
            btnAddHouse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddHouse.ForeColor = Color.White;
            btnAddHouse.HoverState.BorderColor = Color.LightGray;
            btnAddHouse.HoverState.CustomBorderColor = Color.LightGray;
            btnAddHouse.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            btnAddHouse.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnAddHouse.Image = (Image)resources.GetObject("btnAddHouse.Image");
            btnAddHouse.ImageOffset = new Point(1, 1);
            btnAddHouse.ImageSize = new Size(35, 35);
            btnAddHouse.Location = new Point(1158, 0);
            btnAddHouse.Name = "btnAddHouse";
            btnAddHouse.PressedColor = Color.Transparent;
            btnAddHouse.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAddHouse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAddHouse.Size = new Size(60, 54);
            btnAddHouse.TabIndex = 1;
            // 
            // flayoutHouse
            // 
            flayoutHouse.Dock = DockStyle.Fill;
            flayoutHouse.Location = new Point(0, 54);
            flayoutHouse.Name = "flayoutHouse";
            flayoutHouse.Size = new Size(1218, 513);
            flayoutHouse.TabIndex = 1;
            // 
            // HouseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flayoutHouse);
            Controls.Add(guna2GradientPanel1);
            Name = "HouseControl";
            Size = new Size(1218, 567);
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private FlowLayoutPanel flayoutHouse;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddHouse;
    }
}
