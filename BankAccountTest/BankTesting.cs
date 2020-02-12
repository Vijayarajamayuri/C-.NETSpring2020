using BankAccountDemo;
using NUnit.Framework;
namespace BankAccountTest
{
    public class Tests
    {
        private BankAccount account;
        [SetUp]
        public void Setup()
        {
            account = new BankAccount(100, "Ajay");
        }

        [Test]
        public void depositTest()
        {
            double actual = account.deposit(100);
            double expected = 200;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void withDrawTest()
        {
            double actual = account.withdraw(100);
            double expected = 0;
            Assert.AreEqual(actual, expected);
        }
    }


}