using Services.Services;

namespace DesktopApp.Views.Houses
{
    public partial class HouseEdit : UserControl
    {
        private readonly IHouseService _houseService;

        public HouseEdit(IHouseService houseService)
        {
            InitializeComponent();
            _houseService = houseService;
        }
    }
}
