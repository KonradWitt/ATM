using System;

namespace ATM
{
    public class Session
    {
        public Account account { get; set; }

        public Session(Account _account)
        {
            if (_account == null)
            {
                throw new ArgumentNullException("Account cannot be null");
            }

            account = _account;
        }

        public void CloseSession()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            databaseHelper.UpdateAccount(account);
        }

        public void PayIn(double amount, out string message)
        {
            if (amount > 0)
            {
                account.AddToBalance(amount);
                message = $"{amount}$ has been paid into the account {account.Number}." + Environment.NewLine + $"The current balance of account {account.Number} is {account.Balance}$.";
            }
            else
            {
                message = $"The amount of money to be paid in has to be positive. The balance of account {account.Number} remains {account.Balance}$.";
            }
        }

        public void PayOut(double amount, out string message)
        {
            if (amount > 0)
            {
                bool subtractSuccessful = account.TrySubtractFromBalance(amount);

                if (subtractSuccessful)
                {
                    message = $"{amount}$ has been paid out of the account {account.Number}." + Environment.NewLine + $"The current balance of account {account.Number} is {account.Balance}$.";
                }
                else
                {
                    message = "Unsuficcient funds to perform this operation." + Environment.NewLine + $"The balance of account {account.Number} remains {account.Balance}$.";
                }
            }
            else
            {
                message = $"The amount of money to be withdrawn has to be positive. The balance of account {account.Number} remains {account.Balance}$.";
            }
        }

        public void CheckBalance(out string message)
        {
            message =  $"Current balance of account {account.Number} is {account.Balance}$.";
        }
    }
}
