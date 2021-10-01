using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CreditCardAccount
    {
        //Field

        private decimal _balance;

        //Prop

        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0;
                }
            }
        }
        //public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }


        //Ctor


        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return string.Format($"\nAccount: {AccountNumber}\n" +
                $"Customer Info: {CustomerInfo}\n" +
                $"Balance: {Balance}\n" +
                $"Is Past Due?: {IsPastDue}\n" +
                $"Annual Interest Rate: {AnnualInterestRate}");
        }


        //Method










    }//end class

}//end namespace
