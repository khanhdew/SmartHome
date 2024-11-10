namespace DesktopApp;

public partial class MainForm : Form
{
    Login login;
   
    public MainForm()
    {
        InitializeComponent();
        login = new Login(this);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ShowLogin();
    }

    private void ShowLogin()
    {
        Panel.Controls.Clear();
        login.Dock = DockStyle.Fill;
        Panel.Controls.Add(login);

    }

    
}