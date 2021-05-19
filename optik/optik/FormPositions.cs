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
    public partial class FormPositions : Form
    {
        public FormPositions()
        {
            InitializeComponent();
        }

        private void FormPositions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.optikDataSet.Positions);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
