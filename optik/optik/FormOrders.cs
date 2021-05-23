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
    public partial class FormOrders : Form
    {
        string path = "Data Source=DESKTOP-58OOQ2C\\SQLEXPRESS;Initial Catalog=optik;Integrated Security=True";
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.optikDataSet.Orders);

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
                    filter += " AND Dat >= '" + textBox1.Text + "'";
                }
                if (textBox2.Text != "")
                {
                    filter += " AND Dat <= '" + textBox2.Text + "'";

                }
                if (textBox3.Text != "")
                {
                    filter += " AND ManagerID = " + textBox3.Text;
                }
                if (textBox4.Text != "")
                {
                    filter += " AND TotalPrice >= " + textBox4.Text;

                }
                if (textBox5.Text != "")
                {
                    filter += " AND TotalPrice <= " + textBox5.Text;

                }

                this.Text = filter;
                ordersBindingSource.Filter = filter;
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
                ordersBindingSource.Filter = "";
                this.Text = "Заказы";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox17.Text;
            DataRow searchedString = optikDataSet.Tables["Orders"].Rows[i];

            while (true)
            {
                if (searchedString["OrderID"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["dat"].ToString();
                    textBox6.Text = searchedString["ManagerID"].ToString();
                    textBox8.Text = searchedString["TotalPrice"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Orders"].Rows[i++];
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow insertedString = optikDataSet.Tables["Orders"].NewRow();
            insertedString["Dat"] = textBox9.Text;
            insertedString["ManagerID"] = textBox10.Text;
            optikDataSet.Tables["Orders"].Rows.Add(insertedString);
            ordersTableAdapter.Update(insertedString);
            textBox9.Clear();
            textBox10.Clear();
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
                string queryText = $"DELETE FROM Orders WHERE OrderID =  + '{insertedID}'";
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
                }

                this.ordersTableAdapter.Fill(this.optikDataSet.Orders);
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
            textBox5.Text = "";
            ordersBindingSource.Filter = "";
            this.Text = "Заказы";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
