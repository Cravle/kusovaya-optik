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
    public partial class FormOrdersManagers : Form
    {
        public FormOrdersManagers()
        {
            InitializeComponent();
        }

        private void FormOrdersManagers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.ManagersAndOrders' table. You can move, or remove it, as needed.
            this.managersAndOrdersTableAdapter.Fill(this.optikDataSet.ManagersAndOrders);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
