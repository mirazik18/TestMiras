using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection())
            {
               
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;
                connection.Open();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "create table gruppa ( Id int NOT NULL, Name nvarchar(255) NOT NULL );";
                command.ExecuteNonQuery();
            }
        }
    }
}
