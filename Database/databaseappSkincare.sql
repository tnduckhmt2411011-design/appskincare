CREATE DATABASE QuanLySkincare_V1;
GO

USE QuanLySkincare_V1;
GO

CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(50) NOT NULL,
    HoTen NVARCHAR(100)
);

CREATE TABLE SanPham (
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSanPham NVARCHAR(100) NOT NULL,
    PhanLoai NVARCHAR(50) 
);

CREATE TABLE Routine (
    MaRT INT IDENTITY(1,1) PRIMARY KEY, 
    Ngay DATE,                  
    Buoi NVARCHAR(50),                  
    TinhTrangDa NVARCHAR(200)           
);

CREATE TABLE ChiTietRoutine (
    MaRT INT,
    MaSP INT,
    PRIMARY KEY (MaRT, MaSP),
    
    FOREIGN KEY (MaRT) REFERENCES Routine(MaRT) ON DELETE CASCADE,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) ON DELETE CASCADE
);
GO

-- Dữ liệu chạy thử

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen) VALUES 
('duc', '123', N'Đức');
GO

INSERT INTO SanPham (TenSanPham, PhanLoai) VALUES 
(N'Nước tẩy trang L''Oreal', N'Làm sạch'),
(N'Sữa rửa mặt CeraVe', N'Làm sạch'),
(N'Toner Klairs', N'Dưỡng ẩm'),
(N'Serum Vitamin C', N'Dưỡng trắng'),
(N'Chấm mụn Compliment', N'Trị mụn'),
(N'Kem dưỡng ẩm Neutrogena', N'Dưỡng ẩm'),
(N'Kem chống nắng Anessa', N'Bảo vệ');
GO

INSERT INTO Routine (Ngay, Buoi, TinhTrangDa) VALUES 
('2026-03-24', N'Sáng', N'Da bình thường, hơi đổ dầu vùng mũi'),
('2026-03-24', N'Tối', N'Da khô do ngồi máy lạnh, nổi 1 nốt mụn'),
('2026-03-25', N'Sáng', N'Da rát nhẹ do thiếu ẩm'),
('2026-03-26', N'Sáng', N'Da ổn hơn, mụn đã xẹp');
GO

INSERT INTO ChiTietRoutine (MaRT, MaSP) VALUES 
-- Buổi 1: Sáng 24/03 (Chỉ dùng Sữa rửa mặt, Kem chống nắng)
(1, 2), (1, 7),
-- Buổi 2: Tối 24/03 (Full combo 5 món: Tẩy trang, SRM, Toner, Chấm mụn, Dưỡng ẩm) 
(2, 1), (2, 2), (2, 3), (2, 5), (2, 6),
-- Buổi 3: Sáng 25/03 (SRM, Serum, KCN)
(3, 2), (3, 4), (3, 7),
-- Buổi 4: Sáng 26/03 (SRM, Dưỡng ẩm, KCN)
(4, 2), (4, 6), (4, 7);
GO