using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangQuaMang.BLL;
//using QuanLyBanHangQuaMang.DTO;

namespace QuanLyBanHangQuaMang
{
    public partial class ManHinhChinh : Form
    {
        private static ManHinhChinh instance;
        
        public static ManHinhChinh Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhChinh();
                return ManHinhChinh.instance;
            }
            private set { ManHinhChinh.instance = value; }
        }

        public static int Flat { get => flat; set => flat = value; }

        private static int flat = 0;

        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDemo.TONGHOP' table. You can move, or remove it, as needed.
            ListProductBLL manHinhChinhListProduct = new ListProductBLL(6);
            this.loadProductPanel(manHinhChinhListProduct);
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
            ManHinhTimKiem sear1 = new ManHinhTimKiem(UserSearchTB.Text);
            sear1.Show();
            ManHinhChinh.Flat = 2;
            this.Visible = false;
        }

        private void UserCart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Da click222\n");
        }

        private void UserCartB_Click(object sender, EventArgs e)
        {

        }

        private void productShow1_Click(object sender, EventArgs e)
        {
            //ChiTietSanPham pro1 = new ChiTietSanPham(1);
            //pro1.Show();
            ChiTietSanPham.resetId(1);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
              
        }

        private void productShow2_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(2);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow3_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(3);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow4_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(4);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow5_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(5);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void productShow6_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(6);
            ChiTietSanPham.Instance.Show();
            ManHinhChinh.Flat = 1;
            this.Visible = false;
        }

        private void loadProductPanel(ListProductBLL list)
        {
           foreach(var el in list.lBLL.lDAL)
            {
                switch(Convert.ToInt32(el.PID))
                {
                    case 1:
                        {
                            this.ProductName1.Text = el.PName;
                            this.ProductCost1.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic1.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                    case 2:
                        {
                            this.ProductName2.Text = el.PName;
                            this.ProductCost2.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic2.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                    case 3:
                        {
                            this.ProductName3.Text = el.PName;
                            this.ProductCost3.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic3.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                    case 4:
                        {
                            this.ProductName4.Text = el.PName;
                            this.ProductCost4.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic4.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                    case 5:
                        {
                            this.ProductName5.Text = el.PName;
                            this.ProductCost5.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic5.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                    case 6:
                        {
                            this.ProductName6.Text = el.PName;
                            this.ProductCost6.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic6.Image = Bitmap.FromStream(stream);
                            }
                            break;
                        }
                }
            }
        }

        private void DanhMucSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("Bạn Có chắc muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang.Instance.Show();
            GioHang.Flat = 1;
            this.Visible = false;
        }

        /* public static void increaseQtyCart()
         {
             ManHinhChinh.Instance.QtyCart.Text = (Convert.ToInt32(ManHinhChinh.Instance.QtyCart.Text) + 1).ToString();
         }

         public static void decreaseQtyCart()
         {
             ManHinhChinh.Instance.QtyCart.Text = (Convert.ToInt32(ManHinhChinh.Instance.QtyCart.Text) - 1).ToString();
         }*/
    }
}
