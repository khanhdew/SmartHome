using DAO.BaseModels;
using DAO.Models.Devices;
using DesktopApp.Utils;
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

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private readonly IRoomService _roomService;
        private readonly IHouseService _houseService;
        List<Device> deviceList = new List<Device>();
        private int roomId;
        public DeviceControl(int roomId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.roomId = roomId;
            _serviceProvider = serviceProvider;
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            GetDevices(roomId);
            LoadDevices(deviceList);
        }
        public DeviceControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            GetDevices();
            LoadDevices(deviceList);
        }

        private void GetDevices(int roomId)
        {
            deviceList = _roomService.GetDevicesByRoomId(roomId).ToList();
        }

        private void GetDevices()
        {
            // get all house user in
            var houseList = _houseService.GetHousesByUserId(MainForm.LoggedInUser.Id);
            foreach (var house in houseList)
            {
                // get all room in house
                var roomList = _houseService.GetRooms(house.ID);
                foreach (var room in roomList)
                {
                    // get all device in room
                    var devices = _roomService.GetDevicesByRoomId(room.ID);
                    foreach (var device in devices)
                    {
                        deviceList.Add(device);
                    }
                }
            }

            // get all device user own
            var userDevices = _deviceService.GetDevicesByUserId(MainForm.LoggedInUser.Id).Where(d => d.RoomID == null);
            deviceList.AddRange(userDevices);
        }

        private void LoadDevices(IEnumerable<Device> devices)
        {
            try
            {
                fLayoutPanel.Controls.Clear();
                foreach (var device in devices)
                {
                    switch (device.GetType().Name)
                    {
                        case "Light":
                            var lightControl = new DeviceViewControlLight((Light)device, _serviceProvider)
                            {
                                lblTenThietBi = { Text = device.Name },
                                Margin = new Padding(10)
                            };
                            lightControl.btnSua.Click += (sender, e) =>
                            {
                                var deviceEdit = new DeviceEdit(device, _serviceProvider);
                                Controls.Clear();
                                Controls.Add(deviceEdit);
                            };
                            fLayoutPanel.Controls.Add(lightControl);
                            break;
                        case "RgbLight":
                            var rgbLightControl = new DeviceViewControlRgb((RgbLight)device, _serviceProvider)
                            {
                                lblTenThietBi = { Text = device.Name },
                                Margin = new Padding(10)
                            };
                            rgbLightControl.btnSua.Click += (sender, e) =>
                            {
                                var deviceEdit = new DeviceEdit(device, _serviceProvider);
                                Controls.Clear();
                                Controls.Add(deviceEdit);
                            };
                            fLayoutPanel.Controls.Add(rgbLightControl);
                            break;
                        case "Fan":
                            var fanControl = new DeviceViewControlFan((Fan)device, _serviceProvider)
                            {
                                lblTenThietBi = { Text = device.Name },
                                Margin = new Padding(10)
                            };
                            fanControl.btnSua.Click += (sender, e) =>
                            {
                                var deviceEdit = new DeviceEdit(device, _serviceProvider);
                                Controls.Clear();
                                Controls.Add(deviceEdit);
                            };
                            fLayoutPanel.Controls.Add(fanControl);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void SearchDevices(string text)
        {
            var devices = deviceList;

            if (!string.IsNullOrEmpty(text))
            {
                text = StringProcessHelper.RemoveDiacritics(text);
                devices = devices.Where(r => StringProcessHelper.RemoveDiacritics(r.Name).Contains(text) || r.Type.ToLower().Equals(text)).ToList();
            }
            LoadDevices(devices);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(roomId != 0)
            {
                var deviceAdd = new DeviceAdd(_serviceProvider, roomId);
                deviceAdd.ShowDialog();
                GetDevices(roomId);
                LoadDevices(deviceList);
            }
            else
            {
                var deviceAdd = new DeviceAdd(_serviceProvider);
                deviceAdd.ShowDialog();
                GetDevices();
                LoadDevices(deviceList);
            }
        }
    }
}
