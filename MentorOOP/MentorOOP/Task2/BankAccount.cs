using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOOP.Task2
{
    public class BankAccount
    {
        string holderName;
        int balance;

        private int myVar;

        public BankAccount(string _name, dynamic _balance, int _accountNumber)
        {
            
            holderName= _name;
            
            myVar= _accountNumber;
            try
            {
                if (_balance<1)
                {
                    balance = 0;
                    throw new Exception("Insufficient Balance Ammount");
                }
                else
                {
                    balance = _balance;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            head:
                Console.WriteLine("Add Balance, Please");
                string cwRead = Console.ReadLine();

                bool check = int.TryParse(cwRead, out balance);;
                if (check == false)
                {
                    Console.WriteLine("Invalid Ammount, Try Aggain");
                    goto head;
                }

            }
        }

        public int accountNumber
        {
            get { return myVar; }

            private set { myVar = value; }
        }


        public void Depositing(int ammount)
        {
            try
            {
                if (ammount<1)
                {
                    throw new Exception("Invalid Amount, Try Again");
                }
                else
                {
                    balance += ammount;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Opperation Finished");
            }
        }

        public void Withdrawing(int ammount)
        {
            try
            {
                    if (ammount > balance)
                    {
                        throw new Exception("Invalid Amount, Try Again");
                    }
                    else
                    {
                        balance -= ammount;
                        Console.WriteLine($"Your Current Balance : {balance}");
                    }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Opperation Finished");
            
            }
           
        }
    }
}
