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
            menuDevice = new FontAwesome.Sharp.IconButton();
            menuRoom = new FontAwesome.Sharp.IconButton();
            menuSetting = new FontAwesome.Sharp.IconButton();
            menuExit = new FontAwesome.Sharp.IconButton();
            menuHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            AnhLogo = new PictureBox();
            PanelTitleBar = new Krypton.Toolkit.KryptonPanel();
            DashMode = new FontAwesome.Sharp.IconButton();
            navTenUser = new FontAwesome.Sharp.IconButton();
            navBacham = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            PanelMain = new Krypton.Toolkit.KryptonPanel();
            MenuBaCham = new ContextMenuStrip(components);
            Account = new FontAwesome.Sharp.IconMenuItem();
            Logout = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)PanelMenu).BeginInit();
            PanelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelTitleBar).BeginInit();
            PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelMain).BeginInit();
            MenuBaCham.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Controls.Add(menuDevice);
            PanelMenu.Controls.Add(menuRoom);
            PanelMenu.Controls.Add(menuSetting);
            PanelMenu.Controls.Add(menuExit);
            PanelMenu.Controls.Add(menuHome);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(218, 730);
            PanelMenu.StateNormal.Color1 = Color.FromArgb(0, 105, 91);
            PanelMenu.StateNormal.Color2 = Color.Transparent;
            PanelMenu.TabIndex = 1;
            // 
            // menuDevice
            // 
            menuDevice.BackColor = Color.Transparent;
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
            menuRoom.BackColor = Color.Transparent;
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
            menuSetting.BackColor = Color.Transparent;
            menuSetting.Dock = DockStyle.Bottom;
            menuSetting.FlatAppearance.BorderSize = 0;
            menuSetting.FlatStyle = FlatStyle.Flat;
            menuSetting.Font = new Font("Cascadia Code SemiBold", 4.2F, FontStyle.Bold, GraphicsUnit.Millimeter);
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
            // 
            // menuExit
            // 
            menuExit.BackColor = Color.Transparent;
            menuExit.Dock = DockStyle.Bottom;
            menuExit.FlatAppearance.BorderSize = 0;
            menuExit.FlatStyle = FlatStyle.Flat;
            menuExit.Font = new Font("Cascadia Code SemiBold", 4.2F, FontStyle.Bold, GraphicsUnit.Millimeter);
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
            // 
            // menuHome
            // 
            menuHome.BackColor = Color.Transparent;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(AnhLogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 59);
            panel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 35;
            btnMenu.Location = new Point(138, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10);
            btnMenu.Size = new Size(80, 59);
            btnMenu.TabIndex = 0;
            btnMenu.Tag = "Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // AnhLogo
            // 
            AnhLogo.BackColor = Color.Transparent;
            AnhLogo.Dock = DockStyle.Left;
            AnhLogo.Image = (Image)resources.GetObject("AnhLogo.Image");
            AnhLogo.Location = new Point(0, 0);
            AnhLogo.Name = "AnhLogo";
            AnhLogo.Size = new Size(138, 59);
            AnhLogo.SizeMode = PictureBoxSizeMode.Zoom;
            AnhLogo.TabIndex = 0;
            AnhLogo.TabStop = false;
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.Controls.Add(DashMode);
            PanelTitleBar.Controls.Add(navTenUser);
            PanelTitleBar.Controls.Add(navBacham);
            PanelTitleBar.Controls.Add(label1);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(218, 0);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Padding = new Padding(1);
            PanelTitleBar.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            PanelTitleBar.Size = new Size(1082, 59);
            PanelTitleBar.StateNormal.Color1 = Color.FromArgb(0, 105, 91);
            PanelTitleBar.StateNormal.Color2 = Color.FromArgb(0, 105, 91);
            PanelTitleBar.TabIndex = 2;
            // 
            // DashMode
            // 
            DashMode.AutoSize = true;
            DashMode.BackColor = Color.Transparent;
            DashMode.Dock = DockStyle.Right;
            DashMode.FlatAppearance.BorderColor = Color.White;
            DashMode.FlatAppearance.BorderSize = 0;
            DashMode.FlatAppearance.MouseDownBackColor = Color.Black;
            DashMode.FlatStyle = FlatStyle.Flat;
            DashMode.ForeColor = Color.Transparent;
            DashMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            DashMode.IconColor = Color.White;
            DashMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashMode.Location = new Point(758, 1);
            DashMode.Name = "DashMode";
            DashMode.Size = new Size(56, 57);
            DashMode.TabIndex = 0;
            DashMode.UseVisualStyleBackColor = false;
            DashMode.Click += DashMode_Click;
            // 
            // navTenUser
            // 
            navTenUser.BackColor = Color.Transparent;
            navTenUser.Dock = DockStyle.Right;
            navTenUser.FlatAppearance.BorderSize = 0;
            navTenUser.FlatStyle = FlatStyle.Flat;
            navTenUser.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            navTenUser.ForeColor = Color.White;
            navTenUser.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            navTenUser.IconColor = Color.White;
            navTenUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            navTenUser.IconSize = 35;
            navTenUser.ImageAlign = ContentAlignment.MiddleLeft;
            navTenUser.Location = new Point(814, 1);
            navTenUser.Name = "navTenUser";
            navTenUser.Size = new Size(224, 57);
            navTenUser.TabIndex = 1;
            navTenUser.Text = "Vũ Mạnh Cường";
            navTenUser.UseVisualStyleBackColor = false;
            // 
            // navBacham
            // 
            navBacham.BackColor = Color.Transparent;
            navBacham.Dock = DockStyle.Right;
            navBacham.FlatAppearance.BorderSize = 0;
            navBacham.FlatStyle = FlatStyle.Flat;
            navBacham.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            navBacham.IconColor = Color.White;
            navBacham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            navBacham.IconSize = 28;
            navBacham.Location = new Point(1038, 1);
            navBacham.Name = "navBacham";
            navBacham.Size = new Size(43, 57);
            navBacham.TabIndex = 2;
            navBacham.UseVisualStyleBackColor = false;
            navBacham.Click += navBacham_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(206, 57);
            label1.TabIndex = 0;
            label1.Text = "Smart Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(218, 59);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1082, 671);
            PanelMain.StateNormal.Color1 = Color.FromArgb(244, 244, 254);
            PanelMain.TabIndex = 3;
            // 
            // MenuBaCham
            // 
            MenuBaCham.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MenuBaCham.ImageScalingSize = new Size(20, 20);
            MenuBaCham.Items.AddRange(new ToolStripItem[] { Account, Logout });
            MenuBaCham.Name = "contextMenuStrip1";
            MenuBaCham.Size = new Size(147, 60);
            // 
            // Account
            // 
            Account.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Account.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            Account.IconColor = Color.Black;
            Account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Account.Name = "Account";
            Account.Size = new Size(146, 28);
            Account.Text = "Account";
            // 
            // Logout
            // 
            Logout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.IconChar = FontAwesome.Sharp.IconChar.None;
            Logout.IconColor = Color.Black;
            Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Logout.Name = "Logout";
            Logout.Size = new Size(146, 28);
            Logout.Text = "Logout";
            // 
            // DashBroad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(PanelMain);
            Controls.Add(PanelTitleBar);
            Controls.Add(PanelMenu);
            Name = "DashBroad";
            Size = new Size(1300, 730);
            ((System.ComponentModel.ISupportInitialize)PanelMenu).EndInit();
            PanelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnhLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelTitleBar).EndInit();
            PanelTitleBar.ResumeLayout(false);
            PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PanelMain).EndInit();
            MenuBaCham.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel PanelMenu;
        private Krypton.Toolkit.KryptonPanel PanelTitleBar;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel panel2;
        private PictureBox AnhLogo;
        private FontAwesome.Sharp.IconButton menuHome;
        private FontAwesome.Sharp.IconButton menuExit;
        private FontAwesome.Sharp.IconButton menuSetting;
        private Label label1;
        private FontAwesome.Sharp.IconButton navTenUser;
        private FontAwesome.Sharp.IconButton navBacham;
        private FontAwesome.Sharp.IconButton menuDevice;
        private FontAwesome.Sharp.IconButton menuRoom;
        private ContextMenuStrip MenuBaCham;
        private FontAwesome.Sharp.IconMenuItem Account;
        private FontAwesome.Sharp.IconMenuItem Logout;
        public Krypton.Toolkit.KryptonPanel PanelMain;
        public FontAwesome.Sharp.IconButton DashMode;
    }
}
