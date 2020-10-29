using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebBanHang.Data
{
    public class MvcBanHangContext : DbContext
    {
        public MvcBanHangContext(DbContextOptions<MvcBanHangContext> options) : base(options)
        {
        }

        public DbSet<Models.SanPham> SanPham { get; set; }
        public DbSet<Models.LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<Models.TaiKhoan> TaiKhoan { get; set; }
        public DbSet<Models.GioHang> GioHang { get; set; }
        public DbSet<Models.HoaDon> HoaDon { get; set; }
        public DbSet<Models.CTHoaDon> CTHoaDon { get; set; }
    }
}
