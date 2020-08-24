using QuanLyBanHangQuaMang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyBanHangQuaMang
{
    public partial class GioHang : Form
    {
        private static int stt=0;
        private static int flat;
        private static GioHang instance;

        public static GioHang Instance
        {
            get
            {
                if (instance == null) instance = new GioHang();
                return GioHang.instance;
            }
            private set { GioHang.instance = value; }
        }

        public static int Flat { get => flat; set => flat = value; }

        public GioHang()
        {
            InitializeComponent();
        }

        private void TenSP_Click(object sender, EventArgs e)
        {
            
        }

        public void themChiTietGH(int sl, int id)
        {
            ProductBLL newPro = new ProductBLL(id);
            Panel returnPanel = new Panel();
            GioHang.stt++;

            //Qty
            TextBox QtyPro = new TextBox();
            QtyPro.BackColor = System.Drawing.Color.Lavender;
            QtyPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QtyPro.Location = new System.Drawing.Point(374, 0);
            QtyPro.Name = "sl1";
            QtyPro.Text = sl.ToString();
            QtyPro.Size = new System.Drawing.Size(123, 30);
            QtyPro.Enabled = false;
            QtyPro.TabIndex = 3;
            // Name
            TextBox NamePro = new TextBox();
            NamePro.BackColor = System.Drawing.Color.Lavender;
            NamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NamePro.Location = new System.Drawing.Point(0, 1);
            NamePro.Name = "sp1";
            NamePro.Size = new System.Drawing.Size(306, 30);
            NamePro.TabIndex = 2;
            NamePro.Enabled = false;
            NamePro.Text = newPro.pBLL.pDAL.PName;
            NamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // tt1
            TextBox TotalPro = new TextBox();
            TotalPro.BackColor = System.Drawing.Color.Lavender;
            TotalPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalPro.Location = new System.Drawing.Point(885, 0);
            TotalPro.Name = "tt1";
            TotalPro.Text = (Convert.ToInt32(newPro.pBLL.pDAL.PCost) * sl).ToString();
            TotalPro.Enabled = false;
            TotalPro.Size = new System.Drawing.Size(156, 30);
            TotalPro.TabIndex = 5;
            // dg1
            TextBox CostPro = new TextBox();
            CostPro.BackColor = System.Drawing.Color.Lavender;
            CostPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CostPro.Location = new System.Drawing.Point(621, 0);
            CostPro.Name = "dg1";
            CostPro.Text = newPro.pBLL.pDAL.PCost;
            CostPro.Enabled = false;
            CostPro.Size = new System.Drawing.Size(141, 30);
            CostPro.TabIndex = 4;
            //delButton
            Button delPro = new Button();
            delPro.BackColor = System.Drawing.Color.Wheat;
            delPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delPro.ForeColor = System.Drawing.Color.Red;
            delPro.Location = new System.Drawing.Point(1106, 1);
            delPro.Name = "DelButton"+GioHang.stt;
            delPro.Size = new System.Drawing.Size(148, 30);
            delPro.TabIndex = 6;
            delPro.Text = "Xóa";
            delPro.Click += new System.EventHandler(this.del_Click1);

            returnPanel.Controls.Add(delPro);
            returnPanel.Controls.Add(CostPro);
            returnPanel.Controls.Add(TotalPro);
            returnPanel.Controls.Add(NamePro);
            returnPanel.Controls.Add(QtyPro);
            returnPanel.Name = "ChiTietGH"+GioHang.stt.ToString();
            returnPanel.Size = new System.Drawing.Size(1257, 31);
            returnPanel.TabIndex = 1;
            this.flowLayoutPanel1.Controls.Add(returnPanel);
            this.flowLayoutPanel1.Controls.SetChildIndex(returnPanel, GioHang.stt);
        }

        private void del_Click1(object sender, EventArgs e)
        {
            int del=0;
            Button temp = sender as Button;
            foreach(var el in this.flowLayoutPanel1.Controls)
            {
                Panel t = el as Panel;
                if (temp.Name.Substring(9, temp.Name.Length - 9).Equals((Convert.ToInt32(t.Name.Substring(9, t.Name.Length - 9))).ToString())) {
                    this.flowLayoutPanel1.Controls.Remove(t);
                    //del = Convert.ToInt32(t.Name.Substring(5, t.Name.Length - 5)) - 1;
                    break;
                }

            }
            //this.flowLayoutPanel1.Controls.RemoveAt(del-1);
            
        }
        public void reLoad()
        {
            int count = 0;
            GioHang.instance = new GioHang();
            foreach(var el in GioHangBLL.Instance.idSP)
            {
                GioHang.Instance.themChiTietGH(GioHangBLL.Instance.qtySP[count], GioHangBLL.Instance.idSP[count]);
                count++;
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (GioHang.flat == 1)
                ManHinhChinh.Instance.Visible = true;
            else if (GioHang.flat == 2)
                ManHinhTimKiem.Instance.Visible = true;
            else if (GioHang.flat == 3)
                ChiTietSanPham.Instance.Visible = true;
        }
    }
}
