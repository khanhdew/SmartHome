namespace DesktopApp.Controls.Setting
{
    public partial class SettingControl : UserControl
    {
        private IServiceProvider _serviceProvider;
        public SettingControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new AccountInfoControl(_serviceProvider));
            Parent.Controls.RemoveByKey("SettingControl");
        }
    }
}
