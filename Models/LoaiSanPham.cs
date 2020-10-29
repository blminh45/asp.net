using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class LoaiSanPham
    {
        public string id { get; set; }
        public string tenloaisp { get; set; }
        public bool trangthai { get; set; }
        public virtual List<SanPham> SanPhams { get; set; }
    }
}
