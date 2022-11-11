using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.Models
{
    internal class Accounts
    {
        public string username { get; set; }
        public string password { get; set; }
        public string uid { get; set; }
        public string secret { get; set; }
        public bool isAdmin { get; set; }

        public Accounts(string username, string password, string uid, string secret, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.uid = uid;
            this.secret = secret;
            this.isAdmin = isAdmin;
        }
    }
}
