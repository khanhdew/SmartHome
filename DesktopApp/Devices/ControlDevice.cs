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
       
        DashBroad dashBroad = new DashBroad();
        SuaITem suaITem = new SuaITem();
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
            //
            item.itemTitle.Click -= Item_Title_CLick;
            item.btnSua.Click -= Item_SuaITem_Click;
            item.btnXoa.Click -= Item_XoaITem_Click;
        }

        private void ShowItem(Items item)
        {
            newsDevice.Luu_Click -= NewsDevice_Luu_Click;
            newsDevice.Huy_Click -= NewsDevice_Huy_Click;
            item.Dock = DockStyle.Top;
            item.Size = new Size(320, 180);
            item.Title_CLick += Item_Title_CLick;
            item.SuaITem_Click += Item_SuaITem_Click;
            item.XoaITem_Click += Item_XoaITem_Click;
            flayoutDevice.Controls.Add(item);
        }

        private void Item_XoaITem_Click(object sender, EventArgs e)
        {// xoa item
            Items item = (Items)sender;// ep kieu sender thanh Items 
            flayoutDevice.Controls.Remove(item);
        }

        private void Item_SuaITem_Click(object sender, EventArgs e)
        {
            suaITem.ShowDialog();

        }

        private void Item_Title_CLick(object sender, EventArgs e)
        {
           dashBroad.PanelMain.Controls.Clear();
            ControlHouse controlHouse = new ControlHouse();
            controlHouse.Dock = DockStyle.Fill;
            dashBroad.PanelMain.Controls.Add(controlHouse);
        }

       
    }
}
