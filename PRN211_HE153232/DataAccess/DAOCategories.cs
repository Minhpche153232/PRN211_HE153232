using PRN211_HE153232.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PRN211_HE153232.DataAccess
{
    internal class DAOCategories
    {
        public List<Categories> listAllCategories()
        {
            string sql = "select * from categories";
            DataTable data = DAO.GetDataBySQL(sql);
            List<Categories> categories = new List<Categories>();
            categories.Add(new Categories(0,"All Products"));
            foreach (DataRow dr in data.Rows)
            {
                categories.Add(new Categories(Convert.ToInt32(dr["cid"]),
                                        dr["cname"].ToString()));
            }
            return categories;
        }
    }
}
