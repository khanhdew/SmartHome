using DAO.Models.Devices;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using Services.Thingsboard_Services;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceViewControlLight : UserControl
    {
        private readonly Light light;
        private bool isOn = false;
        private readonly IThingsboardService thingsboardService;
        private readonly IDeviceService deviceService;
        private readonly IServiceProvider serviceProvider;
        public DeviceViewControlLight(Light light, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.light = light;
            this.serviceProvider = serviceProvider;
            thingsboardService = serviceProvider.GetRequiredService<IThingsboardService>();
            deviceService = serviceProvider.GetRequiredService<IDeviceService>();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                thingsboardService.ControlDevice(light.ID, isOn ? light.TurnOn() : light.TurnOff());
                isOn = !isOn;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Unauthorized access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setLedDim(object sender, EventArgs e)
        {
            try
            {
                thingsboardService.ControlDevice(light.ID, light.SetDim(TrackBarLight.Value));
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Unauthorized access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                thingsboardService.DeleteDevice(light.ID);
                Parent.Controls.Remove(this);
                deviceService.DeleteDevice(light.ID);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Unauthorized access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
