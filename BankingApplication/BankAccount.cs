using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class WithdrawException : Exception
    {
        public WithdrawException(string msg =" Withdrawal not allowed, please contact the branch") : base(msg)
        {

        }
    }




    public class withDrawLessThanZeroException : WithdrawException
    {
        public withDrawLessThanZeroException(string msg ="Withdraw below zero is requested") : base(msg)
        {

        }
    }


    public class withDrawMoreThanBalanceException : WithdrawException
    {
        public withDrawMoreThanBalanceException(string msg = "Withdraw more than balance requested")
            : base(msg)
        {

        }
    }
    public class BankAccount
    {
        // to do must be constants  but could not read in test
        public  string WithdrawLessThanZeroError ="Withdraw Less Than Zero Error ";
        public  string WithdrawMoreThanBalanceError ="Withdraw More than Balance Error";



        private string customerName;
        private decimal balance;

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public decimal Balance {
            get
            {
                return balance;
            }
        }



       // make the constructor

        public BankAccount (string cn ="", decimal ob =0)
        {
            // use the properties when they are they will help in data validation and test or if you would like to make some changes in the field or variable


            CustomerName = cn;  // why customer is upper case we have a property for customer
            balance = ob; // we did not set nay property for balance hence we are using lowercase balance

        }


        public void Withdraw (decimal AmountToWithdraw)
        {
            //if (AmountToWithdraw <=0)
            //    throw new ArgumentOutOfRangeException(WithdrawLessThanZeroError);

            //if (AmountToWithdraw >balance)
            //    throw new ArgumentOutOfRangeException(WithdrawMoreThanBalanceError);

            if (AmountToWithdraw <= 0)
                throw new withDrawLessThanZeroException();

            if (AmountToWithdraw > Balance)
                throw new withDrawMoreThanBalanceException();

            balance = balance - AmountToWithdraw;
        }
    }
}
