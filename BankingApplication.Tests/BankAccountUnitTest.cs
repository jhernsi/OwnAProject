using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApplication;

namespace BankingApplication.Tests
{
    [TestClass]
    public class BankAccountUnitTest
    {
        [TestMethod]
        public void Check_OpeningBalance()
        {

            //Arrange
            decimal OpeningBalance = 100;

            BankAccount ba = new BankAccount("Jherna Mamtora", OpeningBalance);

            //Act

            decimal ActualBalance = ba.Balance;
            //Assert

            decimal ExpectedBalance =OpeningBalance;

            Assert.AreEqual(ExpectedBalance, ActualBalance);
        }

       [TestMethod]
        public void Perform_Withdrawal_CheckBalance()
        {
           //Arrange
            decimal OpeningBalance = 10;
            decimal AmountToWithdraw = 50;
            BankAccount ba = new BankAccount("Jherna Mamtora", OpeningBalance);

           //Act
            ba.Withdraw(AmountToWithdraw);

           //Assert

            decimal ExpectedBalance = OpeningBalance - AmountToWithdraw;
            Assert.AreEqual(ExpectedBalance, ba.Balance);
        }

       [TestMethod]
     //  [ExpectedException(typeof(ArgumentOutOfRangeException))]
       [ExpectedException(typeof(withDrawLessThanZeroException))]

       public void WithdrawLessThanZero_RaiseException()
       {
           //Arrange
           decimal OpeningBalance = 100;
           decimal AmountToWithdraw = -5;
           BankAccount ba = new BankAccount("Jherna Mamtora", OpeningBalance);

           //Act

           ba.Withdraw(AmountToWithdraw);

           //Assert

           //decimal ExpectedBalance = OpeningBalance - AmountToWithdraw;
           //Assert.AreEqual(ExpectedBalance, ba.Balance);

           //  Assert.Fail();

       }


        //[TestMethod]
      
        //public void WithdrawLessThanZero_RaiseException()
        //{
        //    //Arrange
        //    decimal OpeningBalance = 100;
        //    decimal AmountToWithdraw = -5;
        //    BankAccount ba = new BankAccount("Jherna Mamtora", OpeningBalance);

        //    //Act
        //    try
        //    {

        //        ba.Withdraw(AmountToWithdraw);
        //    }
        //    catch(Exception ex)
        //    {
        //        StringAssert.Contains(ex.Message, ba.WithdrawLessThanZeroError);
        //        return;

        //      //  Assert.AreEqual(ba.WithdrawLessThanZeroError, ex.Message);
        //    }

        //    //Assert

        //    //decimal ExpectedBalance = OpeningBalance - AmountToWithdraw;
        //    //Assert.AreEqual(ExpectedBalance, ba.Balance);

        //     // Assert.Fail();

        //}


    }
}
