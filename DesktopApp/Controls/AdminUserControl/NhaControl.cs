using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System.Data;

namespace DesktopApp.Controls.AdminUserControl
{
    public partial class NhaControl : UserControl
    {
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        IEnumerable<House> houseList;

        public NhaControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            houseList = _houseService.GetHouses();
        }

        private void NhaControl_Load(object sender, EventArgs e)
        {
            LoadData(houseList);
        }

        private void LoadData(IEnumerable<House> houses)
        {
            try
            {

                SetupDataGridView();
                // Xóa hết dữ liệu cũ trong DataGridView
                dgvNha.Rows.Clear();

                // Duyệt qua danh sách người dùng và thêm vào DataGridView
                foreach (var home in houses)
                {
                    var owner = _houseService.GetHouseOwner(home.ID);
                    dgvNha.Rows.Add(home.Name, home.Location, owner.UserName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void SetupDataGridView()
        {
            // Xóa các cột cũ nếu có
            dgvNha.Columns.Clear();
            dgvNha.Columns.Add("Name", "Tên Nhà");
            dgvNha.Columns.Add("Location", "Vị trí");
            dgvNha.Columns.Add("Owner", "Chủ nhà");

            // Đặt các thuộc tính khác nếu cần
            dgvNha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SearchHouses(string s)
        {
            var houses = _houseService.GetHouses();

            // Lọc người dùng theo từ khóa tìm kiếm, kiểm tra null cho mỗi thuộc tính
            var filteredUsers = houses.Where(h => h.Name != null && h.Name.ToLower().Contains(s.ToLower()) ||
                                                h.Location != null && h.Location.ToLower().Contains(s.ToLower()));

            LoadData(filteredUsers);
        }

        private void dgvNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvNha.Rows[e.RowIndex];
                    string houseName = row.Cells["Name"].Value?.ToString();
                    string houseLocation = row.Cells["Location"].Value?.ToString();
                    string houseOwner = row.Cells["Owner"].Value?.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult result= MessageBox.Show("Bạn có chắc chắn muốn xóa nhà này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (selectHouse != null && result==DialogResult.Yes)
        //    {
        //        _houseService.DeleteHouse(selectHouse.ID);
        //        LoadData(_houseService.GetHouses());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn nhà cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

    }
}
