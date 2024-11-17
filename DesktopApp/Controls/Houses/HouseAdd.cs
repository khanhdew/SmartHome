using DAO.BaseModels;
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
    public partial class HouseAdd : Form
    {
        private readonly IHouseService _houseService;
        public HouseAdd(IHouseService houseService)
        {
            InitializeComponent();
            _houseService = houseService;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var house = new House
            {
                Name = txtHouseName.Text,
                Location = txtHouseAddress.Text
            };
            try
            {
                var newHouse = _houseService.CreateHouse(house.Name, house.Location);
                // add house to logged in user
                _houseService.AddHouseMember(MainForm.LoggedInUser.Id, newHouse.ID, "Owner");
                MessageBox.Show("House added successfully");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
