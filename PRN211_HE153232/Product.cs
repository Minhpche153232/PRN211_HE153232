using PRN211_HE153232.DataAccess;
using PRN211_HE153232.Models;
using System.Windows.Forms;

namespace PRN211_HE153232
{
    public partial class Product : Form
    {
        
        public Product()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Add("pname", "Product's Name");
            dgvProducts.Columns["pname"].DataPropertyName = "pname";
            dgvProducts.Columns.Add("description", "Infor");
            dgvProducts.Columns["description"].DataPropertyName = "description";
            dgvProducts.Columns.Add("price", "Price");
            dgvProducts.Columns["price"].DataPropertyName = "price";
            dgvProducts.Columns.Add("qty", "On Stock");
            dgvProducts.Columns["qty"].DataPropertyName = "qty";

            DataGridViewButtonColumn viewCol = new DataGridViewButtonColumn();
            viewCol.HeaderText = "Product's detail";
            viewCol.Name = "viewcol";
            viewCol.Text = "View";
            viewCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(viewCol);

            DataGridViewButtonColumn EditCol = new DataGridViewButtonColumn();
            EditCol.HeaderText = "Edit";
            EditCol.Name = "edit";
            EditCol.Text = "Edit";
            EditCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(EditCol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAOCategories daoCategories = new DAOCategories();
            cbCategory.ValueMember = "cid";
            cbCategory.DisplayMember = "cname";
            cbCategory.DataSource = daoCategories.listAllCategories();
            DAOProducts daoProducts = new DAOProducts();
            dgvProducts.DataSource = daoProducts.listAllProducts();
        }

        public void LoadProducts()
        {
            int cid = Convert.ToInt32(cbCategory.SelectedValue);
            DAOProducts daoProducts = new DAOProducts();
            //dgvProducts.DataSource = daoProducts.listProductByCategory(cid);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name.Equals("viewcol"))
            {
                List<Products> products = (List<Products>)dgvProducts.DataSource;
                Products p = products[e.RowIndex];
                View formView = new View();
                formView.Show();
            }
            if (dgvProducts.Columns[e.ColumnIndex].Name.Equals("edit"))
            {
                List<Products> products = (List<Products>)dgvProducts.DataSource;
                Products p = products[e.RowIndex];
                Edit formEdit = new Edit();
                formEdit.Show();
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add formAdd = new Add();
            formAdd.Show();
            this.Hide();
        }
    }
}