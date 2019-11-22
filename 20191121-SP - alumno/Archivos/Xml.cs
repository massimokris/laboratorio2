using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {

      public string GetDirectoryPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); } }

      public bool FileExists(string nombreArchivo)
      {
        string path = Path.Combine(this.GetDirectoryPath, nombreArchivo);
        if (File.Exists(path))
        {
          return true;
        }else
        {
          return false;
        }
      }

      public void Guardar(string nombreArchivo, T objeto)
      {
        string path = Path.Combine(this.GetDirectoryPath, nombreArchivo);
        

        try
        {
          XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);
          XmlSerializer serializer = new XmlSerializer(typeof(T));
          serializer.Serialize(writer, objeto);
          writer.Close();
        }
        catch (Exception e)
        {
          throw new ErrorArchivosException("Error al guardar archivo", e);
        }
        finally
        {
          //writer.Close();
        }
      }
      public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
      {
        string path = Path.Combine(this.GetDirectoryPath, nombreArchivo);
        

        try
        {
          XmlTextWriter writer = new XmlTextWriter(path, encoding);
          XmlSerializer serializer = new XmlSerializer(typeof(T));
          serializer.Serialize(writer, objeto);
          writer.Close();
        }
        catch (Exception)
        {
          throw new ErrorArchivosException("Error al guardar archivo");
        }
        finally
        {
          //writer.Close();
        }

      }
      public bool Leer(string nombreArchivo, out T objeto)
      {

        bool validation = false;
        string path = Path.Combine(this.GetDirectoryPath, nombreArchivo);
        

        try
        {
          
          XmlSerializer serializer = new XmlSerializer(typeof(T));
          XmlTextReader reader = new XmlTextReader(path);
          objeto = (T)serializer.Deserialize(reader);
          reader.Close();
          validation = true;
        }
        catch (Exception)
        {
          objeto = default(T);
          throw new ErrorArchivosException("Error al leer archivo");
        }
        finally
        {
          //reader.Close();
        }

        return validation;
      }

      public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
      {
        bool validation = false;
        string path = Path.Combine(this.GetDirectoryPath, nombreArchivo);
        

        try
        {
          XmlSerializer serializer = new XmlSerializer(typeof(T));
          XmlTextReader reader = new XmlTextReader(path);
          objeto = (T)serializer.Deserialize(reader);
          reader.Close();
          validation = true;
        }
        catch (Exception e)
        {
          objeto = default(T);
          throw new ErrorArchivosException("Error al leer archivo", e);
        }
        finally
        {
          //reader.Close();
        }
      return validation;
      }
  }
}
