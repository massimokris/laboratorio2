using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Archivos
{
  public class Dao : IArchivos<Entidades.Votacion>
  {

    public bool Guardar(string rutaArchivo, Entidades.Votacion objeto)
    {
      String connectionStr;
      SqlConnection connection;
      SqlCommand command;
      bool validation = true;

      connectionStr = @"Data Source= .\SQLEXPRESS; Initial Catalog= votacion-sp-2018; Integrated Security = True";
      connection = new SqlConnection(connectionStr);
      command = new SqlCommand();
      command.CommandType = System.Data.CommandType.Text;
      command.Connection = connection;

      command.CommandText = $"INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno)  VALUES('{objeto.NombreLey}', {objeto.Afirmativo}, {objeto.Negativo}, {objeto.Abstencion}, 'massimo')";
      try
      {
        connection.Open();
        command.ExecuteNonQuery();
      }
      catch (Exception e)
      {
        validation = false;
        throw e;
      }

      return validation;
    }

    

    public Entidades.Votacion Leer(string rutaArchivo)
    {
      throw new NotImplementedException();
    }
  }
}
