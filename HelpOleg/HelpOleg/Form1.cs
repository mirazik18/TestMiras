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
namespace HelpOleg
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection = new SqlConnection();
        SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myBuilder.UserID = textBox1.Text;
            myBuilder.Password = textBox2.Text;
            myBuilder.InitialCatalog = textBox3.Text;
            myBuilder.ConnectTimeout =Convert.ToInt32(textBox4.Text);
            myBuilder.DataSource = textBox5.Text;
            myConnection.ConnectionString = myBuilder.ConnectionString;
        }
    }
}
