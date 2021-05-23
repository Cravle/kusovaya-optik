using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optik
{
    public partial class FormProductsThou : Form
    {
        public FormProductsThou()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProductsThou_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.ProdBiggerInFirstShop' table. You can move, or remove it, as needed.
            this.prodBiggerInFirstShopTableAdapter.Fill(this.optikDataSet.ProdBiggerInFirstShop);

        }
    }
}
