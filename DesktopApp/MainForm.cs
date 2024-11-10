namespace DesktopApp;

public partial class MainForm : Form
{
    Login login= new Login();

    public MainForm()
    {
        InitializeComponent();
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