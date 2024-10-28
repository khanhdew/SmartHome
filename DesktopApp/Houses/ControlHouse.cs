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

namespace DesktopApp
{
    public partial class ControlHouse : UserControl
    {
        NewsHouse newsHouse = new NewsHouse();
        
        public ControlHouse()
        {
            InitializeComponent();
        }

        private void addHouse_Click(object sender, EventArgs e)
        {
            ShowDialogNewHouse();
        }

        private void ShowDialogNewHouse()
        {
            newsHouse.Luu_Click += NewsHouse_Luu_Click;
            newsHouse.Huy_Click += NewsHouse_Huy_Click;
            newsHouse.ShowDialog();

        }

        private void NewsHouse_Huy_Click(object sender, EventArgs e)
        {
            newsHouse.Close();
        }

        private void NewsHouse_Luu_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            item.itemTitle.Text = newsHouse.txtNameHouse.Text;
            item.itemThongTin.Text = newsHouse.txtTTHouse.Text;
            ShowItem(item);
            newsHouse.Close();

        }

        private void ShowItem(Items item)
        {
            newsHouse.Luu_Click -= NewsHouse_Luu_Click;
            newsHouse.Huy_Click -= NewsHouse_Huy_Click;
            item.Size = new Size(320, 180);
            item.Dock = DockStyle.Top;
            flayoutHouse.Controls.Add(item);
        }
    }
}
