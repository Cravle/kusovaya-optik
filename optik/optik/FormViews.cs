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
    public partial class FormViews : Form
    {
        public FormViews()
        {
            InitializeComponent();
        }

        private void buttonToDopInfo_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormDopInfo frm = new FormDopInfo();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToOrdersManagers_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormOrdersManagers frm = new FormOrdersManagers();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToProdSec_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormPrductsSec frm = new FormPrductsSec();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonProductsThou_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormProductsThou frm = new FormProductsThou();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttoManagersInKh_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormManagersKH frm = new FormManagersKH();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
