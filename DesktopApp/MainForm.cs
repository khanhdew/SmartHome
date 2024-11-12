namespace DesktopApp;

public partial class MainForm : Form
{
    private readonly Login login;

    public MainForm(Login login)
    {
        InitializeComponent();
        this.login = login;
        ShowLogin();
        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //ShowLogin();
    }

    private void ShowLogin()
    {
      
        Panel.Controls.Clear();
        login.Dock = DockStyle.Fill;
        Panel.Controls.Add(login);

    }

    
}