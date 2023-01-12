using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using TechTalk.SpecFlow;
using EjemploBanca;


namespace PruebaMSTestSpectFlow
{
    [Binding]
    public class Feature1StepDefinitions
    {
        IBankAccount cuenta = null;

        [Given(@"cuenta bancaria con balance (.*)")]
        public void GivenCuentaBancariaConBalance(int p0)
        {
            cuenta = new BankAccount();
            //cuenta.Deposit(10);

        }

        [When(@"cuando saco (.*) pavos")]
        public void WhenCuandoSacoPavos(int p0)
        {
            try { cuenta.Withdraw(p0); } catch (Exception ex) {
                ScenarioContext.Current.Add("exception", ex);
            }
        }

        [Then(@"obtener un error")]
        public void ThenObtenerUnError()
        {
            Exception except = (Exception)ScenarioContext.Current["exception"];
            Assert.IsNotNull(except);
            //Assert.AreEqual("Negative amount withdrawn", except.Message);
        }
    }
}
