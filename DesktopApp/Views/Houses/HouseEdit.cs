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
