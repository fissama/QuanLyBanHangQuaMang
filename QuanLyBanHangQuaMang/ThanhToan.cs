using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangQuaMang.BLL;

namespace QuanLyBanHangQuaMang
{
    public partial class MHThanhToan : Form
    {
        private static MHThanhToan instance;

        public static MHThanhToan Instance
        {
            get
            {
                if (instance == null) instance = new MHThanhToan();
                return MHThanhToan.instance;
            }
            private set { MHThanhToan.instance = value; }
        }
        public MHThanhToan()
        {
            InitializeComponent();
        }

        public int themSanPhamSangHoaDon(int sl, int id)
        {
            ProductBLL newPro = new ProductBLL(id);
            Panel returnPanel = new Panel();

            //Qty
            TextBox QtyPro = new TextBox();
            QtyPro.BackColor = System.Drawing.Color.Lavender;
            QtyPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QtyPro.Location = new System.Drawing.Point(310, 0);
            QtyPro.Name = "sl1";
            QtyPro.Text = sl.ToString();
            QtyPro.Size = new System.Drawing.Size(100, 30);
            QtyPro.Enabled = false;
            QtyPro.TabIndex = 3;
            QtyPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // Name
            TextBox NamePro = new TextBox();
            NamePro.BackColor = System.Drawing.Color.Lavender;
            NamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NamePro.Location = new System.Drawing.Point(0, 0);
            NamePro.Name = "sp1";
            NamePro.Size = new System.Drawing.Size(300, 30);
            NamePro.TabIndex = 2;
            NamePro.Enabled = false;
            NamePro.Text = newPro.pBLL.pDAL.PName;
            NamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // tt1
            TextBox TotalPro = new TextBox();
            TotalPro.BackColor = System.Drawing.Color.Lavender;
            TotalPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalPro.Location = new System.Drawing.Point(420, 0);
            TotalPro.Name = "tt1";
            TotalPro.Text = (Convert.ToInt32(newPro.pBLL.pDAL.PCost) * sl).ToString() + ".000đ";
            TotalPro.Enabled = false;
            TotalPro.Size = new System.Drawing.Size(150, 30);
            TotalPro.TabIndex = 5;
            TotalPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            returnPanel.Controls.Add(TotalPro);
            returnPanel.Controls.Add(NamePro);
            returnPanel.Controls.Add(QtyPro);
            returnPanel.Location = new System.Drawing.Point(3, 79);
            returnPanel.Size = new System.Drawing.Size(590, 30);
            returnPanel.Name = "ChiTietGH";
            returnPanel.TabIndex = 1;
            this.flowLayoutPanel1.Controls.Add(returnPanel);
            return Convert.ToInt32(newPro.pBLL.pDAL.PCost) * sl;
        }
        public String TongThanhTien()
        {
            int sumTotal=0;
            int i = 0;
            MHThanhToan.instance = new MHThanhToan();
            foreach (var el in GioHangBLL.Instance.idSP)
            {
                sumTotal+= this.themSanPhamSangHoaDon(GioHangBLL.Instance.qtySP[i], GioHangBLL.Instance.idSP[i]);
                i++;
            }
            return sumTotal.ToString()+".000đ";
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            textBox2.Text = TongThanhTien();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GioHang.Instance.Visible = true;
        }
    }
}