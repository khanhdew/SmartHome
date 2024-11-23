using DAO.BaseModels;
using DAO.Models.Devices;
using DesktopApp.Utils;
using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private readonly IRoomService _roomService;
        private readonly IHouseService _houseService;
        private readonly List<Device> _deviceList;
        private readonly int _roomId;

        public DeviceControl(int roomId, IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _roomId = roomId;
            LoadDevicesForRoom();
        }

        public DeviceControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _deviceList = new List<Device>();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();

            if (_roomId == 0)
            {
                LoadAllDevices();
            }
        }

        private void LoadDevicesForRoom()
        {
            _deviceList.Clear();
            _deviceList.AddRange(_roomService.GetDevicesByRoomId(_roomId));
            LoadDevices(_deviceList);
        }

        private void LoadAllDevices()
        {
            _deviceList.Clear();


            var houses = _houseService.GetHousesByUserId(MainForm.LoggedInUser.Id);
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    _deviceList.AddRange(_roomService.GetDevicesByRoomId(room.ID));
                }
            }


            var personalDevices = _deviceService.GetDevicesByUserId(MainForm.LoggedInUser.Id)
                                             .Where(d => d.RoomID == null);
            _deviceList.AddRange(personalDevices);

            LoadDevices(_deviceList);
        }

        private void LoadDevices(IEnumerable<Device> devices)
        {
            try
            {
                fLayoutPanel.Controls.Clear();

                foreach (var device in devices)
                {
                    var control = CreateDeviceControl(device);
                    if (control != null)
                    {
                        fLayoutPanel.Controls.Add(control);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thiết bị: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control? CreateDeviceControl(Device device)
        {
            switch (device)
            {
                case Light light:
                    var lightControl = new DeviceViewControlLight(light, _serviceProvider);
                    lightControl.btnSua.Click += (sender, e) => ShowDeviceEditForm(device);
                    ConfigureDeviceControl(lightControl, device);
                    return lightControl;
                case RgbLight rgbLight:
                    var rgbLightControl = new DeviceViewControlRgb(rgbLight, _serviceProvider);
                    rgbLightControl.btnSua.Click += (sender, e) => ShowDeviceEditForm(device);
                    ConfigureDeviceControl(rgbLightControl, device);
                    return rgbLightControl;
                case Fan fan:
                    var fanControl = new DeviceViewControlFan(fan, _serviceProvider);
                    fanControl.btnSua.Click += (sender, e) => ShowDeviceEditForm(device);
                    ConfigureDeviceControl(fanControl, device);
                    return fanControl;
                default:
                    return null;
            }
            
        }

        private void ConfigureDeviceControl(Control control, Device device)
        {
            if (control.Controls["lblTenThietBi"] is Label label)
            {
                label.Text = device.Name;
            }

            control.Margin = new Padding(10);
        }

        private void ShowDeviceEditForm(Device device)
        {
            var deviceEdit = new DeviceEdit(device, _serviceProvider);
            Controls.Clear();
            Controls.Add(deviceEdit);
        }

        internal void SearchDevices(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                LoadDevices(_deviceList);
                return;
            }

            var normalizedSearch = StringProcessHelper.RemoveDiacritics(searchText.ToLower());
            var filteredDevices = _deviceList.Where(device =>
                StringProcessHelper.RemoveDiacritics(device.Name.ToLower()).Contains(normalizedSearch) ||
                device.Type.ToLower().Equals(normalizedSearch));

            LoadDevices(filteredDevices);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using var deviceAdd = _roomId != 0
                    ? new DeviceAdd(_serviceProvider, _roomId)
                    : new DeviceAdd(_serviceProvider);

                if (deviceAdd.ShowDialog() == DialogResult.OK)
                {
                    if (_roomId != 0)
                    {
                        LoadDevicesForRoom();
                    }
                    else
                    {
                        LoadAllDevices();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thiết bị: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
