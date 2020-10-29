using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class ProductType
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool status { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
