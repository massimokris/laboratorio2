using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio54
{
    public static class ArchivoTexto
    {
      public static void Guardar(string txt)
      {
        StreamWriter sw = new StreamWriter("C:\\Users\\alumno\\Desktop\\texto.txt", true);
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
}
