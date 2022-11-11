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
        public List<Products> listAllProducts()
        {
            string sql = "select * from products";
            DataTable data = DAO.GetDataBySQL(sql);
            List<Products> list = new List<Products>();
            foreach (DataRow dr in data.Rows)
            {
                list.Add(new Products(dr["pid"].ToString(),
                    dr["pname"].ToString(), dr["description"].ToString(),Convert.ToInt32(dr["qty"]),
                    dr["image"].ToString(), Convert.ToDecimal(dr["price"]), Convert.ToInt32(dr["cid"])));
            }
            return list;
        }
    }
}
