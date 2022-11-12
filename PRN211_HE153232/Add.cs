using PRN211_HE153232.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_HE153232
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            DAOCategories daoCategories = new DAOCategories();
            txtCategory.ValueMember = "cid";
            txtCategory.DisplayMember = "cname";
            txtCategory.DataSource = daoCategories.listAllCategories();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string pid = txtId.Text;
            string pname = txtName.Text;
            string descrip = txtDes.Text;
            string image = txtImage.Text;
            decimal price = txtPrice.Value;
            int qty = Convert.ToInt32(txtQty.Text);
            int cid = Convert.ToInt32(txtCategory.SelectedValue);
            DAOProducts daoProducts = new DAOProducts();
            int count = daoProducts.addProducts(pid, pname, descrip, qty, image, price, cid);
            if (count > 0)
            {
                MessageBox.Show("Add success.");
                Product pForm = new Product();
                pForm.Show();
                this.Hide();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
