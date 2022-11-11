using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class Orders
    {
        public int oid { get; set; }
        public string empid { get; set; }
        public string cusid { get; set; }
        public DateTime orderdate { get; set; }

        public Orders(int oid, string empid, string cusid, DateTime orderdate)
        {
            this.oid = oid;
            this.empid = empid;
            this.cusid = cusid;
            this.orderdate = orderdate;
        }
    }
}
