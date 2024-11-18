using DAO.Models.Devices;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Controls.Devices
{
    public partial class DeviceViewControlFan : UserControl
    {
        private readonly Fan fan;
        private bool isOn = false;
        private double speed = 0;
        private readonly IThingsboardService thingsboardService;
        private readonly IDeviceService deviceService;
        private readonly IServiceProvider serviceProvider;
        public DeviceViewControlFan(Fan fan, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.fan = fan;
            this.serviceProvider = serviceProvider;
            thingsboardService = serviceProvider.GetRequiredService<IThingsboardService>();
            deviceService = serviceProvider.GetRequiredService<IDeviceService>();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                thingsboardService.ControlDevice(fan.ID, isOn ? fan.SetSpeed(speed * 85) : fan.SetSpeed(0));
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

        private void btnSpeed1_Click(object sender, EventArgs e)
        {
            speed = 1.5;
            Control(speed);
        }

        private void Control(double speed)
        {
            try
            {
                thingsboardService.ControlDevice(fan.ID, fan.SetSpeed(speed * 85));
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

        private void btnSpeed2_Click(object sender, EventArgs e)
        {
            speed = 2;
            Control(speed);
        }

        private void btnSpeed3_Click(object sender, EventArgs e)
        {
            speed = 3;
            Control(speed);
        }

        private void btnXoaQuat_Click(object sender, EventArgs e)
        {

            try
            {
                thingsboardService.DeleteDevice(fan.ID);
                Parent.Controls.Remove(this);
                deviceService.DeleteDevice(fan.ID);
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
