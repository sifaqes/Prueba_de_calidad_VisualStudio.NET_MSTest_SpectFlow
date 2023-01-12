using EjemploBanca;
using Moq;
using System;





namespace ProyectoPruebaMSTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext {get; set;}

        [TestMethod]
        public void DepositoReflojadoBalance()
        {
            //ARRANGE
            IBankAccount cuenta = new BankAccount();
            decimal cantidad = 123.4m;

            // act
            cuenta.Deposit(cantidad);

            //Assert
            Assert.AreEqual(cantidad, cuenta.GetBalance());

            this.TestContext.WriteLine("Ejecutando test '{0}.{1}'...", TestContext.FullyQualifiedTestClassName, TestContext.TestName);

        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DepositoNegativo()
        {
            //Arrage
            IBankAccount cuenta = new BankAccount();

            // Act
            cuenta.Deposit(-5);

            //Assert

        }

        [TestMethod]
        public void CuentaDeberiaRegistrarInformacion()
        {
            //Arrage
            var mocklog = new Mock<ILog>();
            mocklog.Setup(log => log.IsLogEnabled).Returns(true);
            IBankAccount cuenta = new BankAccount(mocklog.Object);

            //Act
            
            cuenta.Deposit(50.5m);

            //Assert
            mocklog.Verify(log => log.WriteLine(It.IsAny<string>()), Times.Once());//mocklog.Verify(log => log.WriteLine(It.IsAny<String>()), Times.Never());
            

        }




    }
}