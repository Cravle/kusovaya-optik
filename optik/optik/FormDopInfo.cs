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
    public partial class FormDopInfo : Form
    {
        public FormDopInfo()
        {
            InitializeComponent();
        }

        private void FormDopInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.ProductInfoToDetail' table. You can move, or remove it, as needed.
            this.productInfoToDetailTableAdapter.Fill(this.optikDataSet.ProductInfoToDetail);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
