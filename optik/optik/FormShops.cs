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
    public partial class FormShops : Form
    {
        public FormShops()
        {
            InitializeComponent();
        }

        private void FormShops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Shops' table. You can move, or remove it, as needed.
            this.shopsTableAdapter.Fill(this.optikDataSet.Shops);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND DatOpen >= '" + textBox1.Text + "'";
                }
                if (textBox2.Text != "")
                {
                    filter += " AND DatOpen <= '" + textBox2.Text + "'";

                }
                this.Text = filter;
                shopsBindingSource.Filter = filter;
            }
            catch(Exception err)
            {
                MessageBox.Show("Что-то пошло не так",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                textBox1.Text = "";
                textBox2.Text = "";
                shopsBindingSource.Filter = "";
                this.Text = "Магазины";
            }
             
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            shopsBindingSource.Filter = "";
            this.Text = "Магазины";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
