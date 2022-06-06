
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2022 11:22:28
-- Generated from EDMX file: E:\Document\Quản lý cửa hàng bán đá quý\QLKD_DaQuy-database-PBH (1)\QLKD_DaQuy-database-PBH (1)\QLKD_DaQuy-database-PBH\NewProject\DB_QLKDModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_QLKD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_CTPBH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PBH] DROP CONSTRAINT [fk_CTPBH];
GO
IF OBJECT_ID(N'[dbo].[fk_CTPBH2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PBH] DROP CONSTRAINT [fk_CTPBH2];
GO
IF OBJECT_ID(N'[dbo].[fk_CTPMH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PMH] DROP CONSTRAINT [fk_CTPMH];
GO
IF OBJECT_ID(N'[dbo].[fk_LOAISP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LOAISP] DROP CONSTRAINT [fk_LOAISP];
GO
IF OBJECT_ID(N'[dbo].[fk_PMH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHIEUMUAHANG] DROP CONSTRAINT [fk_PMH];
GO
IF OBJECT_ID(N'[dbo].[fk_SANPHAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SANPHAM] DROP CONSTRAINT [fk_SANPHAM];
GO
IF OBJECT_ID(N'[dbo].[FK_fk01_BAOCAOTON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BAOCAOTON] DROP CONSTRAINT [FK_fk01_BAOCAOTON];
GO
IF OBJECT_ID(N'[dbo].[FK_fk01_CTPDV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PDV] DROP CONSTRAINT [FK_fk01_CTPDV];
GO
IF OBJECT_ID(N'[dbo].[FK_fk02_BAOCAOTON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BAOCAOTON] DROP CONSTRAINT [FK_fk02_BAOCAOTON];
GO
IF OBJECT_ID(N'[dbo].[FK_fk02_CTPDV]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PDV] DROP CONSTRAINT [FK_fk02_CTPDV];
GO
IF OBJECT_ID(N'[dbo].[FK_fk02_CTPMH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_PMH] DROP CONSTRAINT [FK_fk02_CTPMH];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BAOCAOTON]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BAOCAOTON];
GO
IF OBJECT_ID(N'[dbo].[CT_PBH]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_PBH];
GO
IF OBJECT_ID(N'[dbo].[CT_PDV]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_PDV];
GO
IF OBJECT_ID(N'[dbo].[CT_PMH]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_PMH];
GO
IF OBJECT_ID(N'[dbo].[DICHVU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DICHVU];
GO
IF OBJECT_ID(N'[dbo].[DONVITINH]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DONVITINH];
GO
IF OBJECT_ID(N'[dbo].[LOAISP]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LOAISP];
GO
IF OBJECT_ID(N'[dbo].[LOGIN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LOGIN];
GO
IF OBJECT_ID(N'[dbo].[NHACUNGCAP]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NHACUNGCAP];
GO
IF OBJECT_ID(N'[dbo].[PHIEUBANHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHIEUBANHANG];
GO
IF OBJECT_ID(N'[dbo].[PHIEUDV]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHIEUDV];
GO
IF OBJECT_ID(N'[dbo].[PHIEUMUAHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHIEUMUAHANG];
GO
IF OBJECT_ID(N'[dbo].[SANPHAM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SANPHAM];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BAOCAOTONs'
CREATE TABLE [dbo].[BAOCAOTONs] (
    [Thang] int  NOT NULL,
    [Nam] int  NOT NULL,
    [MaSP] int  NOT NULL,
    [TonDau] int  NULL,
    [TonCuoi] int  NULL,
    [SLMuaVao] int  NULL,
    [SLBanRa] int  NULL,
    [MaDVT] int  NOT NULL
);
GO

-- Creating table 'CT_PBH'
CREATE TABLE [dbo].[CT_PBH] (
    [MaPBH] int  NOT NULL,
    [MaSP] int  NOT NULL,
    [SoLuong] int  NULL,
    [DonGiaBan] bigint  NULL,
    [ThanhTien] bigint  NULL
);
GO

-- Creating table 'CT_PDV'
CREATE TABLE [dbo].[CT_PDV] (
    [MaPDV] int  NOT NULL,
    [MaDV] int  NOT NULL,
    [DonGiaDV] bigint  NULL,
    [DonGiaDuocTinh] bigint  NULL,
    [SoLuongDV] int  NULL,
    [ThanhTien] bigint  NULL,
    [MaTT] int  NULL,
    [NgayGiao] datetime  NULL,
    [TinhTrang] nvarchar(50)  NULL,
    [TraTruoc] bigint  NULL,
    [ConLai] bigint  NULL,
    [ChiPhiRiengDV] bigint  NULL
);
GO

-- Creating table 'CT_PMH'
CREATE TABLE [dbo].[CT_PMH] (
    [MaPMH] int  NOT NULL,
    [MaSP] int  NOT NULL,
    [SoLuongMuaVao] int  NULL,
    [DonGiaMuaVao] bigint  NULL,
    [ThanhTien] bigint  NULL
);
GO

-- Creating table 'DICHVUs'
CREATE TABLE [dbo].[DICHVUs] (
    [MaDV] int  NOT NULL,
    [LoaiDV] nvarchar(100)  NULL,
    [DonGiaDV] bigint  NULL
);
GO

-- Creating table 'DONVITINHs'
CREATE TABLE [dbo].[DONVITINHs] (
    [MaDVT] int  NOT NULL,
    [LoaiDVT] nvarchar(10)  NULL
);
GO

-- Creating table 'LOAISPs'
CREATE TABLE [dbo].[LOAISPs] (
    [MaLoaiSP] int  NOT NULL,
    [MaDVT] int  NOT NULL,
    [PhanTramLoiNhuan] int  NULL
);
GO

-- Creating table 'NHACUNGCAPs'
CREATE TABLE [dbo].[NHACUNGCAPs] (
    [MaNCC] int  NOT NULL,
    [DiaChiNCC] nvarchar(100)  NULL,
    [SDTNCC] nvarchar(11)  NULL,
    [TenNCC] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'PHIEUBANHANGs'
CREATE TABLE [dbo].[PHIEUBANHANGs] (
    [MaPBH] int  NOT NULL,
    [NgayLapPBH] datetime  NULL,
    [TongTien] bigint  NULL
);
GO

-- Creating table 'PHIEUDVs'
CREATE TABLE [dbo].[PHIEUDVs] (
    [MaPDV] int  NOT NULL,
    [NgayLapPDV] datetime  NULL,
    [TenKH] nvarchar(50)  NULL,
    [SDTKH] int  NULL,
    [TongTien] bigint  NULL,
    [TongTienTraTruoc] bigint  NULL,
    [TongTienConLai] bigint  NULL
);
GO

-- Creating table 'PHIEUMUAHANGs'
CREATE TABLE [dbo].[PHIEUMUAHANGs] (
    [MaPMH] int  NOT NULL,
    [NgLapPMH] datetime  NULL,
    [MaNCC] int  NOT NULL
);
GO

-- Creating table 'SANPHAMs'
CREATE TABLE [dbo].[SANPHAMs] (
    [MaSP] int  NOT NULL,
    [MaLoaiSP] int  NOT NULL,
    [DonGiaBan] bigint  NULL,
    [DonGiaMuaVao] bigint  NULL,
    [SoLuongTon] int  NULL,
    [TenSP] nvarchar(100)  NULL
);
GO

-- Creating table 'LOGINs'
CREATE TABLE [dbo].[LOGINs] (
    [AUTOID] bigint  NOT NULL,
    [USERNAME] nvarchar(50)  NULL,
    [PASSWORD] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Thang], [Nam], [MaSP] in table 'BAOCAOTONs'
ALTER TABLE [dbo].[BAOCAOTONs]
ADD CONSTRAINT [PK_BAOCAOTONs]
    PRIMARY KEY CLUSTERED ([Thang], [Nam], [MaSP] ASC);
GO

-- Creating primary key on [MaPBH], [MaSP] in table 'CT_PBH'
ALTER TABLE [dbo].[CT_PBH]
ADD CONSTRAINT [PK_CT_PBH]
    PRIMARY KEY CLUSTERED ([MaPBH], [MaSP] ASC);
GO

-- Creating primary key on [MaPDV], [MaDV] in table 'CT_PDV'
ALTER TABLE [dbo].[CT_PDV]
ADD CONSTRAINT [PK_CT_PDV]
    PRIMARY KEY CLUSTERED ([MaPDV], [MaDV] ASC);
GO

-- Creating primary key on [MaPMH], [MaSP] in table 'CT_PMH'
ALTER TABLE [dbo].[CT_PMH]
ADD CONSTRAINT [PK_CT_PMH]
    PRIMARY KEY CLUSTERED ([MaPMH], [MaSP] ASC);
GO

-- Creating primary key on [MaDV] in table 'DICHVUs'
ALTER TABLE [dbo].[DICHVUs]
ADD CONSTRAINT [PK_DICHVUs]
    PRIMARY KEY CLUSTERED ([MaDV] ASC);
GO

-- Creating primary key on [MaDVT] in table 'DONVITINHs'
ALTER TABLE [dbo].[DONVITINHs]
ADD CONSTRAINT [PK_DONVITINHs]
    PRIMARY KEY CLUSTERED ([MaDVT] ASC);
GO

-- Creating primary key on [MaLoaiSP] in table 'LOAISPs'
ALTER TABLE [dbo].[LOAISPs]
ADD CONSTRAINT [PK_LOAISPs]
    PRIMARY KEY CLUSTERED ([MaLoaiSP] ASC);
GO

-- Creating primary key on [MaNCC] in table 'NHACUNGCAPs'
ALTER TABLE [dbo].[NHACUNGCAPs]
ADD CONSTRAINT [PK_NHACUNGCAPs]
    PRIMARY KEY CLUSTERED ([MaNCC] ASC);
GO

-- Creating primary key on [MaPBH] in table 'PHIEUBANHANGs'
ALTER TABLE [dbo].[PHIEUBANHANGs]
ADD CONSTRAINT [PK_PHIEUBANHANGs]
    PRIMARY KEY CLUSTERED ([MaPBH] ASC);
GO

-- Creating primary key on [MaPDV] in table 'PHIEUDVs'
ALTER TABLE [dbo].[PHIEUDVs]
ADD CONSTRAINT [PK_PHIEUDVs]
    PRIMARY KEY CLUSTERED ([MaPDV] ASC);
GO

-- Creating primary key on [MaPMH] in table 'PHIEUMUAHANGs'
ALTER TABLE [dbo].[PHIEUMUAHANGs]
ADD CONSTRAINT [PK_PHIEUMUAHANGs]
    PRIMARY KEY CLUSTERED ([MaPMH] ASC);
GO

-- Creating primary key on [MaSP] in table 'SANPHAMs'
ALTER TABLE [dbo].[SANPHAMs]
ADD CONSTRAINT [PK_SANPHAMs]
    PRIMARY KEY CLUSTERED ([MaSP] ASC);
GO

-- Creating primary key on [AUTOID] in table 'LOGINs'
ALTER TABLE [dbo].[LOGINs]
ADD CONSTRAINT [PK_LOGINs]
    PRIMARY KEY CLUSTERED ([AUTOID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaDVT] in table 'BAOCAOTONs'
ALTER TABLE [dbo].[BAOCAOTONs]
ADD CONSTRAINT [FK_fk01_BAOCAOTON]
    FOREIGN KEY ([MaDVT])
    REFERENCES [dbo].[DONVITINHs]
        ([MaDVT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fk01_BAOCAOTON'
CREATE INDEX [IX_FK_fk01_BAOCAOTON]
ON [dbo].[BAOCAOTONs]
    ([MaDVT]);
GO

-- Creating foreign key on [MaSP] in table 'BAOCAOTONs'
ALTER TABLE [dbo].[BAOCAOTONs]
ADD CONSTRAINT [FK_fk02_BAOCAOTON]
    FOREIGN KEY ([MaSP])
    REFERENCES [dbo].[SANPHAMs]
        ([MaSP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fk02_BAOCAOTON'
CREATE INDEX [IX_FK_fk02_BAOCAOTON]
ON [dbo].[BAOCAOTONs]
    ([MaSP]);
GO

-- Creating foreign key on [MaPBH] in table 'CT_PBH'
ALTER TABLE [dbo].[CT_PBH]
ADD CONSTRAINT [fk_CTPBH]
    FOREIGN KEY ([MaPBH])
    REFERENCES [dbo].[PHIEUBANHANGs]
        ([MaPBH])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaSP] in table 'CT_PBH'
ALTER TABLE [dbo].[CT_PBH]
ADD CONSTRAINT [fk_CTPBH2]
    FOREIGN KEY ([MaSP])
    REFERENCES [dbo].[SANPHAMs]
        ([MaSP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CTPBH2'
CREATE INDEX [IX_fk_CTPBH2]
ON [dbo].[CT_PBH]
    ([MaSP]);
GO

-- Creating foreign key on [MaPDV] in table 'CT_PDV'
ALTER TABLE [dbo].[CT_PDV]
ADD CONSTRAINT [FK_fk01_CTPDV]
    FOREIGN KEY ([MaPDV])
    REFERENCES [dbo].[PHIEUDVs]
        ([MaPDV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaDV] in table 'CT_PDV'
ALTER TABLE [dbo].[CT_PDV]
ADD CONSTRAINT [FK_fk02_CTPDV]
    FOREIGN KEY ([MaDV])
    REFERENCES [dbo].[DICHVUs]
        ([MaDV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fk02_CTPDV'
CREATE INDEX [IX_FK_fk02_CTPDV]
ON [dbo].[CT_PDV]
    ([MaDV]);
GO

-- Creating foreign key on [MaSP] in table 'CT_PMH'
ALTER TABLE [dbo].[CT_PMH]
ADD CONSTRAINT [fk_CTPMH]
    FOREIGN KEY ([MaSP])
    REFERENCES [dbo].[SANPHAMs]
        ([MaSP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_CTPMH'
CREATE INDEX [IX_fk_CTPMH]
ON [dbo].[CT_PMH]
    ([MaSP]);
GO

-- Creating foreign key on [MaPMH] in table 'CT_PMH'
ALTER TABLE [dbo].[CT_PMH]
ADD CONSTRAINT [FK_fk02_CTPMH]
    FOREIGN KEY ([MaPMH])
    REFERENCES [dbo].[PHIEUMUAHANGs]
        ([MaPMH])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaDVT] in table 'LOAISPs'
ALTER TABLE [dbo].[LOAISPs]
ADD CONSTRAINT [fk_LOAISP]
    FOREIGN KEY ([MaDVT])
    REFERENCES [dbo].[DONVITINHs]
        ([MaDVT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_LOAISP'
CREATE INDEX [IX_fk_LOAISP]
ON [dbo].[LOAISPs]
    ([MaDVT]);
GO

-- Creating foreign key on [MaLoaiSP] in table 'SANPHAMs'
ALTER TABLE [dbo].[SANPHAMs]
ADD CONSTRAINT [fk_SANPHAM]
    FOREIGN KEY ([MaLoaiSP])
    REFERENCES [dbo].[LOAISPs]
        ([MaLoaiSP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_SANPHAM'
CREATE INDEX [IX_fk_SANPHAM]
ON [dbo].[SANPHAMs]
    ([MaLoaiSP]);
GO

-- Creating foreign key on [MaNCC] in table 'PHIEUMUAHANGs'
ALTER TABLE [dbo].[PHIEUMUAHANGs]
ADD CONSTRAINT [fk_PMH]
    FOREIGN KEY ([MaNCC])
    REFERENCES [dbo].[NHACUNGCAPs]
        ([MaNCC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_PMH'
CREATE INDEX [IX_fk_PMH]
ON [dbo].[PHIEUMUAHANGs]
    ([MaNCC]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------