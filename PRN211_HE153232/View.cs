using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRN211_HE153232
{
    public partial class View : Form
    {
        Products tmpP ;
        public View()
        {
            InitializeComponent();
        }

        /*public View(Products p)
        {
            InitializeComponent();
            tmpP = p;
        }*/
        private void View_Load(object sender, EventArgs e)
        {

        }
        /*Products GetProduct()
        {
            
        }*/
    }
}
