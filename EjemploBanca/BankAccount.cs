

namespace EjemploBanca
{
    public class BankAccount : IBankAccount
    {
       
        private readonly ILog log = null;

        decimal _Balance = 0;
        
        public decimal GetBalance()
        { return _Balance; }

        private void SetBalance(decimal value)
        { _Balance = value; }
        

        public BankAccount() { }

        public BankAccount(ILog log){
            this.log = log;
        }

        public void Deposit (decimal amount)
        {
            if (amount > 0)
            {
                if (this.log != null && this.log.IsLogEnabled)
                {
                    log.WriteLine("Depositing the amount of '{0}'");
                }
                this.SetBalance(this.GetBalance() + amount);
            }
            else
                throw new System.ArgumentException("Negative amount deposited");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && this.GetBalance() >= amount) {
             
                this.SetBalance(this.GetBalance() - amount);             
            }
            else
                throw new System.ArgumentException("Negative amount withdrawn");
        }

        private string GetStatus()
        {
            return (this.GetBalance() < 1000) ? "poor" : "rich";
        }
        
    }
}
