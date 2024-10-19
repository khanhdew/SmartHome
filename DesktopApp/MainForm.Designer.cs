namespace DesktopApp
{
    partial class MainForm
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
            txtPassWord = new Krypton.Toolkit.KryptonTextBox();
            Panel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)Panel).BeginInit();
            SuspendLayout();
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(142, 441);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(419, 27);
            txtPassWord.TabIndex = 3;
            // 
            // Panel
            // 
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(1282, 683);
            Panel.StateCommon.Color1 = Color.White;
            Panel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1282, 683);
            Controls.Add(Panel);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)Panel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtPassWord;
        private Krypton.Toolkit.KryptonPanel PanelLogin;
        private Krypton.Toolkit.KryptonPanel Panel;
    }
}