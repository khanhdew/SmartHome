using DAO.BaseModels;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Controls.Rooms
{
    public partial class RoomEdit : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IRoomService _roomService;
        private Room _room;
        public RoomEdit(int roomId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _roomService = _serviceProvider.GetRequiredService<IRoomService>();
            _room = _roomService.GetRoomById(roomId);
        }

    }
}
