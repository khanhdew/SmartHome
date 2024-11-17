using DAO.BaseModels;
using DesktopApp.Controls.Devices;
using DesktopApp.Controls.Houses;
using DesktopApp.Utils;
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

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomControl : UserControl
    {
        private readonly IRoomService _roomService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IHouseService _houseService;
        private List<Room> roomList = new List<Room>();
        private int houseId;
        public RoomControl(int houseId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            this.houseId = houseId;
            LoadHouses(houseId);
            LoadRooms(roomList);

        }
        public RoomControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            LoadHouses();
            LoadRooms(roomList);

        }


        private void showAddBtn(int? houseId)
        {
            if (houseId != 0)
            {
                addBtn.Visible = true;
            }
            else
            {
                addBtn.Visible = false;
            }
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

        private void LoadHouses(int houseId)
        {
            roomList = _houseService.GetRooms(houseId).ToList();
        }

        private void LoadRooms(IEnumerable<Room> rooms)
        {
            showAddBtn(houseId);
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
                    roomViewControl.btnSua.Click += (sender, e) =>
                    {
                        var roomEdit = new RoomEdit(room, _serviceProvider);
                        Controls.Clear();
                        Controls.Add(roomEdit);
                    };
                    roomViewControl.lblTenPhong.Click += (sender, e) =>
                    {
                        var deviceControl = new DeviceControl(room.ID, _serviceProvider);
                        deviceControl.Dock = DockStyle.Fill;
                        Controls.Clear();
                        Controls.Add(deviceControl);
                    };

                    fLayoutPanel.Controls.Add(roomViewControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SearchRooms(string text)
        {
            var rooms = roomList;

            if (!string.IsNullOrEmpty(text))
            {
                text = StringProcessHelper.RemoveDiacritics(text);
                rooms = rooms.Where(r => StringProcessHelper.RemoveDiacritics(r.Name).Contains(text)).ToList();
            }
            LoadRooms(rooms);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var roomAddControl = new RoomAdd(_houseService, houseId);
            roomAddControl.ShowDialog();
            LoadHouses(houseId);
        }

    }
}
