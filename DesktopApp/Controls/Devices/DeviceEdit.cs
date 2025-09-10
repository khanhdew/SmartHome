using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceEdit : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private Device device;
        public DeviceEdit(Device device, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            this.device = device;
            LoadInfo();
            LoadTelemetry();
        }

        private void LoadInfo()
        {
            txtName.Text = device.Name;
            txtDeviceToken.Text = device.DeviceToken;
            txtDeviceType.Text = device.Type;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            device.Name = txtName.Text;
            device.DeviceToken = txtDeviceToken.Text;
            try
            {
                _deviceService.EditDevice(device);
                MessageBox.Show("Device updated successfully");
                LoadInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void LoadTelemetry()
        {
            var telemetry = _deviceService.GetTelemetryDataByDeviceId(device.ID).Select(t => new
            {
                Body = t.Body,
                TimeStamp = t.Timestamp
            });
            dgvDevice.DataSource = telemetry.ToList();
        }
    }
}
