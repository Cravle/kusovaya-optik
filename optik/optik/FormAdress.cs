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
    public partial class FormAdress : Form
    {
        public FormAdress()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Adress' table. You can move, or remove it, as needed.
            this.adressTableAdapter.Fill(this.optikDataSet.Adress);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND Dom >= " + textBox1.Text;
                }
                if (textBox2.Text != "")
                {
                    filter += " AND Dom <= " + textBox2.Text;

                }
                if (textBox3.Text != "")
                {
                    filter += " AND TownID = " + textBox3.Text;

                }
                this.Text = filter;
                adressBindingSource.Filter = filter;
            }
            catch (Exception err)
            {
                MessageBox.Show("Что-то пошло не так",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                adressBindingSource.Filter = "";
                this.Text = "Адресса";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            adressBindingSource.Filter = "";
            this.Text = "Адресса";
        }
    }
}
