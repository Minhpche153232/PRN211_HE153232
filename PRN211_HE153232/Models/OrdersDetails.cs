using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class OrdersDetails
    {
        public int oid { get; set; }
        public string pid { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }

        public OrdersDetails(int oid, string pid, decimal price, int qty)
        {
            this.oid = oid;
            this.pid = pid;
            this.price = price;
            this.qty = qty;
        }
    }
}
