using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.AdminUserControl
{
    public partial class ThietBiControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDeviceService _deviceService;
        private IEnumerable<Device> deviceList;
        private Device selectDevice;

        public ThietBiControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _deviceService = _serviceProvider.GetRequiredService<IDeviceService>();
            deviceList = _deviceService.GetDevices();
        }

        private void ThietBiControl_Load(object sender, EventArgs e)
        {
            LoadData(deviceList);
        }

        private void LoadData(IEnumerable<Device> devices)
        {
            try
            {
                SetupDataGridView();
                // Xóa hết dữ liệu cũ trong DataGridView
                dgvThietBi.Rows.Clear();

                // Duyệt qua danh sách người dùng và thêm vào DataGridView
                foreach (var device in devices)
                {

                    dgvThietBi.Rows.Add(device.Name, device.Type, device.DeviceToken, device.Status, device.User.UserName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SetupDataGridView()
        {
            dgvThietBi.Columns.Clear();

            dgvThietBi.Columns.Add("Name", "Tên thiết bị");
            dgvThietBi.Columns.Add("Type", "Loại thiết bị");
            dgvThietBi.Columns.Add("DeviceToken", "Mã thiết bị");
            dgvThietBi.Columns.Add("Status", "Trạng thái");
            dgvThietBi.Columns.Add("Owner", "Chủ sở hữu");

            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void SearchThietBi(string keyword)
        {
            var tb = _deviceService.GetDevices();
            var filter = tb.Where(x =>
                (x.Name != null && x.Name.Contains(keyword)) ||
                (x.Type != null && x.Type.Contains(keyword)) ||
                (x.DeviceToken != null && x.DeviceToken.Contains(keyword)) ||
                (x.Status != null && x.Status.Contains(keyword))).ToList();

            LoadData(filter);
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dgvThietBi.Rows[e.RowIndex];
                    var name = row.Cells["Name"].Value?.ToString();
                    var type = row.Cells["Type"].Value?.ToString();
                    var deviceToken = row.Cells["DeviceToken"].Value?.ToString();
                    var status = row.Cells["Status"].Value?.ToString();

                    Device tbi = new Device
                    {
                        Name = name,
                        Type = type,
                        DeviceToken = deviceToken,
                        Status = status
                    };
                    this.selectDevice = tbi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //   DialogResult result= MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (selectDevice != null && result==DialogResult.Yes)
        //    {
        //        try
        //        {
        //            _deviceService.DeleteDevice(selectDevice.ID);
        //            LoadData(_deviceService.GetDevices());
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"An error occurred: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn thiết bị cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
