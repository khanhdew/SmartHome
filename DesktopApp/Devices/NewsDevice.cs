using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Devices
{
    public partial class NewsDevice : Form
    {
        public NewsDevice()
        {
            InitializeComponent();
        }
        public event EventHandler? Luu_Click;
        public event EventHandler? Huy_Click;

        private void OnLuuClicked(EventArgs e)
        {
            Luu_Click?.Invoke(this, e);
        }

        private void OnHuyClicked(EventArgs e)
        {
            Huy_Click?.Invoke(this, e);
        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            OnLuuClicked(EventArgs.Empty);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            OnHuyClicked(EventArgs.Empty);
        }
    }

}
