using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace optik
{
    public partial class FormProducts : Form
    {
        string path = "Data Source=DESKTOP-58OOQ2C\\SQLEXPRESS;Initial Catalog=optik;Integrated Security=True";

        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.optikDataSet.Products);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND Counts >= " + textBox1.Text;
                }
                if (textBox2.Text != "")
                {
                    filter += " AND Counts <= " + textBox2.Text;

                }
                if (textBox3.Text != "")
                {
                    filter += " AND Price >= " + textBox3.Text;
                }
                if (textBox4.Text != "")
                {
                    filter += " AND Price <= " + textBox4.Text;

                }

                this.Text = filter;
                productsBindingSource.Filter = filter;
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
                productsBindingSource.Filter = "";
                this.Text = "Продукты";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox17.Text;
            DataRow searchedString = optikDataSet.Tables["Products"].Rows[i];

            while (true)
            {
                if (searchedString["ProductID"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["Naz"].ToString();
                    textBox5.Text = searchedString["KategoryID"].ToString();
                    textBox8.Text = searchedString["Counts"].ToString();
                    textBox9.Text = searchedString["Price"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Products"].Rows[i++];
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBox14.Text == "" && textBox6.Text == "" || textBox14.Text == "" && textBox15.Text == "")
            {
                MessageBox.Show(
                        "Хотябы одно поле должно было заполнено c id",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                return;
            }

            int i = 0;
            string insertedID = textBox14.Text;
            DataRow updatedString = optikDataSet.Tables["Products"].Rows[i];

            while (true)
            {
                if (updatedString["ProductID"].ToString() == insertedID)
                {
                    updatedString.BeginEdit();

                    if (textBox6.Text != "")
                        updatedString["Counts"] = textBox6.Text;
                    if (textBox15.Text != "")
                        updatedString["Price"] = textBox15.Text;

                    updatedString.EndEdit();
                    productsTableAdapter.Update(updatedString);

                    textBox14.Text = "";
                    textBox6.Text = "";
                    textBox15.Text = "";
                    return;
                }
                else
                {
                    try
                    {
                        updatedString = optikDataSet.Tables["Kategory"].Rows[i++];
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
                        textBox14.Text = "";
                        return;
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow insertedString = optikDataSet.Tables["Products"].NewRow();
            insertedString["Naz"] = textBox10.Text;
            insertedString["KategoryID"] = textBox11.Text;
            insertedString["Counts"] = textBox12.Text;
            insertedString["Price"] = textBox13.Text;
            optikDataSet.Tables["Products"].Rows.Add(insertedString);
            productsTableAdapter.Update(insertedString);
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                MessageBox.Show(
                        "Поле не должно быть пустым",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                return;
            }


            string insertedID = textBox16.Text;

            try
            {
                SqlConnection connection = new SqlConnection(path);
                connection.Open();
                string queryText = $"DELETE FROM Products WHERE ProductID =  + '{insertedID}'";
                SqlCommand query = new SqlCommand(queryText, connection);
                try
                {
                    int resultedString = query.ExecuteNonQuery();

                }
                catch (SqlException err)
                {
                    MessageBox.Show(
                        "Невозможно удалить такую запись, так как у нее есть связь с другими таблицами!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                };


                this.productsTableAdapter.Fill(this.optikDataSet.Products);
                connection.Close();

                textBox16.Clear();
            }

            catch (NullReferenceException error)
            {
                MessageBox.Show(
                "Запись с таким ID не найдена!",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
                textBox16.Text = "";
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            productsBindingSource.Filter = "";
            this.Text = "Продкуты";
        }
    }
}

