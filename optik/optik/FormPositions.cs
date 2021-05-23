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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND HoursPerWeek >= " + textBox1.Text;
                }
                if (textBox2.Text != "")
                {
                    filter += " AND HoursPerWeek <= " + textBox2.Text;

                }
                if (textBox3.Text != "")
                {
                    filter += " AND Rate >= " + textBox3.Text;

                }
                if (textBox4.Text != "")
                {
                    filter += " AND Rate <= " + textBox4.Text;

                }
                this.Text = filter;
                positionsBindingSource.Filter = filter;
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
                positionsBindingSource.Filter = "";
                this.Text = "Должности";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            positionsBindingSource.Filter = "";
            this.Text = "Должности";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox6.Text;
            DataRow searchedString = optikDataSet.Tables["Positions"].Rows[i];

            while (true)
            {
                if (searchedString["PositionID"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["Naz"].ToString();
                    textBox5.Text = searchedString["HoursPerWeek"].ToString();
                    textBox8.Text = searchedString["Rate"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Positions"].Rows[i++];
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
    }
}

