namespace DesktopApp;

partial class MainForm
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
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        Panel = new Guna.UI2.WinForms.Guna2Panel();
        guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
        SuspendLayout();
        // 
        // Panel
        // 
        Panel.AutoScroll = true;
        Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Panel.BackColor = SystemColors.Control;
        Panel.CustomizableEdges = customizableEdges1;
        guna2Transition1.SetDecoration(Panel, Guna.UI2.AnimatorNS.DecorationType.None);
        Panel.Dock = DockStyle.Fill;
        Panel.Location = new Point(0, 0);
        Panel.Margin = new Padding(4);
        Panel.Name = "Panel";
        Panel.ShadowDecoration.CustomizableEdges = customizableEdges2;
        Panel.Size = new Size(1075, 602);
        Panel.TabIndex = 0;
        // 
        // guna2Transition1
        // 
        guna2Transition1.Cursor = null;
        animation1.AnimateOnlyDifferences = true;
        animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
        animation1.LeafCoeff = 0F;
        animation1.MaxTime = 1F;
        animation1.MinTime = 0F;
        animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
        animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
        animation1.MosaicSize = 0;
        animation1.Padding = new Padding(0);
        animation1.RotateCoeff = 0F;
        animation1.RotateLimit = 0F;
        animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
        animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
        animation1.TimeCoeff = 0F;
        animation1.TransparencyCoeff = 0F;
        guna2Transition1.DefaultAnimation = animation1;
        guna2Transition1.MaxAnimationTime = 1000;
        guna2Transition1.TimeStep = 0.01F;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1075, 602);
        Controls.Add(Panel);
        guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        Name = "MainForm";
        Text = "MainForm";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    public Guna.UI2.WinForms.Guna2Panel Panel;
    private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
}