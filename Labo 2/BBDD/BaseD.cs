using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BBDD
{
  public class BaseD
  {
    private String connectionStr;
    private SqlConnection connection;
    private SqlCommand command;
      
    public BaseD(string source, string database)
    {
      connectionStr = $"Data Source= {source}; Initial Catalog= {database}; Integrated Security = True";
      this.connection = new SqlConnection(connectionStr);
      this.command = new SqlCommand();
      this.command.CommandType = System.Data.CommandType.Text;
      this.command.Connection = this.connection;
    }

    public SqlConnection Connection
    {
      get { return this.connection; }
    }

    public SqlDataReader consulta (string comando)
    {
      this.command.CommandText = comando;
      SqlDataReader oDr;

      try
      {
        this.connection.Open();
        oDr = command.ExecuteReader();
      }
      catch (Exception e)
      {
        throw e;
      }
      finally
      {
        this.connection.Close();
      }

      return oDr;
    }

    public void noConsulta (string comando)
    {
      this.command.CommandText = comando;
      //consulta = "UPDATE Personas SET nombre = 'Fer' WHERE id = 1";
      //consulta = "INSERT INTO Personas (nombre)  VALUES('Pedro')";
      //consulta = "DELETE FROM Personas WHERE id = 1";
      try
      {
        this.connection.Open();
        this.command.ExecuteNonQuery();
      }
      catch (Exception e)
      {
        throw e;
      }
    }
  }
}
