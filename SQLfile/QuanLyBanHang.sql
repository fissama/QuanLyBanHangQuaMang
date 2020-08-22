------Dung de xoa data, xoa khoa ngoai dau tien, xong roi toi xoa bang
    ALTER TABLE QUANG_CAO DROP CONSTRAINT fk_nv_qc;
    ALTER TABLE QUANG_CAO DROP CONSTRAINT fk_dtqc_qc;
    ALTER TABLE DON_NHAP_HANG DROP CONSTRAINT fk_nv_dnh;
    ALTER TABLE DON_NHAP_HANG DROP CONSTRAINT fk_ncc_dnh;
    ALTER TABLE DON_TRA_HANG DROP CONSTRAINT fk_ncc_dth;
    ALTER TABLE DON_TRA_HANG DROP CONSTRAINT fk_nv_dth;
    ALTER TABLE CT_DON_TRA_HANG DROP CONSTRAINT fk_dth_ctdth;
    ALTER TABLE CT_DON_TRA_HANG DROP CONSTRAINT fk_sp_ctdth;
    ALTER TABLE BINH_LUAN DROP CONSTRAINT fk_kh_bl;
    ALTER TABLE HOA_DON DROP CONSTRAINT fk_nv_hd;
    ALTER TABLE HOA_DON DROP CONSTRAINT fk_kh_hd;
    ALTER TABLE HOA_DON DROP CONSTRAINT fk_tt_hd;
    ALTER TABLE CT_HOA_DON DROP CONSTRAINT fk_sp_cthd;
    ALTER TABLE CT_HOA_DON DROP CONSTRAINT fk_hd_cthd;
    ALTER TABLE CT_NHAP_HANG DROP CONSTRAINT fk_dnh_ctnh;
    ALTER TABLE CT_NHAP_HANG DROP CONSTRAINT fk_sp_ctnh;
    ALTER TABLE SAN_PHAM DROP CONSTRAINT fk_lsp_sp;
----Xoa Bang 
BEGIN
    EXECUTE IMMEDIATE 'DROP TABLE HOA_DON';
    EXECUTE IMMEDIATE 'DROP TABLE SAN_PHAM';
    EXECUTE IMMEDIATE 'DROP TABLE DON_NHAP_HANG';
    EXECUTE IMMEDIATE 'DROP TABLE DON_TRA_HANG';
    EXECUTE IMMEDIATE 'DROP TABLE CT_NHAP_HANG';
    EXECUTE IMMEDIATE 'DROP TABLE CT_DON_TRA_HANG';
    EXECUTE IMMEDIATE 'DROP TABLE CT_HOA_DON';
    EXECUTE IMMEDIATE 'DROP TABLE THANH_TOAN';
    EXECUTE IMMEDIATE 'DROP TABLE BINH_LUAN';
    EXECUTE IMMEDIATE 'DROP TABLE NHA_CUNG_CAP';
    EXECUTE IMMEDIATE 'DROP TABLE KHACH_HANG';
    EXECUTE IMMEDIATE 'DROP TABLE NHAN_VIEN';
    EXECUTE IMMEDIATE 'DROP TABLE QUANG_CAO';
    EXECUTE IMMEDIATE 'DROP TABLE DOI_TAC_QC';
    EXECUTE IMMEDIATE 'DROP TABLE LOAI_SP';
EXCEPTION
    WHEN OTHERS THEN
    NULL;
END;
/
ALTER SESSION SET "_oracle_script"=TRUE; 
/*
DROP USER PTTK;
*/
CREATE USER PTTK IDENTIFIED BY 1;
GRANT DBA TO PTTK;
GRANT CREATE SESSION TO PTTK;
CONNECT PTTK/1;
-------------------TAO BANG (BAT DAU CHAY CODE TU DAY TOI CUOI)
CREATE TABLE SAN_PHAM(
    MaSP number,
    TenSP nvarchar2(200),
    LoaiSP varchar2(20),
    Gia float,
    SLTon number,
    ImgUrl varchar2(200),
    Detail varchar2(2000),
    PRIMARY KEY(MaSP) 
);

CREATE TABLE LOAI_SP(
    MaLoai varchar2(20),
    TenLoai nvarchar2(200),
    CONSTRAINT pk_maloai PRIMARY KEY (MaLoai)
 );
  
CREATE TABLE HOA_DON(
    MaHD number GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    NgayMuaHang date,
    MaKH number,
    CachThanhToan number, --1 la tien mat, 2 la the
    MaNV number,
    ThanhTien float,
    TinhTrangHoaDon nvarchar2(20),
    CONSTRAINT pk_mahd PRIMARY KEY (MaHD)
);

CREATE TABLE CT_HOA_DON(
    MaHD number,
    MaSP number,
    SoLuong number,
    DonGia float,
    Tong float,
    CONSTRAINT pk_mahd_masp PRIMARY KEY (MaHD, MaSP)
);

CREATE TABLE THANH_TOAN(
    MaTT number,
    HinhThucThanhToan nvarchar2(20),
    CONSTRAINT pk_matt PRIMARY KEY (MaTT)
);

CREATE TABLE KHACH_HANG (
    MaKH number,
    HoTen nvarchar2(20),
    Email varchar2(20),
    DiaChi varchar2(20),
    Sdt number,
    CONSTRAINT pk_makh PRIMARY KEY (MaKH)
);

CREATE TABLE BINH_LUAN(
    MaBL number GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    NoiDung nvarchar2(20),
    MaKH number,
    Loai nvarchar2(20),
    CONSTRAINT pk_mabl PRIMARY KEY (MaBL)
);

CREATE TABLE DON_NHAP_HANG (
    MaDNH number GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    TongSL number, --Viet procedure tinh
    NgayNhap date,
    LyDo nvarchar2(20),
    MaNCC number,
    MaNV number,
    ThanhTien float,
    CONSTRAINT pk_madnh PRIMARY KEY (MaDNH)
);

CREATE TABLE CT_NHAP_HANG(
    MaDNH number,
    MaSP number,
    SoLuong number,
    MaNCC number,
    DonGia float,
    TongTien float,
    CONSTRAINT pk_madnh_masp PRIMARY KEY (MaDNH, MaSP)
);

CREATE TABLE NHA_CUNG_CAP(
    MaNCC number,
    DiaChi nvarchar2(20),
    Sdt number,
    CONSTRAINT pk_mancc PRIMARY KEY (MaNCC)
);

CREATE TABLE DON_TRA_HANG(
    MaDTH number GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    NgayLap date,
    MaNCC number,
    MaNV number,
    CONSTRAINT pk_madth PRIMARY KEY (MaDTH)
);

CREATE TABLE CT_DON_TRA_HANG(
    MaDTH number,
    MaSP number,
    SoLuong number,
    LyDo nvarchar2(20),
    CONSTRAINT pk_madth_masp PRIMARY KEY (MaDTH, MaSP)
);

CREATE TABLE NHAN_VIEN(
    MaNV number,
    HoTen nvarchar2(20),
    DiaChi nvarchar2(20),
    Sdt number,
    Loai nvarchar2(20),
    CONSTRAINT pk_manv PRIMARY KEY (MaNV)
);

CREATE TABLE QUANG_CAO(
    MaQC number  GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    TenQC nvarchar2(20),
    LoaiQC number, --????
    MaDT number,
    NoiDung nvarchar2(20),
    NgayQC date,
    MaNV number,
    CONSTRAINT pk_maqc PRIMARY KEY (MaQC) 
);

CREATE TABLE DOI_TAC_QC(
   MaDT number,
   TenDT nvarchar2(20),
   NgayKiHopDong date,
   ThoiHan date,
   ThongTinViTri nvarchar2(20),
   CONSTRAINT pk_madt PRIMARY KEY (MaDT)
);

-------TAO KHOA NGOAI
--SAN_PHAM
ALTER TABLE SAN_PHAM
ADD CONSTRAINT fk_lsp_sp FOREIGN KEY (LoaiSP) REFERENCES LOAI_SP(MaLoai);

--CT_NHAP_HANG
ALTER TABLE CT_NHAP_HANG
ADD CONSTRAINT fk_sp_ctnh FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP);

ALTER TABLE CT_NHAP_HANG
ADD CONSTRAINT fk_dnh_ctnh FOREIGN KEY (MaDNH) REFERENCES DON_NHAP_HANG(MaDNH);

--CT_HOA_DON
ALTER TABLE CT_HOA_DON
ADD CONSTRAINT fk_hd_cthd FOREIGN KEY (MaHD) REFERENCES HOA_DON(MaHD);

ALTER TABLE CT_HOA_DON
ADD CONSTRAINT fk_sp_cthd FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP);

--HOA_DON
ALTER TABLE HOA_DON
ADD CONSTRAINT fk_tt_hd FOREIGN KEY (CachThanhToan) REFERENCES THANH_TOAN(MaTT);

ALTER TABLE HOA_DON
ADD CONSTRAINT fk_kh_hd FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH);

ALTER TABLE HOA_DON
ADD CONSTRAINT fk_nv_hd FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV);

--BINH_LUAN
ALTER TABLE BINH_LUAN
ADD CONSTRAINT fk_kh_bl FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH);

--CT_DON_TRA_HANG
ALTER TABLE CT_DON_TRA_HANG
ADD CONSTRAINT fk_sp_ctdth FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP);

ALTER TABLE CT_DON_TRA_HANG
ADD CONSTRAINT fk_dth_ctdth FOREIGN KEY (MaDTH) REFERENCES DON_TRA_HANG(MaDTH);

--DON_TRA_HANG
ALTER TABLE DON_TRA_HANG
ADD CONSTRAINT fk_ncc_dth FOREIGN KEY (MaNCC) REFERENCES NHA_CUNG_CAP(MaNCC);

ALTER TABLE DON_TRA_HANG
ADD CONSTRAINT fk_nv_dth FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV);

--DON_NHAP_HANG
ALTER TABLE DON_NHAP_HANG
ADD CONSTRAINT fk_ncc_dnh FOREIGN KEY (MaNCC) REFERENCES NHA_CUNG_CAP(MaNCC);

ALTER TABLE DON_NHAP_HANG
ADD CONSTRAINT fk_nv_dnh FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV);

--QUANG CAO
ALTER TABLE QUANG_CAO
ADD CONSTRAINT fk_nv_qc FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV);

ALTER TABLE QUANG_CAO
ADD CONSTRAINT fk_dtqc_qc FOREIGN KEY (MaDT) REFERENCES DOI_TAC_QC(MaDT);

SET DEFINE OFF;
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('001',N'Điện Tho?i - Máy Tính Bảng');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('002',N'Điện Tử - Điện Lạnh');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('003',N'Sách, VPP, Quà Tặng');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('004',N'Thời Trang - Phụ Kiện');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('005',N'Đồ Chơi, Mẹ \& Bé');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('006',N'Điện Gia Dụng');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('007',N'Laptop - Thiết Bị IT');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('008',N'Nhà Cửa Đời Sống');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('009',N'Hàng Quốc Tế');
Insert into PTTK.LOAI_SP (MALOAI,TENLOAI) values ('010',N'Làm đẹp - Sức Khoe');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (1,N'Tinh Dầu Sả Chanh Karoma','010',88,177,'https://salt.tikicdn.com/cache/w390/ts/product/12/4d/cd/6f71388d60989f8def002c9da54d29c2.jpg',N'Tinh Dầu Xông Phòng Sả Chanh Karoma (50ml) được chiết xuất từ lá sả chanh bằng phương pháp chưng cất hơi nước. Mùi hương nồng ấm rất dễ chịu đặc trưng của miền nhiệt đới từ sả chanh khiến không khí trở nên dễ chịu, sạch sẽ, vì hoạt chất có trong tinh dầu sả chanh có khả năng diệt khuẩn, hấp thụ các mùi hôi tự nhiên. Không những thế, sả chanh còn nổi tiếng trong việc xua đuổi muỗi, hỗ trợ an thần, giúp bạn phấn chấn, bớt căng thẳng hơn.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (2,N'Thám Tử Lừng Danh Conan 97','003',19,200,'https://salt.tikicdn.com/cache/w390/ts/product/1c/38/86/9b6a579e095939a7c9365752ecac72b4.jpg',N'Conan, Mori Kogoro, Amuro Toru, và Wakita Kanenori. Bộ tứ kì lạ ấy cùng nhau đi tới một nhà thờ bỏ hoang ẩn mình trong núi sâu ở Nagano. Phải chăng chờ đợi họ ở đó là những án mạng và những mật mã bí ẩn!? Giữa lúc ấy, Conan cố gắng tìm kiếm gợi ý quan trọng liên quan tới chân tướng của “RUM” từ Amuro…!');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (3,N'Áo thun nam tay lở Unisex','004',54,150,'https://salt.tikicdn.com/cache/w390/ts/product/1a/ee/14/92c855b068067a253c7bfb4734cd38d2.jpg',N'Áo thun nam tay lỡ form rộng Unisex phù hợp cho cả nam và nữ. In cao cấp đặc biệt không ra màu, KHÔNG BONG TRÓC và AN TOÀN với sức khoẻ Form áo: Dài 63cm, ngang 52cm, khách có thể tự ước lượng giúp shop nhé do lưng của mỗi người mỗi khác ạ! Freesize mặc vừa từ 45 - 70kg và cao dưới <1m65. Vòng 1 và vòng 2 nhỏ hơn 100cm vô tư bận. Chất liệu: Chất thun Tici (35% cotton - 65% polyester) mịn mát, không co rút, dày vừa ko bí, PHÙ HỢP GIÁ TIỀN.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (4,N'Nồi Chiên Không Dầu Lock\&Lock','006',4820,70,'https://salt.tikicdn.com/cache/w390/ts/product/07/2a/9f/f827733c48227f3779e6c829a4177bf4.jpg',N'Nồi Chiên Không Dầu Lock&Lock EJF357BLK (5.2 Lít) chỉ cần nguyên liệu, không cần dầu mỡ, có thể giảm chất béo, giúp người dùng có thể chế biến những món ăn có lợi cho sức khỏe. Thức ăn không dầu, không bị ám khói. Chức năng điều chỉnh nhiệt độ từ 80~200 độ C, phù hợp với nhiệt độ chiên thông thường. Có thể mặc định thời gian khi nướng, lâu nhất là 60 phút. Thiết bị tự động tắt khi đạt đến nhiệt độ chỉ định, bảo vệ quá nhiệt. Có thể dễ dàng nấu được lượng lớn thực phẩm. Chức năng giữ ấm tối đa 120 phút. Cho món ăn luôn hấp dẫn, thơm ngon. Màn hình điều khiển cảm ứng hiện đại, dễ sử dụng.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (5,N'Điện Thoại iPhone 11 64GB','001',18450,120,'https://salt.tikicdn.com/cache/w390/ts/product/0c/62/39/31879ad1c9cf92b35e58749268ba4ff7.jpg',N'Điện Thoại iPhone 11 là sản phẩm kế nhiệm cho chiếc iPhone Xr từng dành được sự chú ý của giới công nghệ. Lần này, Apple vẫn đi theo những tiêu chỉ của Xr khi tạo ra iPhone 11. Đầu tiên là thiết kế trẻ trung có thể thấy được ngay trên sự đa dạng màu sắc. Hơn nhữa, những màu của iPhone 11 đều mang xu hướng phá cách, tinh nghịch. Nhưng đồng thời, màu sắc này cũng mang trong nó một sự sang trọng nhất định.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (6,N'Sửa rửa mặt Innisfree','010',199,110,'https://salt.tikicdn.com/cache/w390/ts/product/fa/57/de/10a7e1a9570b1ee1dd27c58fc71f91ad.jpg',N'Sữa rửa mặt làm sạch từ trà xanh đảo Jeju Innisfree Green Tea Foam Cleanser 150ml - NEW - Sữa rửa mặt tạo bọt dưỡng ẩm từ trà xanh giúp loại bỏ bụi bẩn trong lỗ chân lông và dưỡng ẩm cho da với bọt mịn. Tính năng sản phẩm: Kết cấu kem mịn, dịu nhẹ - ưu điểm từ phiên bản trước. Thành phần từ nước ép lá trà xanh tươi (Beauty Green Tea) & chiết xuất từ rễ trà xanh. Làm sạch, giữ ẩm da.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (7,N'Tủ Vải Quần Áo','008',295,45,'https://salt.tikicdn.com/cache/w390/ts/product/d0/e0/05/0dfa7bee2fe0ce1c2e91295c9063c1be.JPG',N'Trong công việc và học tập, thường chúng ta phải thuê nhà và không ở cố định được 1 nơi vì thế đồ đạc sắm sửa nhiều mỗi lần dọn chuyển đồ vô cùng mệt mỏi. Đặc biệt với những đồ vật cồng kềnh như bàn ghế, giường tủ làm cho chúng ta rất ái ngại vận chuyển. Tuy nhiên, quần áo thường mọi người phải cất gọn vào tủ để tránh bừa bộn căn phòng; việc sử dụng tủ vải là 1 phương án vô cùng hữu hiệu cho những người thuê nhà hoặc những gia đình có sở thích gọn gàng ngăn nắp thì tủ vải là phương án kịp thời thích hợp.');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (8,N'Sữa Bột Nestlé NAN 1','005',375,100,'https://salt.tikicdn.com/cache/w390/ts/product/8e/81/d5/7ff0188ca88de1330eba6e286d81b8e8.jpg',N'Nestlé® NAN® OPTIPRO® 1 là sản phẩm dinh dưỡng công thức từ Thụy Sỹ, bổ sung các dưỡng chất thiết yếu giúp trẻ dễ tiêu hóa, tăng cường sức đề kháng để phát triển khỏe mạnh. Công thức dinh dưỡng Nestlé® NAN® OPTIPRO® 1 từ Thụy Sỹ chứa: 2’-FL HM-O: giúp tăng cường sức đề kháng cho trẻ. Đạm OPTIPRO: Là phát minh độc quyền từ Nestlé Thụy Sỹ với hàm lượng và chất lượng đạm phù hợp, giúp trẻ dễ tiêu hóa, dễ hấp thu để phát triển khỏe mạnh. Lợi khuẩn BIFIDUS BL: Bổ sung hơn 100 triệu lợi khuẩn Bifidus BL (trong 100g bột) giúp tăng cường sức đề kháng cho trẻ. DHA và ARA: Hỗn hợp axit béo giúp phát triển trí não và thị lực của trẻ. Các dưỡng chất thiết yếu khác: Canxi, Phốt pho, Vitamin D, Axit Folic…');
Insert into PTTK.SAN_PHAM (MASP,TENSP,LOAISP,GIA,SLTON,IMGURL,DETAIL) values (9,N'Sách Muôn Kiếp Nhân Sinh','003',120,300,'https://salt.tikicdn.com/cache/w390/ts/product/aa/ce/e5/38cde4cbfa65e85905301a1f759d5e4d.jpg',N'“Muôn kiếp nhân sinh” là tác phẩm do Giáo sư John Vũ - Nguyên Phong viết từ năm 2017 và hoàn tất đầu năm 2020 ghi lại những câu chuyện, trải nghiệm tiền kiếp kỳ lạ từ nhiều kiếp sống của người bạn tâm giao lâu năm, ông Thomas – một nhà kinh doanh tài chính nổi tiếng ở New York. Những câu chuyện chưa từng tiết lộ này sẽ giúp mọi người trên thế giới chiêm nghiệm, khám phá các quy luật về luật Nhân quả và Luân hồi của vũ trụ giữa lúc trái đất đang gặp nhiều tai ương, biến động, khủng hoảng từng ngày.');

