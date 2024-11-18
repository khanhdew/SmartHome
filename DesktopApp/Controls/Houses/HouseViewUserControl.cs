using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Controls.Houses
{
    public partial class HouseViewUserControl : UserControl
    {
        private readonly House house;
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        public HouseViewUserControl(House house, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.house = house;
            _serviceProvider = serviceProvider;
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            BackColor = Color.Transparent;
        }

        private void btnXoaNha_Click(object sender, EventArgs e)
        {
            if (!_houseService.GetHouseOwner(house.ID).Id.Equals(MainForm.LoggedInUser.Id))
            {
                MessageBox.Show("Bạn không có quyền xóa nhà này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Nhà đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _houseService.DeleteHouse(house.ID);
                Parent.Controls.Remove(this);
            }
        }

        internal void btnSuaNha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
