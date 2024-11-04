using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Houses
{
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }
        public event EventHandler? Title_CLick;
        public event EventHandler? SuaITem_Click;
        public event EventHandler? XoaITem_Click;

       private void OnTitleClicked(EventArgs e)
        {
            Title_CLick?.Invoke(this, e);
        }

        private void OnSuaClicked(EventArgs e)
        {
            SuaITem_Click?.Invoke(this, e);
        }

        private void OnXoaClicked(EventArgs e)
        {
            XoaITem_Click?.Invoke(this, e);
        }

        private void itemTitle_Click(object sender, EventArgs e)
        {
          OnTitleClicked(EventArgs.Empty);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OnSuaClicked(EventArgs.Empty);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OnXoaClicked(EventArgs.Empty);
        }
    }
}
