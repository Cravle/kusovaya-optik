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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonToTables_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormTables frm = new FormTables();
            frm.ShowDialog();
            Visible = true;
        }

        private void buttonToViews_Click(object sender, EventArgs e)
        {
            Visible = false;

            FormViews frm = new FormViews();
            frm.ShowDialog();
            Visible = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
