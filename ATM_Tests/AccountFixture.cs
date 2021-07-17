using ATM;
using NUnit.Framework;

namespace ATM_Tests
{
    [TestFixture]
    public class AccountFixture
    {
        [Test]
        public void TrySubtractFromBalance_SufficientFunds()
        {
            //1) Arrange
            var account = new Account(123, 123, 1000, 3, false);

            //2) Act
            bool transactionSuccessful = account.TrySubtractFromBalance(200);

            //3) Assert
            Assert.IsTrue(transactionSuccessful);
            Assert.That(account.Balance.Equals(800));
        }

        [Test]
        public void TrySubtractFromBalance_UnsufficientFunds()
        {
            //1) Arrange
            var account = new Account(123, 123, 100, 3, false);

            //2) Act
            bool transactionSuccessful = account.TrySubtractFromBalance(200);

            //3) Assert
            Assert.IsFalse(transactionSuccessful);
            Assert.That(account.Balance.Equals(100));
        }

        [Test]
        public void AddToBalance_FundsAdded()
        {
            //1) Arrange
            var account = new Account(123, 123, 1000, 3, false);

            //2) Act
            account.AddToBalance(200);

            //3) Assert
            Assert.That(account.Balance.Equals(1200));
        }

    }
}
