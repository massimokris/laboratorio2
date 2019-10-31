using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace Ejercicio45
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestMiMetodo()
    {
        Miclase.MiMetodo();
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestConstructor1()
    {
      new Miclase(5);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestConstructor2()
    {
      new Miclase();
    }

    [TestMethod]
    [ExpectedException(typeof(UnaExcepcion))]
    public void TestMiMetodo2()
    {
     Miclase mc = new Miclase("hola"); 
     mc.MiMetodo2();
    }
  }
}
