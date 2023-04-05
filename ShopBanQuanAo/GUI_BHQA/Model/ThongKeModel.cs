using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI_BHQA.Model
{
    public partial class ThongKeModel : DbContext
    {
        public ThongKeModel()
            : base("name=ThongKeModel")
        {
        }

        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<QUANLY> QUANLY { get; set; }
        public virtual DbSet<SANPHAM> SANPHAM { get; set; }
        public virtual DbSet<TaiKhoanDangNhap> TaiKhoanDangNhap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.NgaySinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADON)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.QUANLY)
                .WithMany(e => e.KHACHHANG)
                .Map(m => m.ToTable("QuanLyKhachHang").MapLeftKey("MaKH").MapRightKey("MaQL"));

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.MaQL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.NgaySinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.DiaChi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUANLY>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUANLY>()
                .HasMany(e => e.SANPHAM)
                .WithMany(e => e.QUANLY)
                .Map(m => m.ToTable("QuanLySanPham").MapLeftKey("MaQL").MapRightKey("MaSP"));

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.HOADON)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanDangNhap>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanDangNhap>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanDangNhap>()
                .HasMany(e => e.QUANLY)
                .WithMany(e => e.TaiKhoanDangNhap)
                .Map(m => m.ToTable("QuanLyTaiKhoan").MapLeftKey("TenTK").MapRightKey("MaQL"));
        }
    }
}
