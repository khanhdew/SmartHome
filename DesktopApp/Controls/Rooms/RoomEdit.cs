using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomEdit : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private readonly IRoomService _roomService;
        private Room _room;

        public RoomEdit(Room room, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _room = room;
            LoadInfo();
            LoadDevices();
        }
        private void LoadInfo()
        {
            txtName.Text = _room.Name;
            txtDetail.Text = _room.Detail;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _room.Name = txtName.Text;
            _room.Detail = txtDetail.Text;
            _roomService.EditRoom(_room);
            MessageBox.Show("Sửa thông tin phòng thành công!!");
            LoadInfo();

        }

        private void LoadDevices()
        {
            var devices = _roomService.GetDevicesByRoomId(_room.ID)
                .Select(d => new
                {
                    Id = d.ID,
                    Name = d.Name,
                    Owner = d.User.UserName,
                    Type = d.Type,
                    Action = "Remove"
                })
                .ToList();
            var userDevices = _deviceService.GetDevicesByUserId(MainForm.LoggedInUser.Id)
                .Where(d => d.RoomID != _room.ID)
                .Select(d => new
                {
                    Id = d.ID,
                    Name = d.Name,
                    Owner = d.User.UserName,
                    Type = d.Type,
                    Action = "Add"
                })
                .ToList();

            devices.AddRange(userDevices);

            dgvDevice.DataSource = devices;

        }

        private void dgvDevice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if cellAction column is "Add" or "Remove"
            if (dgvDevice.Rows[e.RowIndex].Cells["cellAction"].Value.ToString() == "Add")
            {
                var deviceId = (int)dgvDevice.Rows[e.RowIndex].Cells["Id"].Value;
                var device = _deviceService.GetDeviceById(deviceId);
                _roomService.AddDeviceToRoom(_room.ID, device);
                MessageBox.Show("Thêm thiết bị vào phòng thành công!!");
            }
            else
            {
                var deviceId = (int)dgvDevice.Rows[e.RowIndex].Cells["Id"].Value;
                _roomService.RemoveDeviceFromRoom(_room.ID, deviceId);
                MessageBox.Show("Xóa thiết bị khỏi phòng thành công!!");
            }
            LoadDevices();
        }

    }
}
