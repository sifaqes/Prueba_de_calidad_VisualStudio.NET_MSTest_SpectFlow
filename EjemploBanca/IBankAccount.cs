using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploBanca
{
    public interface IBankAccount  
    {
        decimal GetBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);

    }
}
