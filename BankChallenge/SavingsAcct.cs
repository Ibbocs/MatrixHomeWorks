using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChallenge
{
    internal class SavingsAcct
    {
        public string AccountOwner;
        public Decimal Balance, Interest;
        int counter = 0;

        public SavingsAcct(string name,string surname, Decimal _interest, Decimal _balance)
        {
            AccountOwner = name+ " "+ surname;
            Balance = _balance;
            Interest = _interest;
        }

        public void Deposit(Decimal _deposit)
        {
            Balance += _deposit;
        }

        public void Withdraw(Decimal _withdraw)
        {
            //checking balance and procces count
            if (Balance>= _withdraw)
            {
                counter++;
                if (counter <4)
                {
                    Balance -= _withdraw;
                }
                else
                {
                    Balance -= (_withdraw + 2);
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance :)");
            }
        }

        public void ApplyInterest()
        {
            Balance = Balance + (Balance * Interest);
        }
    }
}
