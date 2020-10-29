using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class SanPham
    {
        public string  id { get; set; }
        public string tensp { get; set; }
        public string thongtin { get; set; }
        public int giatien { get; set; }
        public int soluongtonkho { get; set; }
        public string maloaisp { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public string anhminhhoa { get; set; }
        public bool trangthai { get; set; }
        public virtual CTHoaDon CTHoaDon { get; set; }
        //public virtual GioHang GioHang { get; set; }

    }
}
