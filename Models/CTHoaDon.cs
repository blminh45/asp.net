using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class CTHoaDon
    {
        public int id { get; set; }
        public string mahd { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public string masp { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
    }
}
