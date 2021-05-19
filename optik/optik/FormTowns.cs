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
    public partial class FormTowns : Form
    {
        public FormTowns()
        {
            InitializeComponent();
        }

        private void FormTowns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Towns' table. You can move, or remove it, as needed.
            this.townsTableAdapter.Fill(this.optikDataSet.Towns);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND Naz like '%" + textBox1.Text + "%'";
                }

                this.Text = filter;
                townsBindingSource.Filter = filter;
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
                townsBindingSource.Filter = "";
                this.Text = "Города";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            townsBindingSource.Filter = "";
            this.Text = "Города";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox2.Text;
            DataRow searchedString = optikDataSet.Tables["Towns"].Rows[i];

            while (true)
            {
                if (searchedString["TownID"].ToString() == insertedID)
                {
                    textBox3.Text = searchedString["Naz"].ToString();
                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Towns"].Rows[i++];
                    }
                    catch (IndexOutOfRangeException error)
                    {
                        MessageBox.Show(
                        "Запись с таким ID не найдена!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                        textBox2.Text = "";
                        return;
                    }
                }



            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
