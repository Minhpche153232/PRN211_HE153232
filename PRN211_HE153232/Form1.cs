using PRN211_HE153232.DataAccess;

namespace PRN211_HE153232
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Add("pname", "Product's Name");
            dgvProducts.Columns.Add("description", "Infor");
            dgvProducts.Columns.Add("price", "Price");
            dgvProducts.Columns.Add("qty", "On Stock");
            
            DataGridViewButtonColumn viewCol = new DataGridViewButtonColumn();
            viewCol.HeaderText = "Product's detail";
            viewCol.Name = "view";
            viewCol.Text = "View";
            viewCol.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(viewCol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}