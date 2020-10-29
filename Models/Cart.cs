using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int accountId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual Account Account { get; set; }
    }
}
