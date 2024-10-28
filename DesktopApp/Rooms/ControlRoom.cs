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

namespace DesktopApp.Rooms
{
    public partial class ControlRoom : UserControl
    {
        NewsRoom newsRoom = new NewsRoom();
        public ControlRoom()
        {
            InitializeComponent();
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            ShowDialogNewRoom();
        }

        private void ShowDialogNewRoom()
        {
            newsRoom.Luu_Click += NewsRoom_Luu_Click;
            newsRoom.Huy_Click += NewsRoom_Huy_Click;
            newsRoom.ShowDialog();


        }

        private void NewsRoom_Huy_Click(object sender, EventArgs e)
        {

            newsRoom.Close();
        }

        private void NewsRoom_Luu_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            item.itemTitle.Text = newsRoom.txtNameRoom.Text;
            item.itemThongTin.Text = newsRoom.txtTTRoom.Text;
            ShowItem(item);
            newsRoom.Close();

        }

        private void ShowItem(Items item)
        {

            newsRoom.Luu_Click -= NewsRoom_Luu_Click;
            newsRoom.Luu_Click -= NewsRoom_Luu_Click;
            item.Size = new Size(320, 180);
            item.Location = new Point(10, flayoutRoom.Controls.Count * 190);
            item.Dock = DockStyle.Top;
            flayoutRoom.Controls.Add(item);
        }
    }
}
