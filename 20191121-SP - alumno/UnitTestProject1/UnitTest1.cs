using System;
using Archivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestGuardarLeer()
    {
      Xml<Planeta> xml = new Xml<Planeta>();
      Planeta p = new Planeta(1, 2, 3, new object());
      Planeta p2 = new Planeta();
      string path = "prueba";
      xml.Guardar(path, p);
      xml.Leer(path, out p2);

      Assert.Equals(p, p2);
    }

    [TestMethod]
    [ExpectedException(typeof(ErrorArchivosException))]
    public void TestArchivo()
    {
      Xml<Planeta> xml = new Xml<Planeta>();
      Planeta p = new Planeta();
      string path = "";
      xml.Guardar(path, p);
    }
  }
}
