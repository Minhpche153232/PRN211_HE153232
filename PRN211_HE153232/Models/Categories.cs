using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class Categories
    {
        public int cid { get; set; }
        public string cname { get; set; }

        public Categories(int cid, string cname)
        {
            this.cid = cid;
            this.cname = cname;
        }
    }
}
