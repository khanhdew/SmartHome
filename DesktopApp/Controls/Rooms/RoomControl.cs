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

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomControl : UserControl
    {
        private readonly IRoomService _roomService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IHouseService _houseService;
        private List<Room> roomList = new List<Room>();
        public RoomControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            LoadHouses();
            MessageBox.Show(roomList.Count().ToString());
            LoadRooms(roomList);
        }

        private void LoadHouses()
        {
            var houses = _houseService.GetHousesByUserId(MainForm.LoggedInUser.Id);

            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                roomList.AddRange(rooms);
            }

        }

        private void LoadRooms(IEnumerable<Room> rooms)
        {
            try
            {
                fLayoutPanel.Controls.Clear();
                foreach (var room in rooms)
                {
                    var roomViewControl = new RoomViewUserControl(room, _serviceProvider)
                    {
                        lblTenPhong = { Text = room.Name },
                        lblThongtinPhong = { Text = room.Detail },
                        Margin = new Padding(10)
                    };
                    roomViewControl.btnSuaPhong.Click += (sender, e) =>
                    {
                        var roomEdit = new RoomEdit(room.ID, _serviceProvider);
                        Controls.Clear();
                        Controls.Add(roomEdit);
                    };
                    fLayoutPanel.Controls.Add(roomViewControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
