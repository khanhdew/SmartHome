using DesktopApp.Houses;
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
    public partial class ControlDevice : UserControl
    {
        NewsDevice newsDevice = new NewsDevice();
        public ControlDevice()
        {
            InitializeComponent();
        }

        private void addDevice_Click(object sender, EventArgs e)
        {
            ShowDiaLogDevice();
        }

        private void ShowDiaLogDevice()
        {
            newsDevice.Luu_Click += NewsDevice_Luu_Click;
            newsDevice.Huy_Click += NewsDevice_Huy_Click;
            newsDevice.ShowDialog();
        }

        private void NewsDevice_Huy_Click(object sender, EventArgs e)
        {
            newsDevice.Close();
        }

        private void NewsDevice_Luu_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            item.itemTitle.Text = newsDevice.txtNameDevice.Text;
            item.itemThongTin.Text = newsDevice.txtTTDevice.Text;
            ShowItem(item);
            newsDevice.Close();
        }

        private void ShowItem(Items item)
        {
            newsDevice.Luu_Click -= NewsDevice_Luu_Click;
            newsDevice.Huy_Click -= NewsDevice_Huy_Click;
            item.Dock = DockStyle.Top;
            item.Size = new Size(320, 180);
            
            flayoutDevice.Controls.Add(item);
        }



    }
}
