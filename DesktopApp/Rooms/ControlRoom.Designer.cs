namespace DesktopApp.Rooms
{
    partial class ControlRoom
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            addRoom = new FontAwesome.Sharp.IconButton();
            flayoutRoom = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Panel1MinSize = 6;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flayoutRoom);
            splitContainer1.Size = new Size(1082, 671);
            splitContainer1.SplitterDistance = 66;
            splitContainer1.SplitterIncrement = 10;
            splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(addRoom);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 66);
            panel1.TabIndex = 0;
            // 
            // addRoom
            // 
            addRoom.AutoSize = true;
            addRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addRoom.BackColor = Color.White;
            addRoom.Dock = DockStyle.Fill;
            addRoom.FlatAppearance.BorderColor = Color.White;
            addRoom.FlatAppearance.BorderSize = 0;
            addRoom.FlatAppearance.MouseDownBackColor = Color.Black;
            addRoom.FlatStyle = FlatStyle.Flat;
            addRoom.ForeColor = Color.White;
            addRoom.IconChar = FontAwesome.Sharp.IconChar.Arrows;
            addRoom.IconColor = Color.Black;
            addRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addRoom.Location = new Point(0, 0);
            addRoom.Name = "addRoom";
            addRoom.Rotation = 4D;
            addRoom.Size = new Size(94, 66);
            addRoom.TabIndex = 4;
            addRoom.UseVisualStyleBackColor = false;
            addRoom.Click += addRoom_Click;
            // 
            // flayoutRoom
            // 
            flayoutRoom.Dock = DockStyle.Fill;
            flayoutRoom.Location = new Point(0, 0);
            flayoutRoom.Name = "flayoutRoom";
            flayoutRoom.Size = new Size(1082, 601);
            flayoutRoom.TabIndex = 4;
            flayoutRoom.Click += addRoom_Click;
            // 
            // ControlRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ControlRoom";
            Size = new Size(1082, 671);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flayoutRoom;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton addRoom;
    }
}
