using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASP.NetCoreMVCTemplate.Models
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string fullname { get; set; }
        public bool isAdmin { get; set; }
        public bool status { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
        public virtual List<Cart> Carts { get; set; }
    }
}
