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
    public partial class FormManagers : Form
    {
        public FormManagers()
        {
            InitializeComponent();
        }

        private void FormManagers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Managers' table. You can move, or remove it, as needed.
            this.managersTableAdapter.Fill(this.optikDataSet.Managers);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND Fam like '%" + textBox1.Text + "%'";
                }
                if (textBox2.Text != "")
                {
                    filter += " AND Iniz Like '" + textBox2.Text + "%'";

                }
                if (textBox3.Text != "")
                {
                    filter += " AND Iniz Like '%" + textBox3.Text + ".'";

                }
                if (textBox4.Text != "")
                {
                    filter += " AND PositionID = " + textBox4.Text;

                }
                if (textBox5.Text != "")
                {
                    filter += " AND ShopID = " + textBox5.Text;

                }
                this.Text = filter;
                managersBindingSource.Filter = filter;
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
                textBox4.Text = "";
                textBox5.Text = "";
                managersBindingSource.Filter = "";
                this.Text = "Менеджеры";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            managersBindingSource.Filter = "";
            this.Text = "Менеджеры";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox6.Text;
            DataRow searchedString = optikDataSet.Tables["Managers"].Rows[i];

            while (true)
            {
                if (searchedString["ManagerID"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["Fam"].ToString();
                    textBox8.Text = searchedString["Iniz"].ToString();
                    textBox9.Text = searchedString["PositionID"].ToString();
                    textBox10.Text = searchedString["ShopID"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Managers"].Rows[i++];
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
                        return;
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
