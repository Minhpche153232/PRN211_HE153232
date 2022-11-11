using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class Products
    {
        public string pid { get; set; }
        public string pname { get; set; }
        public string description { get; set; }
        public int qty { get; set; }
        public string image { get; set; }
        public decimal price { get; set; }
        public int cid { get; set; }

        public Products(string pid, string pname, string description, int qty, string image, decimal price, int cid)
        {
            this.pid = pid;
            this.pname = pname;
            this.description = description;
            this.qty = qty;
            this.image = image;
            this.price = price;
            this.cid = cid;
        }
    }
}
