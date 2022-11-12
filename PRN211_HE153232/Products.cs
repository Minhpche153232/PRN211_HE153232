using PRN211_HE153232.DataAccess;

namespace PRN211_HE153232
{
    public partial class Products : Form
    {
        
        public Products()
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
            viewCol.Name = "view";
            viewCol.Text = "View";
            viewCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(viewCol);
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

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadProducts();
        }
    }
}