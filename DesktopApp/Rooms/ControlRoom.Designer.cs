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
            flayoutRoom = new FlowLayoutPanel();
            addRoom = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(addRoom);
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
            // flayoutRoom
            // 
            flayoutRoom.Dock = DockStyle.Fill;
            flayoutRoom.Location = new Point(0, 0);
            flayoutRoom.Name = "flayoutRoom";
            flayoutRoom.Size = new Size(1082, 601);
            flayoutRoom.TabIndex = 4;
            // 
            // addRoom
            // 
            addRoom.AutoSize = true;
            addRoom.BackColor = Color.Transparent;
            addRoom.Dock = DockStyle.Left;
            addRoom.FlatAppearance.BorderColor = Color.White;
            addRoom.FlatAppearance.BorderSize = 0;
            addRoom.FlatAppearance.MouseDownBackColor = Color.Black;
            addRoom.FlatStyle = FlatStyle.Flat;
            addRoom.ForeColor = Color.White;
            addRoom.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addRoom.IconColor = Color.Black;
            addRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addRoom.Location = new Point(0, 0);
            addRoom.Name = "addRoom";
            addRoom.Size = new Size(54, 66);
            addRoom.TabIndex = 3;
            addRoom.UseVisualStyleBackColor = false;
            addRoom.Click += addRoom_Click;
            // 
            // ControlRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ControlRoom";
            Size = new Size(1082, 671);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flayoutRoom;
        private FontAwesome.Sharp.IconButton addRoom;
    }
}
