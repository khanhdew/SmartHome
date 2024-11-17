using DAO.BaseModels;
using Guna.UI2.WinForms;
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
    public partial class HouseEdit : UserControl
    {
        private readonly IHouseService _houseService;
        private readonly IServiceProvider _serviceProvider;
        public House House { get; set; }
        public HouseEdit(int houseId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _houseService = _serviceProvider.GetRequiredService<IHouseService>();
            House = _houseService.GetHouseById(houseId);
            AutoSize = true;
            Dock = DockStyle.Fill;
            LoadInfo();
            LoadHouseMember();
        }

        private void LoadInfo()
        {
            txtHouseName.Text = House.Name;
            txtHouseAddress.Text = House.Location;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            House.Name = txtHouseName.Text;
            House.Location = txtHouseAddress.Text;
            _houseService.EditHouse(House);
            MessageBox.Show("House updated successfully");
            LoadInfo();
        }

        private void LoadHouseMember()
        {
            var houseMembers = _houseService.GetHouseMembers(House.ID)
                .Select(hm => new
                {
                    Username = hm.User.UserName,
                    DisplayName = hm.User.DisplayName,
                    PhoneNumber = hm.User.PhoneNumber,
                    Role = hm.Role
                })
                .ToList();
            dgvHouseMember.DataSource = houseMembers;
        }

        private void btnDelMember_Click(object sender, EventArgs e)
        {
            // del selected member in dgvHouseMember
            if (dgvHouseMember.SelectedRows.Count > 0)
            {
                var selectedRow = dgvHouseMember.SelectedRows[0];
                var username = selectedRow.Cells["cellUsername"].Value.ToString();
                var user = _serviceProvider.GetRequiredService<IUserService>().GetUserByUsername(username);
                _houseService.RemoveHouseMember(user.Id, House.ID);
                LoadHouseMember();
            }
        }
    }
}
