using DesktopApp.Utils;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Services.Thingsboard_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceAdd : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private readonly IRoomService _roomService;
        private readonly IThingsboardService _thingsboardService;
        private int roomId;
        public DeviceAdd(IServiceProvider serviceProvider, int roomId)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _thingsboardService = _serviceProvider.GetRequiredService<IThingsboardService>();
            this.roomId = roomId;
            cbDeviceType.Items.AddRange(new string[] { "Light", "Fan", "RgbLight" });
            cbDeviceType.SelectedIndex = 0;
        }
        public DeviceAdd(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _thingsboardService = _serviceProvider.GetRequiredService<IThingsboardService>();
            cbDeviceType.Items.AddRange(new string[] { "Light", "Fan", "RgbLight" });
            cbDeviceType.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var device = new DAO.BaseModels.Device
            {
                Name = txtName.Text,
                Type = cbDeviceType.Text,
                DeviceToken = txtDeviceToken.Text,
                UserID = MainForm.LoggedInUser.Id,
            };
            var tempDevice = device;
            tempDevice.Name = StringProcessHelper.RemoveDiacritics(device.Name);
            try
            {
                var tbDevice = _thingsboardService.CreateDevice(tempDevice);
                var root = JsonDocument.Parse(tbDevice.ToString()).RootElement;
                device.TbDeviceId = root.GetProperty("id").GetProperty("id").GetString();
                if (roomId != 0)
                {
                    var deviceCreated = _roomService.AddDeviceToRoom(roomId, device);
                    
                }
                else
                {
                    var deviceCreated = _deviceService.CreateDevice(device);
                }
                MessageBox.Show("Device added successfully");
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
