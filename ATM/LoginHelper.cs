using System;

namespace ATM
{
    public static class LoginHelper
    {
        public static bool TryLogin(int accountNumber, int pin, out Session session, out string message)
        {
            session = null;
            message = "";
            DatabaseHelper databaseHelper = new DatabaseHelper();
            Account account = databaseHelper.GetAccount(accountNumber);

            if (account == null)
            {
                message = "Invalid login credentials. Please try again.";
                return false;
            }

            if (account.Pin != pin)
            {
                HandleWrongPin(account);
                databaseHelper.UpdateAccount(account);
                if (!account.Locked)
                {
                    message = "Invalid login credentials.";
                }
                else
                {
                    message = "Your account is locked." + Environment.NewLine + "Please contact our customer service.";
                }
                return false;
            }

            if (account.Locked)
            {
                message = "Your account is locked." + Environment.NewLine + "Please contact our customer service.";
                return false;
            }

            account.ResetLoginAttempts();

            session = new Session(account);

            return true;
        }

        private static void HandleWrongPin(Account account)
        {
            account.SubtractLoginAttempts();

            if (account.RemainingLoginAttempts == 0)
            {
                Console.WriteLine($"Your account is locked. Please contact our customer service." + Environment.NewLine);
                account.LockAccount();
            }
            else
            {
                Console.WriteLine($"Remaining Login attempts: {account.RemainingLoginAttempts}." + Environment.NewLine);
            }
        }
    }
}