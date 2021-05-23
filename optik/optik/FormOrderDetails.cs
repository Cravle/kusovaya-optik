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
    public partial class FormOrderDetails : Form
    {
        string path = "Data Source=DESKTOP-58OOQ2C\\SQLEXPRESS;Initial Catalog=optik;Integrated Security=True";

        public FormOrderDetails()
        {
            InitializeComponent();
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.OrderDetail' table. You can move, or remove it, as needed.
            this.orderDetailTableAdapter.Fill(this.optikDataSet.OrderDetail);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            orderDetailBindingSource.Filter = "";
            this.Text = "Заказы";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = " 1=1";
            try
            {
                if (textBox1.Text != "")
                {
                    filter += " AND OrderID = " + textBox1.Text;
                }
                if (textBox2.Text != "")
                {
                    filter += " AND ProductID = " + textBox2.Text;

                }

                this.Text = filter;
                orderDetailBindingSource.Filter = filter;
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
                orderDetailBindingSource.Filter = "";
                this.Text = "Детали закаазов";
            }
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
                string queryText = $"DELETE FROM OrderDetail WHERE id =  + '{insertedID}'";
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


                this.orderDetailTableAdapter.Fill(this.optikDataSet.OrderDetail);
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox17.Text;
            DataRow searchedString = optikDataSet.Tables["OrderDetail"].Rows[i];

            while (true)
            {
                if (searchedString["id"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["OrderID"].ToString();
                    textBox3.Text = searchedString["ProductID"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["OrderDetail"].Rows[i++];
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
            if (textBox5.Text == "" && textBox4.Text == "" || textBox5.Text == "" && textBox6.Text == "")
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
            string insertedID = textBox5.Text;
            DataRow updatedString = optikDataSet.Tables["OrderDetail"].Rows[i];

            while (true)
            {
                if (updatedString["id"].ToString() == insertedID)
                {
                    updatedString.BeginEdit();

                    if (textBox4.Text != "")
                        updatedString["OrderID"] = textBox4.Text;
                    if (textBox6.Text != "")
                        updatedString["ProductID"] = textBox6.Text;


                    updatedString.EndEdit();
                    try
                    {
                        orderDetailTableAdapter.Update(updatedString);
                    }
                    catch (SqlException err)
                    {
                        MessageBox.Show(
                        "Невозможно обновить запись",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                        return;
                    }

                    textBox5.Text = "";
                    textBox4.Text = "";
                    textBox6.Text = "";
                    return;
                }
                else
                {
                    try
                    {
                        updatedString = optikDataSet.Tables["OrderDetail"].Rows[i++];
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
                        textBox3.Text = "";
                        return;
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow insertedString = optikDataSet.Tables["OrderDetail"].NewRow();
            insertedString["OrderID"] = textBox9.Text;
            insertedString["ProductID"] = textBox10.Text;
            optikDataSet.Tables["OrderDetail"].Rows.Add(insertedString);
            orderDetailTableAdapter.Update(insertedString);
            textBox9.Clear();
            textBox10.Clear();
        }
    }

}
