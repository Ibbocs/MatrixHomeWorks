using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class CheckingAcct 
    {
        public string AccountOwner;
        public Decimal Balance;

        public CheckingAcct(string name, string surName, Decimal _balance)
        {
            Balance = _balance;
            AccountOwner = name+" "+ surName;
        }

        public void Deposit(Decimal _deposit)
        {
            Balance += _deposit;
        }

        public void Withdraw(Decimal _withdraw)
        {
            if (Balance>=_withdraw)
            {
                Balance -= _withdraw;
            }
            else
            {
                Balance -= (_withdraw + 35);
            }
        }
    }
}
