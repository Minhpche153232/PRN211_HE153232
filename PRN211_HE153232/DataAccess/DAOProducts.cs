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
        public List<Products> listAllProducts()
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
        public List<Products> listProductByCategory(int cid)
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
        public int addProducts(string pid, string pname, string description, int qty, string image, decimal price, int cid)
        {
            string sql = @"insert into products (pid, pname, description, qty, image, price, cid)
                            values(@pid, @pname, @description, @qty, @image, @price, @cid)";
            SqlParameter pr1 = new SqlParameter("@pid", SqlDbType.NChar);
            SqlParameter pr2 = new SqlParameter("@pname", SqlDbType.NVarChar);
            SqlParameter pr3 = new SqlParameter("@description", SqlDbType.Text);
            SqlParameter pr4 = new SqlParameter("@qty", SqlDbType.Int);
            SqlParameter pr5 = new SqlParameter("@image", SqlDbType.Text);
            SqlParameter pr6 = new SqlParameter("@price", SqlDbType.Decimal);
            SqlParameter pr7 = new SqlParameter("@cid", SqlDbType.Int);
            pr1.Value = pid;
            pr2.Value = pname;
            pr3.Value = description;
            pr4.Value = qty;
            pr5.Value = image;
            pr6.Value = price;
            pr7.Value = cid;
            return DAO.ExecuteSQL(sql,pr1,pr2,pr3,pr4,pr5,pr6,pr7);
            
        }
    }
}
