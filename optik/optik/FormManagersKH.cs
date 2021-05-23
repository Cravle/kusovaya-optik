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
    public partial class FormManagersKH : Form
    {
        public FormManagersKH()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormManagersKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.ManagersInKh' table. You can move, or remove it, as needed.
            this.managersInKhTableAdapter.Fill(this.optikDataSet.ManagersInKh);

        }
    }
}
