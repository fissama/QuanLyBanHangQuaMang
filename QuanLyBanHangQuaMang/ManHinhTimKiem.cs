using QuanLyBanHangQuaMang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangQuaMang
{
    public partial class ManHinhTimKiem : Form
    {
        private static ManHinhTimKiem instance;

        public static ManHinhTimKiem Instance
        {
            get
            {
                if (instance == null) instance = new ManHinhTimKiem(SearchString);
                return ManHinhTimKiem.instance;
            }
            private set { ManHinhTimKiem.instance = value; }
        }

        public static string SearchString { get => searchString; set => searchString = value; }

        private static string searchString = SearchString;
        public ManHinhTimKiem(String searchString)
        {
            ManHinhTimKiem.searchString = searchString;
            InitializeComponent();
            this.SearchInfo.Text = searchString;

        }
        private static List<int> productIDList = new List<int>();

        private void ManHinhTimKiem_Load(object sender, EventArgs e)
        {
            ListProductBLL manHinhTimKiemListProduct = new ListProductBLL(ManHinhTimKiem.searchString,12);
            if(manHinhTimKiemListProduct.lBLL.lDAL.Count() < 12)
            {
                int j = 12-manHinhTimKiemListProduct.lBLL.lDAL.Count();
                int i = 12;
                while (j > 0) {
                    switch (i)
                    {
                        case 12:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel12);
                                break;
                            }
                        case 11:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel11);
                                break;
                            }
                        case 10:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel10);
                                break;
                            }
                        case 9:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel9);
                                break;
                            }
                        case 8:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel8);
                                break;
                            }
                        case 7:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel7);
                                break;
                            }
                        case 6:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel6);
                                break;
                            }
                        case 5:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel5);
                                break;
                            }
                        case 4:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel4);
                                break;
                            }
                        case 3:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel3);
                                break;
                            }
                        case 2:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel2);
                                break;
                            }
                        case 1:
                            {
                                flowLayoutPanel1.Controls.Remove(ProductPanel1);
                                break;
                            }

                    }
                    i--; j--;
                }
                if(manHinhTimKiemListProduct != null)
                {
                    foreach(var el in manHinhTimKiemListProduct.lBLL.lDAL)
                    {
                        ManHinhTimKiem.productIDList.Add(Convert.ToInt32(el.PID));
                    }
                    loadProductSearchPanel(manHinhTimKiemListProduct);
                }
            }
        }

        public void loadProductSearchPanel(ListProductBLL list)
        {
            int iCount = 0;
            foreach(var el in list.lBLL.lDAL)
            {
                iCount++;
                switch(iCount)
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
                            this.ProductName1.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost1.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel1.BackColor = System.Drawing.Color.Lavender;
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
                            this.ProductName2.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost2.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel2.BackColor = System.Drawing.Color.Lavender;
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
                            this.ProductName3.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost3.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel3.BackColor = System.Drawing.Color.Lavender;
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
                            this.ProductName4.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost4.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel4.BackColor = System.Drawing.Color.Lavender;
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
                            this.ProductName5.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost5.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel5.BackColor = System.Drawing.Color.Lavender;
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
                            this.ProductName6.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost6.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel6.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 7:
                        {
                            this.ProductName7.Text = el.PName;
                            this.ProductCost7.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic7.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName7.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost7.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel7.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 8:
                        {
                            this.ProductName8.Text = el.PName;
                            this.ProductCost8.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic8.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName8.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost8.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel8.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 9:
                        {
                            this.ProductName9.Text = el.PName;
                            this.ProductCost9.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic9.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName9.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost9.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel9.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 10:
                        {
                            this.ProductName10.Text = el.PName;
                            this.ProductCost10.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic10.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName10.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost10.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel10.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 11:
                        {
                            this.ProductName11.Text = el.PName;
                            this.ProductCost11.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic11.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName11.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost11.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel11.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                    case 12:
                        {
                            this.ProductName12.Text = el.PName;
                            this.ProductCost12.Text = el.PCost + ".000đ";
                            var request = WebRequest.Create(el.PImgUrl);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                this.ProductPic12.Image = Bitmap.FromStream(stream);
                            }
                            this.ProductName12.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductCost12.ForeColor = System.Drawing.SystemColors.ControlText;
                            this.ProductPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            this.ProductPanel12.BackColor = System.Drawing.Color.Lavender;
                            break;
                        }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            ManHinhChinh.Instance.Visible = true;
        }

        private void productShow1_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[0]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;

        }

        private void productShow2_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[1]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow3_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[2]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow4_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[3]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow5_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[4]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow6_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[5]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }
        private void productShow7_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[6]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;

        }

        private void productShow8_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[7]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow9_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[8]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow10_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[9]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow11_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[10]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void productShow12_Click(object sender, EventArgs e)
        {
            ChiTietSanPham.resetId(ManHinhTimKiem.productIDList[11]);
            ChiTietSanPham.Instance.Show();
            this.Visible = false;
        }

        private void GioHang_Click(object sender, EventArgs e)
        {
            GioHang.Instance.Show();
            GioHang.Flat = 2;
            this.Visible = false;
        }

        /*        public static void increaseQtyCart()
                {
                    ManHinhTimKiem.Instance.QtyCart.Text = (Convert.ToInt32(ManHinhTimKiem.Instance.QtyCart.Text) + 1).ToString();
                }

                public static void decreaseQtyCart()
                {
                    ManHinhTimKiem.Instance.QtyCart.Text = (Convert.ToInt32(ManHinhTimKiem.Instance.QtyCart.Text) - 1).ToString();
                }*/
    }
}
