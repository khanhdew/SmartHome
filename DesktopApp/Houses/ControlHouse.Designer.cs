namespace DesktopApp
{
    partial class ControlHouse
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
            addHouse = new FontAwesome.Sharp.IconButton();
            flayoutHouse = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(addHouse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 56);
            panel1.TabIndex = 0;
            // 
            // addHouse
            // 
            addHouse.AutoSize = true;
            addHouse.BackColor = Color.Transparent;
            addHouse.Dock = DockStyle.Left;
            addHouse.FlatAppearance.BorderColor = Color.White;
            addHouse.FlatAppearance.BorderSize = 0;
            addHouse.FlatAppearance.MouseDownBackColor = Color.Black;
            addHouse.FlatStyle = FlatStyle.Flat;
            addHouse.ForeColor = Color.White;
            addHouse.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addHouse.IconColor = Color.Black;
            addHouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addHouse.Location = new Point(0, 0);
            addHouse.Name = "addHouse";
            addHouse.Size = new Size(54, 56);
            addHouse.TabIndex = 2;
            addHouse.UseVisualStyleBackColor = false;
            addHouse.Click += addHouse_Click;
            // 
            // flayoutHouse
            // 
            flayoutHouse.Dock = DockStyle.Fill;
            flayoutHouse.Location = new Point(0, 56);
            flayoutHouse.Name = "flayoutHouse";
            flayoutHouse.Size = new Size(1082, 615);
            flayoutHouse.TabIndex = 1;
            // 
            // ControlHouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flayoutHouse);
            Controls.Add(panel1);
            Name = "ControlHouse";
            Size = new Size(1082, 671);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton addHouse;
        private FlowLayoutPanel flayoutHouse;
    }
}
