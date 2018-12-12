using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
namespace ConsoleApp1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection())
            {
               
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["SomeDBConnectionString"].ConnectionString;
                connection.Open();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "create table groups ( id int NOT NULL, name nvarchar(255) NOT NULL );";
                command.ExecuteNonQuery();
            }
        }
    }
}
