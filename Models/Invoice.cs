using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class Invoice
    {
        public int id { get; set; }
        public int accountId { get; set; }
        public DateTime issuedDate { get; set; }
        public string shippingAddress { get; set; }
        public string shippingPhone { get; set; }
        public int totalPrice { get; set; }
        public bool status { get; set; }
        public virtual List<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual Account Account { get; set; }
    }
}
