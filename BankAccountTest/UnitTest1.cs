using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFirstDavidNichol;

namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AccountTypeTest()
        {
            BankAccount checking = new BankAccount(); // create checking acct
            checking.accountType = BankAccount.AccountType.Checking;

            Assert.AreEqual(checking.About(), "This Checking account currently has a balance of 0"); // make sure it is checking acct
            
            BankAccount savings = new BankAccount(); // create savings acct
            savings.accountType = BankAccount.AccountType.Savings;

            Assert.AreEqual(savings.About(), "This Savings account currently has a balance of 0");
        }

        [TestMethod]
        public void AccountBalanceTest()
        {
            BankAccount checking = new BankAccount(); // create checking acct
            checking.accountType = BankAccount.AccountType.Checking;

            checking.Deposit(1500); // checking has 1500

            Assert.AreEqual(checking.About(), "This Checking account currently has a balance of 1500");

            checking.Withdraw(500); // checking has 1000

            Assert.AreEqual(checking.About(), "This Checking account currently has a balance of 1000");

            checking.Withdraw(1500); // checking has -500

            Assert.AreEqual(checking.About(), "This Checking account currently has a balance of -500");

            Assert.IsTrue(checking.isNegative); // make sure isNegative is set true
        }


        [TestMethod]
        public void AccountTransferTest()
        {
            BankAccount checking = new BankAccount(); // create checking acct
            checking.accountType = BankAccount.AccountType.Checking;

            checking.Deposit(1500); // checking now has 1500

            BankAccount savings = new BankAccount(); // create savings acct
            savings.accountType = BankAccount.AccountType.Savings;

            checking.TransferFunds(savings,1000); // give 1000 from checking to savings

            Assert.AreEqual(savings.About(), "This Savings account currently has a balance of 1000");

            Assert.AreEqual(checking.About(), "This Checking account currently has a balance of 500");          

            Assert.AreEqual(checking.TransferFunds(savings, 1000), $"This Checking account cannot transfer to {savings} because it does not have the required funds");

            Assert.AreEqual(savings.About(), "This Savings account currently has a balance of 1000");
        }

    }
}
