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
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }

        private void buttonToShops_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormShops frm = new FormShops();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToAdress_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormAdress frm = new FormAdress();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToCity_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormTowns frm = new FormTowns();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToStreets_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormStreets frm = new FormStreets();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToPositions_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormPositions frm = new FormPositions();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToManagers_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormManagers frm = new FormManagers();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToKategory_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormKategories frm = new FormKategories();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToProducts_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormProducts frm = new FormProducts();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToOrders_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormOrders frm = new FormOrders();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToOrderDetails_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormOrderDetails frm = new FormOrderDetails();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
