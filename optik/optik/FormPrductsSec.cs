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
    public partial class FormPrductsSec : Form
    {
        string path = "Data Source=DESKTOP-58OOQ2C\\SQLEXPRESS;Initial Catalog=optik;Integrated Security=True";

        public FormPrductsSec()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrductsSec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'optikDataSet.ProductsSecondKat' table. You can move, or remove it, as needed.
            this.productsSecondKatTableAdapter.Fill(this.optikDataSet.ProductsSecondKat);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBox9.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show(
                    "При вводе все поля обязательны для заполнения!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
            }
            else
            {
                SqlConnection connection = new SqlConnection(path);
                connection.Open();
                string queryText = "INSERT INTO ProductsSecondKat (Naz,KategoryID,Price,Counts) values ('" + textBox9.Text + "', '" + 2 + "', " + textBox3.Text + ", " + textBox2.Text + ")";
                SqlCommand query = new SqlCommand(queryText, connection);
                int resultedString = query.ExecuteNonQuery();

                this.productsSecondKatTableAdapter.Fill(this.optikDataSet.ProductsSecondKat);
                connection.Close();
                textBox9.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                int insertedID = Convert.ToInt32(textBox16.Text);
                SqlConnection connection = new SqlConnection(path);
                connection.Open();
                string queryText = "DELETE FROM ProductsSecondKat WHERE ProductID = " + insertedID;
                SqlCommand query = new SqlCommand(queryText, connection);
                int resultedString = query.ExecuteNonQuery();

                this.productsSecondKatTableAdapter.Fill(this.optikDataSet.ProductsSecondKat);
                connection.Close();
                textBox16.Text = "";
            }
            else
            {
                MessageBox.Show(
                    "Введите ID записи для удаления!",
                    "Предупреждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
            }
        }
    }
}
