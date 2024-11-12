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
    public partial class HouseViewUserControl : UserControl
    {
        public HouseViewUserControl()
        {
            InitializeComponent();
        }

        private void btnSuaNha_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNha_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà này không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Nhà đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Gọi hàm xóa 
                }
        }
    }
}
