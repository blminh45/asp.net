using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class TaiKhoan
    {
        public string id { get; set; }
        public string matkhau { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public int diachi { get; set; }
        public string hoten { get; set; }
        public bool laAdmin { get; set; }
        public string anhdaidien { get; set; }
        public bool trangthai { get; set; }
        //public virtual GioHang GioHang { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
