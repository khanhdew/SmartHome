using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
