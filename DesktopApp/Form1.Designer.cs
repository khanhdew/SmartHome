namespace DesktopApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Panel = new Guna.UI2.WinForms.Guna2Panel();
        SuspendLayout();
        // 
        // Panel
        // 
        Panel.BackColor = SystemColors.Control;
        Panel.CustomizableEdges = customizableEdges1;
        Panel.Dock = DockStyle.Fill;
        Panel.Location = new Point(0, 0);
        Panel.Name = "Panel";
        Panel.ShadowDecoration.CustomizableEdges = customizableEdges2;
        Panel.Size = new Size(1124, 516);
        Panel.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1124, 516);
        Controls.Add(Panel);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Guna.UI2.WinForms.Guna2Panel Panel;
}