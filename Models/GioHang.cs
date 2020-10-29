using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class GioHang
    {
        public int id { get; set; }
        public string tentaikhoan { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public string masp { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
        public int soluong { get; set; }
    }
}
