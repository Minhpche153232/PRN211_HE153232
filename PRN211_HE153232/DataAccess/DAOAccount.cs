using System.Data.SqlClient;
using PRN211_HE153232.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_HE153232.DataAccess
{
    internal class DAOAccount
    {
        public Accounts GetAccounts(string user, string pass)
        {
            string sql = @"select * from accounts where username = @user and password = @pass";
            SqlParameter pr1 = new SqlParameter("@user", SqlDbType.NVarChar);
            SqlParameter pr2 = new SqlParameter("@pass", SqlDbType.NVarChar);
            pr1.Value = user;
            pr2.Value = pass;
            DataTable dt = DAO.GetDataBySQL(sql, pr1, pr2);
            Accounts acc = new Accounts();
            foreach (DataRow dr in dt.Rows)
            {
                acc = new Accounts(dr["username"].ToString(), 
                    dr["password"].ToString(), dr["uid"].ToString(), dr["secret"].ToString(), Convert.ToBoolean(dr["isAdmin"]));
            }
            return acc;
        }
    }
}
