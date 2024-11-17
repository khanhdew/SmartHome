using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
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

namespace DesktopApp.Controls.Houses
{
    public partial class HouseControl : UserControl
    {
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;
        public HouseControl(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            _userManager = _serviceProvider.GetRequiredService<UserManager<User>>();
            _signInManager = _serviceProvider.GetRequiredService<SignInManager<User>>();
            _userService = _serviceProvider.GetRequiredService<IUserService>();
        }

        private void HouseControl_Load(object sender, EventArgs e)
        {
            LoadHouses();
        }

        private void LoadHouses()
        {
            try
            {
                fLayoutPanel.Controls.Clear();
                var houses = _houseService.GetHousesByUserId(MainForm.LoggedInUser.Id);
                foreach (var house in houses)
                {
                    var houseViewControl = new HouseViewUserControl(house)
                    {
                        lblTenNha = { Text = house.Name },
                        lblThongtinNha = { Text = house.Location },
                        Margin = new Padding(10),
                        Width = 200,
                    };

                    fLayoutPanel.Controls.Add(houseViewControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //display addForm

        }
    }
}
