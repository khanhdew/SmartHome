using DAO.Context;
namespace DesktopApp
{
    public partial class MainForm : Form
    {
        private readonly DbContext _context;
        public MainForm(DbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = _context.Users.ToList();
            foreach (var user in users)
            {
                lBox.Items.Add(user.Username);
            }
        }
    }
}
