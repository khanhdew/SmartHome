﻿namespace DesktopApp.Controls.Devices
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            addBtn = new Guna.UI2.WinForms.Guna2Button();
            fLayoutPanel = new FlowLayoutPanel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(addBtn);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Right;
            guna2Panel1.Location = new Point(1146, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(72, 500);
            guna2Panel1.TabIndex = 6;
            // 
            // addBtn
            // 
            addBtn.CustomizableEdges = customizableEdges1;
            addBtn.DisabledState.BorderColor = Color.DarkGray;
            addBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addBtn.FillColor = Color.Transparent;
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.White;
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.Location = new Point(3, 18);
            addBtn.Name = "addBtn";
            addBtn.PressedColor = Color.Transparent;
            addBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            addBtn.Size = new Size(50, 29);
            addBtn.TabIndex = 0;
            addBtn.Click += addBtn_Click;
            // 
            // fLayoutPanel
            // 
            fLayoutPanel.AutoScroll = true;
            fLayoutPanel.BackColor = Color.Transparent;
            fLayoutPanel.Dock = DockStyle.Fill;
            fLayoutPanel.Location = new Point(0, 0);
            fLayoutPanel.Name = "fLayoutPanel";
            fLayoutPanel.Size = new Size(1218, 500);
            fLayoutPanel.TabIndex = 5;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(guna2Panel1);
            Controls.Add(fLayoutPanel);
            Name = "DeviceControl";
            Size = new Size(1218, 500);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private FlowLayoutPanel fLayoutPanel;
    }
}
