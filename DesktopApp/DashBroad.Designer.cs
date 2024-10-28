namespace DesktopApp
{
    partial class DashBroad
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBroad));
            PanelMenu = new Krypton.Toolkit.KryptonPanel();
<<<<<<< Updated upstream
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
=======
            menuDevice = new FontAwesome.Sharp.IconButton();
            menuRoom = new FontAwesome.Sharp.IconButton();
            menuSetting = new FontAwesome.Sharp.IconButton();
            menuExit = new FontAwesome.Sharp.IconButton();
            menuHome = new FontAwesome.Sharp.IconButton();
>>>>>>> Stashed changes
            panel2 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            AnhLogo = new PictureBox();
            PanelTitleBar = new Krypton.Toolkit.KryptonPanel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconBaCham = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            PanelMain = new Krypton.Toolkit.KryptonPanel();
<<<<<<< Updated upstream
=======
            contextMenuStrip = new ContextMenuStrip(components);
            Account = new FontAwesome.Sharp.IconMenuItem();
            Exit = new FontAwesome.Sharp.IconMenuItem();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            DashMode = new FontAwesome.Sharp.IconButton();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)PanelMenu).BeginInit();
            PanelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelTitleBar).BeginInit();
            PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelMain).BeginInit();
<<<<<<< Updated upstream
=======
            contextMenuStrip.SuspendLayout();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // PanelMenu
            // 
<<<<<<< Updated upstream
            PanelMenu.Controls.Add(iconButton6);
            PanelMenu.Controls.Add(iconButton5);
            PanelMenu.Controls.Add(iconButton7);
            PanelMenu.Controls.Add(iconButton4);
            PanelMenu.Controls.Add(iconButton3);
            PanelMenu.Controls.Add(iconButton2);
=======
            PanelMenu.Controls.Add(menuDevice);
            PanelMenu.Controls.Add(menuRoom);
            PanelMenu.Controls.Add(menuSetting);
            PanelMenu.Controls.Add(menuExit);
            PanelMenu.Controls.Add(menuHome);
>>>>>>> Stashed changes
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(218, 731);
            PanelMenu.StateNormal.Color1 = Color.FromArgb(97, 102, 246);
            PanelMenu.TabIndex = 1;
            // 
            // menuDevice
            // 
<<<<<<< Updated upstream
            iconButton6.BackColor = Color.FromArgb(97, 102, 246);
            iconButton6.Dock = DockStyle.Bottom;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 649);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(10, 0, 0, 0);
            iconButton6.Size = new Size(218, 41);
            iconButton6.TabIndex = 9;
            iconButton6.Tag = "5";
            iconButton6.Text = "Setting";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(97, 102, 246);
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 227);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 0, 0);
            iconButton5.Size = new Size(218, 41);
            iconButton5.TabIndex = 8;
            iconButton5.Tag = "4";
            iconButton5.Text = "Home";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(97, 102, 246);
            iconButton7.Dock = DockStyle.Bottom;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 30;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 690);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(10, 0, 0, 0);
            iconButton7.Size = new Size(218, 41);
            iconButton7.TabIndex = 7;
            iconButton7.Tag = "6";
            iconButton7.Text = "   Home";
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = false;
=======
            menuDevice.BackColor = Color.FromArgb(97, 102, 246);
            menuDevice.Dock = DockStyle.Top;
            menuDevice.FlatAppearance.BorderSize = 0;
            menuDevice.FlatStyle = FlatStyle.Flat;
            menuDevice.Font = new Font("Cascadia Code SemiBold", 4.2F, FontStyle.Bold, GraphicsUnit.Millimeter);
            menuDevice.ForeColor = Color.White;
            menuDevice.IconChar = FontAwesome.Sharp.IconChar.Computer;
            menuDevice.IconColor = Color.White;
            menuDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuDevice.IconSize = 33;
            menuDevice.ImageAlign = ContentAlignment.MiddleLeft;
            menuDevice.Location = new Point(0, 189);
            menuDevice.Name = "menuDevice";
            menuDevice.Padding = new Padding(10, 0, 0, 0);
            menuDevice.Size = new Size(218, 65);
            menuDevice.TabIndex = 11;
            menuDevice.Tag = "Device";
            menuDevice.Text = "Device";
            menuDevice.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuDevice.UseVisualStyleBackColor = false;
            menuDevice.Click += menuDevice_Click;
            // 
            // menuRoom
            // 
            menuRoom.BackColor = Color.FromArgb(97, 102, 246);
            menuRoom.Dock = DockStyle.Top;
            menuRoom.FlatAppearance.BorderSize = 0;
            menuRoom.FlatStyle = FlatStyle.Flat;
            menuRoom.Font = new Font("Cascadia Code SemiBold", 4.2F, FontStyle.Bold, GraphicsUnit.Millimeter);
            menuRoom.ForeColor = Color.White;
            menuRoom.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            menuRoom.IconColor = Color.White;
            menuRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuRoom.IconSize = 33;
            menuRoom.ImageAlign = ContentAlignment.MiddleLeft;
            menuRoom.Location = new Point(0, 124);
            menuRoom.Name = "menuRoom";
            menuRoom.Padding = new Padding(10, 0, 0, 0);
            menuRoom.Size = new Size(218, 65);
            menuRoom.TabIndex = 10;
            menuRoom.Tag = "Room";
            menuRoom.Text = "Room";
            menuRoom.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuRoom.UseVisualStyleBackColor = false;
            menuRoom.Click += menuRoom_Click;
            // 
            // menuSetting
            // 
            menuSetting.BackColor = Color.FromArgb(97, 102, 246);
            menuSetting.Dock = DockStyle.Bottom;
            menuSetting.FlatAppearance.BorderSize = 0;
            menuSetting.FlatStyle = FlatStyle.Flat;
            menuSetting.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuSetting.ForeColor = Color.White;
            menuSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            menuSetting.IconColor = Color.White;
            menuSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuSetting.IconSize = 33;
            menuSetting.ImageAlign = ContentAlignment.MiddleLeft;
            menuSetting.Location = new Point(0, 620);
            menuSetting.Name = "menuSetting";
            menuSetting.Padding = new Padding(3);
            menuSetting.Size = new Size(218, 63);
            menuSetting.TabIndex = 9;
            menuSetting.Tag = "Setting";
            menuSetting.Text = "Setting";
            menuSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuSetting.UseVisualStyleBackColor = false;
            menuSetting.Click += menuSetting_Click;
            // 
            // menuExit
            // 
            menuExit.BackColor = Color.FromArgb(97, 102, 246);
            menuExit.Dock = DockStyle.Bottom;
            menuExit.FlatAppearance.BorderSize = 0;
            menuExit.FlatStyle = FlatStyle.Flat;
            menuExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menuExit.ForeColor = Color.White;
            menuExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            menuExit.IconColor = Color.White;
            menuExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuExit.IconSize = 33;
            menuExit.ImageAlign = ContentAlignment.MiddleLeft;
            menuExit.Location = new Point(0, 683);
            menuExit.Name = "menuExit";
            menuExit.Padding = new Padding(10, 0, 0, 0);
            menuExit.Size = new Size(218, 47);
            menuExit.TabIndex = 7;
            menuExit.Tag = "Exit";
            menuExit.Text = "Exit";
            menuExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuExit.UseVisualStyleBackColor = false;
            menuExit.Click += menuExit_Click;
>>>>>>> Stashed changes
            // 
            // iconButton4
            // 
<<<<<<< Updated upstream
            iconButton4.BackColor = Color.FromArgb(97, 102, 246);
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 186);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 0, 0);
            iconButton4.Size = new Size(218, 41);
            iconButton4.TabIndex = 4;
            iconButton4.Tag = "3";
            iconButton4.Text = "Home";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(97, 102, 246);
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 145);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 0, 0);
            iconButton3.Size = new Size(218, 41);
            iconButton3.TabIndex = 3;
            iconButton3.Tag = "2";
            iconButton3.Text = "Home";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(97, 102, 246);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 104);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(218, 41);
            iconButton2.TabIndex = 2;
            iconButton2.Tag = "1";
            iconButton2.Text = "Home";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
=======
            menuHome.BackColor = Color.FromArgb(97, 102, 246);
            menuHome.Dock = DockStyle.Top;
            menuHome.FlatAppearance.BorderSize = 0;
            menuHome.FlatStyle = FlatStyle.Flat;
            menuHome.Font = new Font("Cascadia Code SemiBold", 4.2F, FontStyle.Bold, GraphicsUnit.Millimeter);
            menuHome.ForeColor = Color.White;
            menuHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            menuHome.IconColor = Color.White;
            menuHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHome.IconSize = 33;
            menuHome.ImageAlign = ContentAlignment.MiddleLeft;
            menuHome.Location = new Point(0, 59);
            menuHome.Margin = new Padding(10);
            menuHome.Name = "menuHome";
            menuHome.Padding = new Padding(10, 0, 0, 0);
            menuHome.Size = new Size(218, 65);
            menuHome.TabIndex = 2;
            menuHome.Tag = "House";
            menuHome.Text = "House";
            menuHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuHome.UseVisualStyleBackColor = false;
            menuHome.Click += menuHome_Click;
>>>>>>> Stashed changes
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(97, 102, 246);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(AnhLogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 104);
            panel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 35;
            btnMenu.Location = new Point(133, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(85, 53);
            btnMenu.TabIndex = 0;
            btnMenu.Tag = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // AnhLogo
            // 
            AnhLogo.Dock = DockStyle.Left;
            AnhLogo.Image = (Image)resources.GetObject("AnhLogo.Image");
            AnhLogo.Location = new Point(0, 0);
            AnhLogo.Name = "AnhLogo";
            AnhLogo.Size = new Size(133, 104);
            AnhLogo.SizeMode = PictureBoxSizeMode.Zoom;
            AnhLogo.TabIndex = 0;
            AnhLogo.TabStop = false;
            // 
            // PanelTitleBar
            // 
<<<<<<< Updated upstream
=======
            PanelTitleBar.Controls.Add(DashMode);
            PanelTitleBar.Controls.Add(iconButton1);
>>>>>>> Stashed changes
            PanelTitleBar.Controls.Add(iconButton8);
            PanelTitleBar.Controls.Add(iconBaCham);
            PanelTitleBar.Controls.Add(label1);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(218, 0);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1083, 59);
            PanelTitleBar.StateNormal.Color1 = Color.FromArgb(0, 105, 91);
            PanelTitleBar.StateNormal.Color2 = Color.FromArgb(0, 105, 91);
            PanelTitleBar.TabIndex = 2;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(0, 105, 91);
            iconButton8.Dock = DockStyle.Right;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 35;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(831, 0);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(209, 59);
            iconButton8.TabIndex = 1;
            iconButton8.Text = "Vũ Mạnh Cường";
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconBaCham
            // 
<<<<<<< Updated upstream
            iconButton9.BackColor = Color.FromArgb(0, 105, 91);
            iconButton9.Dock = DockStyle.Right;
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 28;
            iconButton9.Location = new Point(1040, 0);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(43, 59);
            iconButton9.TabIndex = 2;
            iconButton9.UseVisualStyleBackColor = false;
=======
            iconBaCham.BackColor = Color.FromArgb(0, 105, 91);
            iconBaCham.Dock = DockStyle.Right;
            iconBaCham.FlatAppearance.BorderSize = 0;
            iconBaCham.FlatStyle = FlatStyle.Flat;
            iconBaCham.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            iconBaCham.IconColor = Color.White;
            iconBaCham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBaCham.IconSize = 28;
            iconBaCham.Location = new Point(1039, 0);
            iconBaCham.Name = "iconBaCham";
            iconBaCham.Size = new Size(43, 59);
            iconBaCham.TabIndex = 2;
            iconBaCham.UseVisualStyleBackColor = false;
            iconBaCham.Click += iconBaCham_Click;
>>>>>>> Stashed changes
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 105, 91);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 59);
            label1.TabIndex = 0;
            label1.Text = "Smart Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(218, 59);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1083, 672);
            PanelMain.StateNormal.Color1 = Color.FromArgb(244, 244, 254);
            PanelMain.TabIndex = 3;
            // 
<<<<<<< Updated upstream
=======
            // contextMenuStrip
            // 
            contextMenuStrip.BackColor = Color.White;
            contextMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { Account, Exit });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip.ShowCheckMargin = true;
            contextMenuStrip.Size = new Size(171, 60);
            // 
            // Account
            // 
            Account.Alignment = ToolStripItemAlignment.Right;
            Account.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Account.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            Account.IconColor = Color.Black;
            Account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Account.IconSize = 53;
            Account.Name = "Account";
            Account.Size = new Size(236, 28);
            Account.Text = "Account";
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            Exit.IconColor = Color.Black;
            Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Exit.IconSize = 53;
            Exit.Name = "Exit";
            Exit.Size = new Size(236, 28);
            Exit.Text = "Exit";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Turquoise;
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 37;
            iconButton1.Location = new Point(772, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(58, 59);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // DashMode
            // 
            DashMode.AutoSize = true;
            DashMode.BackColor = Color.FromArgb(0, 29, 53);
            DashMode.Dock = DockStyle.Right;
            DashMode.FlatAppearance.BorderColor = Color.White;
            DashMode.FlatAppearance.BorderSize = 0;
            DashMode.FlatAppearance.MouseDownBackColor = Color.Black;
            DashMode.FlatStyle = FlatStyle.Flat;
            DashMode.ForeColor = Color.Transparent;
            DashMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            DashMode.IconColor = Color.White;
            DashMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashMode.Location = new Point(716, 0);
            DashMode.Name = "DashMode";
            DashMode.Size = new Size(56, 59);
            DashMode.TabIndex = 3;
            DashMode.UseVisualStyleBackColor = false;
            // 
>>>>>>> Stashed changes
            // DashBroad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(PanelMain);
            Controls.Add(PanelTitleBar);
            Controls.Add(PanelMenu);
            Name = "DashBroad";
            Size = new Size(1301, 731);
            ((System.ComponentModel.ISupportInitialize)PanelMenu).EndInit();
            PanelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnhLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelTitleBar).EndInit();
            PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelMain).EndInit();
<<<<<<< Updated upstream
=======
            contextMenuStrip.ResumeLayout(false);
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel PanelMenu;
        private Krypton.Toolkit.KryptonPanel PanelTitleBar;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Krypton.Toolkit.KryptonPanel PanelMain;
        private Panel panel2;
        private PictureBox AnhLogo;
<<<<<<< Updated upstream
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton9;
        public FontAwesome.Sharp.IconButton iconButton8;
=======
        private FontAwesome.Sharp.IconButton menuHome;
        private FontAwesome.Sharp.IconButton menuExit;
        private FontAwesome.Sharp.IconButton menuSetting;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconBaCham;
        private FontAwesome.Sharp.IconButton menuDevice;
        private FontAwesome.Sharp.IconButton menuRoom;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem Account;
        private FontAwesome.Sharp.IconMenuItem Exit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton DashMode;
>>>>>>> Stashed changes
    }
}
