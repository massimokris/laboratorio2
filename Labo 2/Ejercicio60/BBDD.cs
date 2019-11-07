using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio60
{
  class BBDD
  {
    static void Main(string[] args)
    {
      String connectionStr = @"Data Source=LAB3PC03\SQLEXPRESS; Initial Catalog =AdventureWorks2012; Integrated Security = True";
      SqlConnection sqlConnection = new SqlConnection(connectionStr);
      SqlCommand sqlCommand = new SqlCommand();

      sqlCommand.CommandType = System.Data.CommandType.Text;
      sqlCommand.Connection = sqlConnection;

      sqlCommand.CommandText = "select top 10 name from Production.Product";
      try
      {
        sqlConnection.Open();

        SqlDataReader oDr = sqlCommand.ExecuteReader();

        while (oDr.Read())
        {
          string aux = oDr["name"].ToString();
          Console.WriteLine($"{aux}");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine($"{e}");
        throw;
      }
      Console.ReadKey();
    }
  }
}
