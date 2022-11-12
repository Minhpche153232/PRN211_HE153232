using PRN211_HE153232.DataAccess;
using PRN211_HE153232.Models;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            DAOAccount account = new DAOAccount();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            Accounts acc = account.GetAccounts(user, pass);
            if (acc.password.Equals(pass))
            {
                Products f = new Products();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user or pass.");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
