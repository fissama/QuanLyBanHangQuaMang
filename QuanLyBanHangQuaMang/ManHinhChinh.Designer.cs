namespace QuanLyBanHangQuaMang
{
    partial class ManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Điện Thoại - Máy Tính Bảng");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Điện Tử - Điện Lạnh");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Phụ Kiện - Thiết Bị Số");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Laptop - Thiết Bị IT");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Máy Ảnh - Quay Phim");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Điện Gia Dụng");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Nhà Cửa Đời Sống");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Hàng Tiêu Dùng - Thực Phẩm");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Đồ Chơi, Mẹ & Bé");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Thời Trang - Phụ Kiện");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Thể Thao - Phụ Kiện");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Xe Máy, Oto, Xe Đạp");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Hàng Quốc Tế");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Sách, VPP & Quà Tặng");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Voucher - Dịch Vụ - Thẻ Cào");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("DANH MỤC SẢN PHẨM", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserCart = new System.Windows.Forms.PictureBox();
            this.UserSearchB = new System.Windows.Forms.Button();
            this.UserSearchTB = new System.Windows.Forms.TextBox();
            this.LogoShop = new System.Windows.Forms.PictureBox();
            this.UserCartB = new System.Windows.Forms.Button();
            this.UserCartCount = new System.Windows.Forms.Label();
            this.DanhMucSanPham = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.UserCartCount);
            this.panel1.Controls.Add(this.UserCart);
            this.panel1.Controls.Add(this.UserCartB);
            this.panel1.Controls.Add(this.UserSearchB);
            this.panel1.Controls.Add(this.UserSearchTB);
            this.panel1.Controls.Add(this.LogoShop);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1910, 145);
            this.panel1.TabIndex = 1;
            // 
            // UserCart
            // 
            this.UserCart.BackColor = System.Drawing.Color.Wheat;
            this.UserCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserCart.Image = global::QuanLyBanHangQuaMang.Properties.Resources.cart1;
            this.UserCart.Location = new System.Drawing.Point(1481, 54);
            this.UserCart.Name = "UserCart";
            this.UserCart.Size = new System.Drawing.Size(43, 40);
            this.UserCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserCart.TabIndex = 3;
            this.UserCart.TabStop = false;
            this.UserCart.Click += new System.EventHandler(this.UserCart_Click);
            // 
            // UserSearchB
            // 
            this.UserSearchB.BackColor = System.Drawing.Color.SlateBlue;
            this.UserSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchB.ForeColor = System.Drawing.Color.SeaShell;
            this.UserSearchB.Location = new System.Drawing.Point(1203, 47);
            this.UserSearchB.Margin = new System.Windows.Forms.Padding(0);
            this.UserSearchB.Name = "UserSearchB";
            this.UserSearchB.Size = new System.Drawing.Size(154, 53);
            this.UserSearchB.TabIndex = 2;
            this.UserSearchB.Text = "Tìm kiếm";
            this.UserSearchB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UserSearchB.UseVisualStyleBackColor = false;
            this.UserSearchB.Click += new System.EventHandler(this.UserSearchB_Click);
            // 
            // UserSearchTB
            // 
            this.UserSearchTB.CausesValidation = false;
            this.UserSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserSearchTB.Location = new System.Drawing.Point(486, 47);
            this.UserSearchTB.MaxLength = 100;
            this.UserSearchTB.Multiline = true;
            this.UserSearchTB.Name = "UserSearchTB";
            this.UserSearchTB.Size = new System.Drawing.Size(700, 53);
            this.UserSearchTB.TabIndex = 1;
            this.UserSearchTB.Enter += new System.EventHandler(this.UserSearchTB_Enter);
            this.UserSearchTB.Leave += new System.EventHandler(this.UserSearchTB_Leave);
            this.UserSearchTB.Validated += new System.EventHandler(this.UserSearchTB_Validated);
            // 
            // LogoShop
            // 
            this.LogoShop.BackColor = System.Drawing.Color.Transparent;
            this.LogoShop.Image = ((System.Drawing.Image)(resources.GetObject("LogoShop.Image")));
            this.LogoShop.Location = new System.Drawing.Point(235, 3);
            this.LogoShop.Name = "LogoShop";
            this.LogoShop.Size = new System.Drawing.Size(245, 149);
            this.LogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoShop.TabIndex = 0;
            this.LogoShop.TabStop = false;
            // 
            // UserCartB
            // 
            this.UserCartB.BackColor = System.Drawing.Color.Wheat;
            this.UserCartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCartB.ForeColor = System.Drawing.Color.DarkOrange;
            this.UserCartB.Location = new System.Drawing.Point(1477, 47);
            this.UserCartB.Name = "UserCartB";
            this.UserCartB.Size = new System.Drawing.Size(183, 53);
            this.UserCartB.TabIndex = 4;
            this.UserCartB.Text = "Giỏ hàng";
            this.UserCartB.UseVisualStyleBackColor = false;
            this.UserCartB.Click += new System.EventHandler(this.UserCartB_Click);
            // 
            // UserCartCount
            // 
            this.UserCartCount.AutoSize = true;
            this.UserCartCount.BackColor = System.Drawing.Color.DarkOrange;
            this.UserCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCartCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserCartCount.Location = new System.Drawing.Point(1623, 59);
            this.UserCartCount.Name = "UserCartCount";
            this.UserCartCount.Size = new System.Drawing.Size(26, 29);
            this.UserCartCount.TabIndex = 5;
            this.UserCartCount.Text = "0";
            // 
            // DanhMucSanPham
            // 
            this.DanhMucSanPham.BackColor = System.Drawing.Color.LightCyan;
            this.DanhMucSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMucSanPham.ItemHeight = 35;
            this.DanhMucSanPham.Location = new System.Drawing.Point(24, 172);
            this.DanhMucSanPham.Name = "DanhMucSanPham";
            treeNode17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode17.Name = "DienThoai";
            treeNode17.Text = "Điện Thoại - Máy Tính Bảng";
            treeNode18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode18.Name = "DienTu";
            treeNode18.Text = "Điện Tử - Điện Lạnh";
            treeNode19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode19.Name = "PhuKienSo";
            treeNode19.Text = "Phụ Kiện - Thiết Bị Số";
            treeNode20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode20.Name = "Laptop";
            treeNode20.Text = "Laptop - Thiết Bị IT";
            treeNode21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode21.Name = "MayAnh";
            treeNode21.Text = "Máy Ảnh - Quay Phim";
            treeNode22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode22.Name = "DienGiaDung";
            treeNode22.Text = "Điện Gia Dụng";
            treeNode23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode23.Name = "NhaCuaDoiSong";
            treeNode23.Text = "Nhà Cửa Đời Sống";
            treeNode24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode24.Name = "HangTieuDung";
            treeNode24.Text = "Hàng Tiêu Dùng - Thực Phẩm";
            treeNode25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode25.Name = "DoChoi";
            treeNode25.Text = "Đồ Chơi, Mẹ & Bé";
            treeNode26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode26.Name = "ThoiTrang";
            treeNode26.Text = "Thời Trang - Phụ Kiện";
            treeNode27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode27.Name = "TheThao";
            treeNode27.Text = "Thể Thao - Phụ Kiện";
            treeNode28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode28.Name = "PhuongTienGiaoThong";
            treeNode28.Text = "Xe Máy, Oto, Xe Đạp";
            treeNode29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode29.Name = "HangQuocTe";
            treeNode29.Text = "Hàng Quốc Tế";
            treeNode30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode30.Name = "VanPhongPham";
            treeNode30.Text = "Sách, VPP & Quà Tặng";
            treeNode31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode31.Name = "Voucher";
            treeNode31.Text = "Voucher - Dịch Vụ - Thẻ Cào";
            treeNode32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode32.ForeColor = System.Drawing.Color.Black;
            treeNode32.Name = "DanhMuc";
            treeNode32.Text = "DANH MỤC SẢN PHẨM";
            this.DanhMucSanPham.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
            this.DanhMucSanPham.ShowLines = false;
            this.DanhMucSanPham.Size = new System.Drawing.Size(340, 840);
            this.DanhMucSanPham.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(388, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1484, 840);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DanhMucSanPham);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "ManHinhChinh";
            this.Text = "MuaSamOnline";
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserSearchTB;
        private System.Windows.Forms.Button UserSearchB;
        private System.Windows.Forms.PictureBox UserCart;
        private System.Windows.Forms.Button UserCartB;
        private System.Windows.Forms.Label UserCartCount;
        private System.Windows.Forms.TreeView DanhMucSanPham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}