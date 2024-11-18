using DAO.BaseModels;
using DesktopApp.Controls.Rooms;
using DesktopApp.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Devices;
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
    public partial class HouseControl : UserControl
    {
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        IEnumerable<House> houseList;
        public HouseControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            houseList = _houseService.GetHousesByUserId(MainForm.LoggedInUser.Id);
        }

        private void HouseControl_Load(object sender, EventArgs e)
        {
            LoadHouses(houseList);
        }

        private void LoadHouses(IEnumerable<House> houses)
        {
            try
            {
                fLayoutPanel.Controls.Clear();
                foreach (var house in houses)
                {
                    var houseViewControl = new HouseViewUserControl(house, _serviceProvider)
                    {
                        lblTenNha = { Text = house.Name },
                        lblThongtinNha = { Text = house.Location },
                        Margin = new Padding(10)
                    };
                    houseViewControl.btnSuaNha.Click += (sender, e) =>
                    {
                        if (!_houseService.GetHouseOwner(house.ID).Id.Equals(MainForm.LoggedInUser.Id))
                        {
                            MessageBox.Show("Bạn không có quyền sửa nhà này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var houseEdit = new HouseEdit(house.ID, _serviceProvider);
                        Controls.Clear();
                        Controls.Add(houseEdit);
                       
                    };
                    houseViewControl.lblTenNha.Click += (sender, e) =>
                    {
                        var roomControl = new RoomControl(house.ID, _serviceProvider);
                        roomControl.Dock = DockStyle.Fill;
                        Controls.Clear();
                        Controls.Add(roomControl);
                        
                    };
                    fLayoutPanel.Controls.Add(houseViewControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var houseAddControl = new HouseAdd(_houseService);
            houseAddControl.ShowDialog();
            LoadHouses(houseList);
        }

        internal void SearchHouses(string keyword)
        {
            var houses = houseList;
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = StringProcessHelper.RemoveDiacritics(keyword);
                houses = houses.Where(h => StringProcessHelper.RemoveDiacritics(h.Name).Contains(keyword, StringComparison.OrdinalIgnoreCase) || StringProcessHelper.RemoveDiacritics(h.Location).Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
                LoadHouses(houses);
            }
            else
            {
                LoadHouses(houseList);
            }
        }
    }
}
