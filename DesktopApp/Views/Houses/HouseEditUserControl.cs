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

namespace DesktopApp.Views.Houses
{
    public partial class HouseEditUserControl : UserControl
    {
        private readonly IHouseService _houseService;

        public HouseEditUserControl(IHouseService houseService)
        {
            InitializeComponent();
            _houseService = houseService;
        }
    }
}
