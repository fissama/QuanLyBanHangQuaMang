using QuanLyBanHangQuaMang.BLL;
using QuanLyBanHangQuaMang.DTO;
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
using QuanLyBanHangQuaMang;

namespace QuanLyBanHangQuaMang
{
    public partial class ChiTietSanPham : Form
    {
        int id;
        public ChiTietSanPham(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        public ChiTietSanPham(Product product)
        {
            InitializeComponent();
            Panel newProductPanel = new Panel();
            //Image Product
            PictureBox newProductImage = new PictureBox();
            newProductImage.BackColor = System.Drawing.Color.Transparent;
            var request = WebRequest.Create(product.PImgUrl);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                newProductImage.Image = Bitmap.FromStream(stream);
            }
            //picProduct1.Image = ((System.Drawing.Image)(resources.GetObject("picProduct1.Image")));
            newProductImage.Location = new System.Drawing.Point(13, 3);
            newProductImage.Name = "picProduct" + product.PID;
            newProductImage.Size = new System.Drawing.Size(274, 274);
            newProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            newProductImage.TabIndex = 0;
            newProductImage.TabStop = false;

            //Cost product
            Label newProductCost = new Label();
            newProductCost.AutoSize = true;
            newProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newProductCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            newProductCost.Location = new System.Drawing.Point(110, 320);
            newProductCost.Name = "costProduct" + product.PID;
            newProductCost.Size = new System.Drawing.Size(52, 25);
            newProductCost.TabIndex = 2;
            newProductCost.Text = product.PCost.ToString() + ".000đ";
            newProductCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //Name Product
            Label newProductName = new Label();
            newProductName.AutoSize = true;
            newProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newProductName.Location = new System.Drawing.Point(5, 295);
            newProductName.Name = "nameProduct" + product.PID;
            newProductName.Size = new System.Drawing.Size(290, 30);
            newProductName.TabIndex = 1;
            newProductName.Text = product.PName;
            newProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            newProductPanel.Controls.Add(newProductCost);
            newProductPanel.Controls.Add(newProductName);
            newProductPanel.Controls.Add(newProductImage);
            newProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newProductPanel.Location = new System.Drawing.Point(35, 15);
            newProductPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            newProductPanel.Name = "productShow" + product.PID;
            newProductPanel.Size = new System.Drawing.Size(300, 350);
            newProductPanel.TabIndex = 0;
        }

        public void addDetailProduct(int id)
        {
            ProductBLL iProduct = new ProductBLL(id);
            this.ProductName.Text = iProduct.pBLL.pDAL.PName;
            this.ProductDetail.Text = iProduct.pBLL.pDAL.PDetail;
            this.ProductCost.Text = iProduct.pBLL.pDAL.PCost + ".000đ";
            var request = WebRequest.Create(iProduct.pBLL.pDAL.PImgUrl);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                this.ProductPic.Image = Bitmap.FromStream(stream);
            }
        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {
            addDetailProduct(this.id);
        }

        private void Back_Load(object sender, EventArgs e)
        {
            this.Close();
            if (ManHinhChinh.Flat == 1)
                ManHinhChinh.Instance.Visible = true;
            else ManHinhTimKiem.Instance.Visible = true;
            
        }
    }
}
