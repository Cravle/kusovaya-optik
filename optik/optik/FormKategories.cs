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
    public partial class FormKategories : Form
    {
        string path = "Data Source=DESKTOP-58OOQ2C\\SQLEXPRESS;Initial Catalog=optik;Integrated Security=True";
        public FormKategories()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow insertedString = optikDataSet.Tables["Kategory"].NewRow();
            insertedString["Naz"] = textBox1.Text;
            optikDataSet.Tables["Kategory"].Rows.Add(insertedString);
            kategoryTableAdapter.Update(insertedString);
            textBox1.Clear();
        }

        private void FormKategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.Kategory' table. You can move, or remove it, as needed.
            this.kategoryTableAdapter.Fill(this.optikDataSet.Kategory);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string insertedID = textBox6.Text;
            DataRow searchedString = optikDataSet.Tables["Kategory"].Rows[i];

            while (true)
            {
                if (searchedString["KategoryID"].ToString() == insertedID)
                {
                    textBox7.Text = searchedString["Naz"].ToString();

                    return;
                }
                else
                {
                    try
                    {
                        searchedString = optikDataSet.Tables["Kategory"].Rows[i++];
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
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


            string insertedID = textBox4.Text;

            try
            {
                SqlConnection connection = new SqlConnection(path);
                connection.Open();
                string queryText = $"DELETE FROM Kategory WHERE KategoryID =  + '{insertedID}'";
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


                this.kategoryTableAdapter.Fill(this.optikDataSet.Kategory);
                connection.Close();

                textBox4.Clear();
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
                textBox4.Text = "";
                return;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show(
                        "Заполнитет все поля",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                return;
            }

            int i = 0;
            string insertedID = textBox3.Text;
            DataRow updatedString = optikDataSet.Tables["Kategory"].Rows[i];

            while (true)
            {
                if (updatedString["KategoryID"].ToString() == insertedID)
                {
                    updatedString.BeginEdit();

                    updatedString["Naz"] = textBox2.Text;


                    updatedString.EndEdit();
                    kategoryTableAdapter.Update(updatedString);

                    textBox3.Text = "";
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
                        textBox3.Text = "";
                        return;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
