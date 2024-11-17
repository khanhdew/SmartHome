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

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomAdd : Form
    {
        private readonly IHouseService _houseService;
        private int houseId;
        public RoomAdd(IHouseService houseService, int houseId)
        {

            InitializeComponent();
            _houseService = houseService;
            this.houseId = houseId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(houseId == 0)
            {
                MessageBox.Show("Please select a house first");
                return;
            }
            var room = new DAO.BaseModels.Room
            {
                Name = txtName.Text,
                Detail = txtAddress.Text,
            };
            try
            {
                var newRoom = _houseService.AddRoomToHouse(houseId,room);
                MessageBox.Show("Room added successfully");
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
