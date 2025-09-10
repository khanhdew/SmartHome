using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomViewUserControl : UserControl
    {
        private readonly Room room;
        private readonly IRoomService _roomService;
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        public RoomViewUserControl(Room room, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.room = room;
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            BackColor = Color.Transparent;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (!_houseService.GetHouseOwner(room.House.ID).Id.Equals(MainForm.LoggedInUser.Id))
            {
                MessageBox.Show("Bạn không có quyền phòng nhà này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Phòng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _roomService.DeleteRoom(room.ID);
                Parent.Controls.Remove(this);
            }
        }
    }
}
