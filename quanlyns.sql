USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Hinh_Anh] [varbinary](max) NULL,
	[MA_NV] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](100) NOT NULL,
	[Gioi_Tinh] [nvarchar](5) NOT NULL,
	[Ngay_Sinh] [datetime] NOT NULL,
	[Dia_Chi] [nvarchar](200) NOT NULL,
	[Dan_Toc] [nvarchar](20) NOT NULL,
	[So_CCCD] [nvarchar](20) NOT NULL,
	[So_Dt] [nvarchar](11) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Hon_Nhan] [nchar](20) NOT NULL,
	[MA_CV] [varchar](20) NOT NULL,
	[MA_PB] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MA_PB] [varchar](20) NOT NULL,
	[TEN_PB] [nvarchar](50) NOT NULL,
	[Ghi_Chu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MA_PB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[THONG_KE_NV_PB]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[THONG_KE_NV_PB]()
returns table as return
select pb.MA_PB,pb.TEN_PB , count(MA_NV) as TONG_NV from NhanVien nv,PhongBan pb
where nv.MA_PB = pb.MA_PB
group by pb.MA_PB,pb.TEN_PB
GO
/****** Object:  UserDefinedFunction [dbo].[THONG_KE_NV_PB2]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[THONG_KE_NV_PB2]()
returns table as return
select pb.MA_PB,pb.TEN_PB , count(MA_NV) as TONG_NV from NhanVien nv,PhongBan pb
where nv.MA_PB = pb.MA_PB
group by pb.MA_PB,pb.TEN_PB
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MA_CV] [varchar](20) NOT NULL,
	[TEN_CV] [nvarchar](50) NOT NULL,
	[Ghi_Chu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MA_CV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[THONG_KE_NV_CV]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[THONG_KE_NV_CV]()
returns table as return
select cv.MA_CV,CV.TEN_CV , count(MA_NV) as TONG_NV from NhanVien nv,ChucVu cv
where nv.MA_CV = cv.MA_CV
group by cv.MA_CV,CV.TEN_CV
GO
/****** Object:  Table [dbo].[ThongTinLuong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinLuong](
	[MA_LUONG] [varchar](10) NOT NULL,
	[MA_NV] [nvarchar](10) NOT NULL,
	[HS_LUONG] [float] NOT NULL,
	[LUONG_CB] [float] NOT NULL,
	[PC_CV] [float] NULL,
	[PC_AT] [float] NULL,
	[PC_DL] [float] NULL,
	[PC_CC] [float] NULL,
 CONSTRAINT [pk_ttl] PRIMARY KEY CLUSTERED 
(
	[MA_LUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangChamCong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangChamCong](
	[MA_CC] [nvarchar](10) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[Tinh_Trang] [bit] NULL,
 CONSTRAINT [pk_bcc] PRIMARY KEY CLUSTERED 
(
	[MA_CC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietChamCong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChamCong](
	[MA_CC] [nvarchar](10) NOT NULL,
	[MA_NV] [nvarchar](10) NOT NULL,
	[d1] [varchar](3) NULL,
	[d2] [varchar](3) NULL,
	[d3] [varchar](3) NULL,
	[d4] [varchar](3) NULL,
	[d5] [varchar](3) NULL,
	[d6] [varchar](3) NULL,
	[d7] [varchar](3) NULL,
	[d8] [varchar](3) NULL,
	[d9] [varchar](3) NULL,
	[d10] [varchar](3) NULL,
	[d11] [varchar](3) NULL,
	[d12] [varchar](3) NULL,
	[d13] [varchar](3) NULL,
	[d14] [varchar](3) NULL,
	[d15] [varchar](3) NULL,
	[d16] [varchar](3) NULL,
	[d17] [varchar](3) NULL,
	[d18] [varchar](3) NULL,
	[d19] [varchar](3) NULL,
	[d20] [varchar](3) NULL,
	[d21] [varchar](3) NULL,
	[d22] [varchar](3) NULL,
	[d23] [varchar](3) NULL,
	[d24] [varchar](3) NULL,
	[d25] [varchar](3) NULL,
	[d26] [varchar](3) NULL,
	[d27] [varchar](3) NULL,
	[d28] [varchar](3) NULL,
	[d29] [varchar](3) NULL,
	[d30] [varchar](3) NULL,
	[d31] [varchar](3) NULL,
	[Tong_Cong] [float] NULL,
	[SO_NN] [int] NULL,
 CONSTRAINT [pk_ctcc] PRIMARY KEY CLUSTERED 
(
	[MA_CC] ASC,
	[MA_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MA_NV] [nvarchar](10) NOT NULL,
	[MA_LUONG] [nvarchar](10) NOT NULL,
	[MA_CC] [nvarchar](10) NOT NULL,
	[Thue_TNCN] [float] NULL,
	[Tam_Ung] [float] NULL,
	[Thuc_Lanh] [float] NULL,
 CONSTRAINT [pk_bl] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC,
	[MA_CC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoHiem]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHiem](
	[MA_BH] [varchar](10) NOT NULL,
	[MA_LUONG] [varchar](10) NOT NULL,
	[BHXH] [float] NULL,
	[BHYT] [float] NULL,
	[BHTN] [float] NULL,
 CONSTRAINT [pk_bh] PRIMARY KEY CLUSTERED 
(
	[MA_BH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[LapBangLuong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LapBangLuong](@MA_CC nvarchar)
returns table as return
select nv.MA_NV,nv.Ho_Ten,cv.TEN_CV,pb.TEN_PB,bcc.Thang,bcc.Nam,ttl.LUONG_CB,ttl.PC_CV,ttl.PC_AT,ttl.PC_DL,ttl.PC_CC,(bh.BHTN+bh.BHXH+bh.BHYT) as BH,cccc.Tong_Cong,BL.Tam_Ung,BL.Thue_TNCN,
round(((ttl.LUONG_CB + ttl.PC_CV + ttl.PC_AT + ttl.PC_DL + ttl.PC_CC - (bh.BHTN+bh.BHXH+bh.BHYT))/22 * cccc.Tong_Cong),0) as Thuc_Lanh
from NhanVien nv, BangChamCong bcc, ChiTietChamCong cccc, ThongTinLuong ttl,PhongBan pb,ChucVu cv,BaoHiem bh,BangLuong BL
where nv.MA_CV = cv.MA_CV
and nv.MA_PB = pb.MA_PB
and nv.MA_NV = ttl.MA_NV
and ttl.MA_LUONG = bh.MA_LUONG
and nv.MA_NV = cccc.MA_NV
and cccc.MA_CC = bcc.MA_CC
and BCC.MA_CC = bl.MA_CC
and BCC.MA_CC = @MA_CC
and cccc.MA_NV = bl.MA_NV
GO
/****** Object:  UserDefinedFunction [dbo].[LapBangLuong3]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LapBangLuong3](@Thang int, @Nam int)
returns table as return(
select nv.MA_NV,nv.Ho_Ten,cv.TEN_CV,pb.TEN_PB,bcc.Thang,bcc.Nam,ttl.LUONG_CB,ttl.PC_CV,ttl.PC_AT,ttl.PC_DL,ttl.PC_CC,(bh.BHTN+bh.BHXH+bh.BHYT) as BH,cccc.Tong_Cong,BL.Tam_Ung,BL.Thue_TNCN,
round(((ttl.LUONG_CB + ttl.PC_CV + ttl.PC_AT + ttl.PC_DL + ttl.PC_CC - (bh.BHTN+bh.BHXH+bh.BHYT))/22 * cccc.Tong_Cong),0) as Thuc_Lanh
from NhanVien nv, BangChamCong bcc, ChiTietChamCong cccc, ThongTinLuong ttl,PhongBan pb,ChucVu cv,BaoHiem bh,BangLuong BL
where nv.MA_CV = cv.MA_CV
and nv.MA_PB = pb.MA_PB
and nv.MA_NV = ttl.MA_NV
and ttl.MA_LUONG = bh.MA_LUONG
and nv.MA_NV = cccc.MA_NV
and cccc.MA_CC = bcc.MA_CC
and bl.MA_CC = bcc.MA_CC
and cccc.MA_NV = bl.MA_NV
and bcc.Thang = @Thang
and bcc.Nam = @Nam)
GO
/****** Object:  UserDefinedFunction [dbo].[getTL]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getTL](@Thang int,@Nam int)
returns table as return
select MA_NV,Thuc_Lanh from LapBangLuong3(@Thang,@Nam) 
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_Ke_Luong1]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Thong_Ke_Luong1]()
returns table as return
select bcc.Thang,bcc.Nam , sum(bl.Thuc_Lanh) as total
from BangChamCong bcc, BangLuong bl
where bl.MA_CC = bcc.MA_CC
group by bcc.Thang,bcc.Nam
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_Ke_Luong2]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Thong_Ke_Luong2](@ThangS int,@ThangE int,@NamS int,@NamE int)
returns table as return
select bcc.Thang,bcc.Nam , sum(bl.Thuc_Lanh) as total
from BangChamCong bcc, BangLuong bl
where bl.MA_CC = bcc.MA_CC
and bcc.Thang between @ThangS and @ThangE
and bcc.Nam between @NamS and @NamE
group by bcc.Thang,bcc.Nam
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_Ke_Luong3]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Thong_Ke_Luong3](@ThangS int,@ThangE int,@NamS int,@NamE int)
returns table as return
select bcc.Thang,bcc.Nam , sum(bl.Thuc_Lanh) as total
from BangChamCong bcc, BangLuong bl
where bl.MA_CC = bcc.MA_CC
and bcc.Thang between @ThangS and @ThangE
or bcc.Thang between @ThangE and @ThangS
and bcc.Nam between @NamS and @NamE
group by bcc.Thang,bcc.Nam
GO
/****** Object:  UserDefinedFunction [dbo].[Thong_Ke_Luong4]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Thong_Ke_Luong4](@ThangS int,@ThangE int,@Nam int)
returns table as return
select bcc.Thang,bcc.Nam , sum(bl.Thuc_Lanh) as total
from BangChamCong bcc, BangLuong bl
where bl.MA_CC = bcc.MA_CC
and bcc.Thang between @ThangS and @ThangE
and bcc.Nam = @Nam
group by bcc.Thang,bcc.Nam
GO
/****** Object:  Table [dbo].[BangCap]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCap](
	[MA_BC] [nvarchar](20) NOT NULL,
	[TEN_BC] [nvarchar](50) NULL,
 CONSTRAINT [pk_bangcap] PRIMARY KEY CLUSTERED 
(
	[MA_BC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangCap_NhanVien]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCap_NhanVien](
	[MA_NV] [nvarchar](20) NOT NULL,
	[MA_BC] [nvarchar](50) NOT NULL,
	[NOI_CAP] [nvarchar](100) NOT NULL,
	[NGAY_CAP] [date] NOT NULL,
 CONSTRAINT [pk_bangcap_nv] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC,
	[MA_BC] ASC,
	[NOI_CAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MA_DG] [varchar](10) NOT NULL,
	[NGAY_DG] [datetime] NOT NULL,
	[ND_DG] [nvarchar](200) NULL,
 CONSTRAINT [pk_dg] PRIMARY KEY CLUSTERED 
(
	[MA_DG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDongLaoDong]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongLaoDong](
	[MA_HD] [varchar](10) NOT NULL,
	[MA_NV] [nvarchar](10) NOT NULL,
	[LOAI_HD] [nvarchar](20) NOT NULL,
	[NGAY_BD] [datetime] NULL,
	[NGAY_KT] [datetime] NULL,
	[NGAY_KY] [datetime] NOT NULL,
	[LAN_KY] [int] NOT NULL,
	[NOI_DUNG] [nvarchar](max) NOT NULL,
 CONSTRAINT [pk_hdld] PRIMARY KEY CLUSTERED 
(
	[MA_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQuaDanhGia]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaDanhGia](
	[MA_DG] [varchar](10) NOT NULL,
	[MA_UV] [nvarchar](10) NOT NULL,
	[KET_QUA] [nvarchar](10) NULL,
	[GHI_CHU] [nvarchar](100) NULL,
 CONSTRAINT [pk_kqdg] PRIMARY KEY CLUSTERED 
(
	[MA_DG] ASC,
	[MA_UV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgoaiNgu]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgoaiNgu](
	[MA_NN] [nvarchar](20) NOT NULL,
	[TEN_NN] [nvarchar](50) NULL,
 CONSTRAINT [pk_nn] PRIMARY KEY CLUSTERED 
(
	[MA_NN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgoaiNgu_NhanVien]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgoaiNgu_NhanVien](
	[MA_NV] [nvarchar](10) NOT NULL,
	[MA_NN] [nvarchar](50) NOT NULL,
	[LOAI_CC] [nvarchar](50) NULL,
	[DANH_GIA] [nvarchar](20) NULL,
 CONSTRAINT [pk_nn_nv] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC,
	[MA_NN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Ten_TK] [varchar](50) NOT NULL,
	[Mat_Khau] [varchar](50) NOT NULL,
	[Loai_Tk] [int] NOT NULL,
	[MA_NV] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ten_TK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UngVien]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UngVien](
	[Hinh_Anh] [varbinary](max) NULL,
	[MA_UV] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](100) NOT NULL,
	[Gioi_Tinh] [nvarchar](5) NOT NULL,
	[Ngay_Sinh] [datetime] NOT NULL,
	[Dia_Chi] [nvarchar](200) NOT NULL,
	[Dan_Toc] [nvarchar](20) NOT NULL,
	[So_CCCD] [nvarchar](20) NOT NULL,
	[So_Dt] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Hon_Nhan] [nvarchar](20) NOT NULL,
	[MA_CVUT] [varchar](20) NULL,
	[MA_PBUT] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MA_UV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaoHiem]  WITH CHECK ADD  CONSTRAINT [fk_bh] FOREIGN KEY([MA_LUONG])
REFERENCES [dbo].[ThongTinLuong] ([MA_LUONG])
GO
ALTER TABLE [dbo].[BaoHiem] CHECK CONSTRAINT [fk_bh]
GO
ALTER TABLE [dbo].[HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [fk_hdld] FOREIGN KEY([MA_NV])
REFERENCES [dbo].[NhanVien] ([MA_NV])
GO
ALTER TABLE [dbo].[HopDongLaoDong] CHECK CONSTRAINT [fk_hdld]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_nv1] FOREIGN KEY([MA_CV])
REFERENCES [dbo].[ChucVu] ([MA_CV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_nv1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_nv2] FOREIGN KEY([MA_PB])
REFERENCES [dbo].[PhongBan] ([MA_PB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_nv2]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_taikhoan_manv] FOREIGN KEY([MA_NV])
REFERENCES [dbo].[NhanVien] ([MA_NV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [fk_taikhoan_manv]
GO
ALTER TABLE [dbo].[ThongTinLuong]  WITH CHECK ADD  CONSTRAINT [fk_ttl] FOREIGN KEY([MA_NV])
REFERENCES [dbo].[NhanVien] ([MA_NV])
GO
ALTER TABLE [dbo].[ThongTinLuong] CHECK CONSTRAINT [fk_ttl]
GO
ALTER TABLE [dbo].[UngVien]  WITH CHECK ADD FOREIGN KEY([MA_CVUT])
REFERENCES [dbo].[ChucVu] ([MA_CV])
GO
ALTER TABLE [dbo].[UngVien]  WITH CHECK ADD FOREIGN KEY([MA_PBUT])
REFERENCES [dbo].[PhongBan] ([MA_PB])
GO
/****** Object:  StoredProcedure [dbo].[GetAllNv]    Script Date: 1/14/2022 9:54:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllNv]
as select * from NhanVien
GO
