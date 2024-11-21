using DAO.Models.Devices;
using Microsoft.Extensions.DependencyInjection;
using Services.Thingsboard_Services;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceViewControlRgb : UserControl
    {
        private readonly RgbLight rgbLight;
        private bool isOn = false;
        private readonly IThingsboardService thingsboardService;
        private readonly IServiceProvider serviceProvider;
        public DeviceViewControlRgb(RgbLight rgbLight, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.rgbLight = rgbLight;
            this.serviceProvider = serviceProvider;
            thingsboardService = serviceProvider.GetRequiredService<IThingsboardService>();
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            var color = colorDialog.Color;
            colorPicker.FillColor = color;
            if (colorPicker.FillColor == Color.Black)
            {
                isOn = false;
            }
            else
            {
                isOn = true;
            }
            try
            {
                thingsboardService.ControlDevice(rgbLight.ID, rgbLight.SetColor(color.R, color.G, color.B));
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

        private void powerButton_Click(object sender, EventArgs e)
        {
            var color = colorPicker.FillColor;
            try
            {
                thingsboardService.ControlDevice(rgbLight.ID, isOn ? rgbLight.SetColor(color.R, color.G, color.B) : rgbLight.SetColor(0, 0, 0));
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
    }
}
