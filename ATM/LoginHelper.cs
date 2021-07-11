using System;

namespace ATM
{
    static class LoginHelper
    {
        public static string TryLogin(uint accountNumber, uint pin, out Session session)
        {
            Account account = DatabaseHelper.GetAccount(accountNumber);
            session = null;
            string message = "";

            if (account == null)
            {
                message = "Invalid login credentials. Please try again.";

                return message;
            }

            if (account.Pin != pin)
            {
                HandleWrongPin(account);
                if (!account.Locked)
                {
                    message = "Invalid login credentials.";
                    return message;
                }
                else
                {
                    message = "Your account is locked." + Environment.NewLine + "Please contact our customer service.";

                    return message;
                }
            }

            if (account.Locked)
            {
                message = "Your account is locked." + Environment.NewLine + "Please contact our customer service.";

                return message;
            }

            account.ResetLoginAttempts();

            session = new Session(account);

            return message;
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