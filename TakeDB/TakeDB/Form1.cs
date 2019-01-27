using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
namespace TakeDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection())
            {
                connection.ConnectionString = "SellsConnectionString";
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        DbCommand selectCommand = connection.CreateCommand();
                        selectCommand.Connection = connection;
                        selectCommand.CommandText = "Select * from " +textBox1.Text;
                        DbDataReader reader = selectCommand.ExecuteReader();
                        while (reader.NextResult())
                        {

                            label4.Text = reader["name"].ToString();
                            label5.Text = reader["height"].ToString();


                        }
                        selectCommand.ExecuteNonQuery();
                    }
                    catch (DbException exception)
                    {
                        Console.WriteLine(exception.Message);
                        transaction.Rollback();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
