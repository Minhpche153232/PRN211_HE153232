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
    internal class DAOProducts
    {
        public List<Models.Products> listAllProducts()
        {
            string sql = "select * from products";
            DataTable data = DAO.GetDataBySQL(sql);
            List<Models.Products> list = new List<Models.Products>();
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new Models.Products(dr["pid"].ToString(),
                    dr["pname"].ToString(), dr["description"].ToString(), Convert.ToInt32(dr["qty"]),
                    dr["image"].ToString(), Convert.ToDecimal(dr["price"]), Convert.ToInt32(dr["cid"])));
            }
            return list;
        }
        public List<Models.Products> listProductByCategory(int cid)
        {
            string sql = @"select p.* 
                           from products p, categories c 
                           where p.cid = @cid and p.cid = c.cid";
            SqlParameter pr1 = new SqlParameter("@cid", SqlDbType.Int);
            pr1.Value = cid;
            DataTable data = DAO.GetDataBySQL(sql);
            List<Models.Products> list = new List<Models.Products>();
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new Models.Products(dr["pid"].ToString(),
                    dr["pname"].ToString(), dr["description"].ToString(), Convert.ToInt32(dr["qty"]),
                    dr["image"].ToString(), Convert.ToDecimal(dr["price"]), Convert.ToInt32(dr["cid"])));
            }
            return list;
        }
    }
}
