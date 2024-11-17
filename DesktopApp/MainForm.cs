using DAO.BaseModels;

namespace DesktopApp;

public partial class MainForm : Form
{
    private readonly Login login;
    public static User LoggedInUser { get; set; }

    public MainForm(Login login)
    {
        InitializeComponent();
        this.login = login;
        ShowLogin();
        
    }



    private void ShowLogin()
    {
      
        Panel.Controls.Clear();
        login.Dock = DockStyle.Fill;
        Panel.Controls.Add(login);

    }

    
}