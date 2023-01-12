using EjemploBanca;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace ProyectoPruebaMSTest_MethodoPrivado
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void DeberiaSerRico1000()
        {
            //Arrage
            var objetoPrivad = new PrivateObject(typeof(BankAccount));

            //Act
            objetoPrivad.Invoke("Deposit", 1000m);

            //Assert 

            var resultado = (string)objetoPrivad.Invoke("GetStatus");
            Assert.AreEqual("rich", resultado);

        }
    }


}
