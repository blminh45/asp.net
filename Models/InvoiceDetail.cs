using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class InvoiceDetail
    {
        public int id { get; set; }
        public int invoiceId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public int unitPrice { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual Invoice Invoice { get; set; } 
    }
}
