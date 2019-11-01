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
      SqlConnection sqlConnection = new SqlConnection();
      SqlCommand sqlCommand = new SqlCommand();

      sqlCommand.CommandType = System.Data.CommandType.Text;
      sqlCommand.Connection = sqlConnection;

      sqlCommand.CommandText = "SELECT nombre FROM Personas";
      try
      {
        sqlConnection.Open();

        SqlDataReader oDr = sqlCommand.ExecuteReader();

        while (oDr.Read())
        {
          string aux = oDr["nombre"].ToString();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
