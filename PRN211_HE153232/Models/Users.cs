using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class Users
    {
        public string uid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public bool gender { get; set; }
        public DateTime dob { get; set; }
        public bool isEmp { get; set; }

        public Users(string uid, string fname, string lname, string phone, string address, bool gender, DateTime dob, bool isEmp)
        {
            this.uid = uid;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.address = address;
            this.gender = gender;
            this.dob = dob;
            this.isEmp = isEmp;
        }
    }
}
