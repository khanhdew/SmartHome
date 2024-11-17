using DAO.Models.Devices;
using Microsoft.Extensions.DependencyInjection;
using Services.Thingsboard_Services;
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
    public partial class DeviceViewControlLight : UserControl
    {
        private readonly Light light;
        private bool isOn = false;
        private readonly IThingsboardService thingsboardService;
        private readonly IServiceProvider serviceProvider;
        public DeviceViewControlLight(Light light, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.light = light;
            this.serviceProvider = serviceProvider;
            thingsboardService = serviceProvider.GetRequiredService<IThingsboardService>();
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
                MessageBox.Show("Unauthorized access","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                thingsboardService.ControlDevice(light.ID, light.SetDim((int)(TrackBarLight.Value * 25.5)));
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
