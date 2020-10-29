using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string info { get; set; }
        public int unitPrice { get; set; }
        public int Stock { get; set; }
        public int productTypeId { get; set; }
        public bool status { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
