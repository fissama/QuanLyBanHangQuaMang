using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHangQuaMang
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDemo.TONGHOP' table. You can move, or remove it, as needed.
            for (int i = 0; i < 12; i++)
            {
                
            }

        }

        private void UserSearchTB_Leave(object sender, EventArgs e)
        {
            if (UserSearchTB.Text.Length == 0)
            {
                UserSearchTB.Text = "Search...";
                UserSearchTB.ForeColor = SystemColors.GrayText;
            }
        }

        private void UserSearchTB_Enter(object sender, EventArgs e)
        {
            if (UserSearchTB.Text == "Search...")
            {
                UserSearchTB.Text = "";
                UserSearchTB.ForeColor = SystemColors.WindowText;
            }
        }

        private void UserSearchTB_Validated(object sender, EventArgs e)
        {
            if (UserSearchTB.Text.Length == 0)
            {
                UserSearchTB.Text = "Search...";
                UserSearchTB.ForeColor = SystemColors.GrayText;
            }
        }

        private void UserSearchB_Click(object sender, EventArgs e)
        {

        }

        private void UserCart_Click(object sender, EventArgs e)
        {
            
        }

        private void UserCartB_Click(object sender, EventArgs e)
        {

        }
    }
}
