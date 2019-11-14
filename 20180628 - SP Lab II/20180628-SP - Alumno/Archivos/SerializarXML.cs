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
    public class SerializarXML<T> : IArchivos<T>
    {
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
    }  
}
