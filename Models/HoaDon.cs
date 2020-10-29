using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class HoaDon
    {
        public int id { get; set; }
        public string tentaikhoan { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
        public DateTime ngaymua { get; set; }
        public string diachigiaohang { get; set; }
        public string sdtgiaohang { get; set; }
        public int tongtien { get; set; }
        public bool trangthai { get; set; }
        public virtual List<CTHoaDon> CTHoaDon { get; set; }
    }
}
