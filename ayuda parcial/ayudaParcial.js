

//Serializar XML 
public bool Guardar(string rutaArchivo, T objeto)
{
    bool validation = true;
    
    try
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);
        XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(writer, objeto);
        writer.Close();
    }
    catch (Exception e)
    {
        validation = false;
        //throw new ErrorArchivosException(e);
    }
    return validation;
}

public T Leer (string rutaArchivo)
{
    T datos;

    try
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);
        XmlTextReader reader = new XmlTextReader(path);
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        datos = (T)serializer.Deserialize(reader);
        reader.Close();
    }
    catch (Exception e)
    {
        datos = default(T);
        //throw new ErrorArchivosException(e);
    }
    return datos;
}

//Coneccion a BBDD queries/non queries
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

//Guardar archivo texto
public static class ArchivoTexto
{
    public static void Guardar(string txt)
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "texto.txt");   
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(txt);
        sw.Close();
    }

    public static string Leer(string path)
    {
        string aux = "No se pudo leer";

        if (File.Exists(path))
        {
            StreamReader sr = new StreamReader(path);
            aux = sr.ReadToEnd();
            sr.Close();
        }
        else
        {
            throw new FileNotFoundException();
        }

        return aux;
    }
}

