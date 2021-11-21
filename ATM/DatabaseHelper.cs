using System.Linq;


namespace ATM
{
    class DatabaseHelper
    {
        public void UpdateAccount(Account newAccount)
        {
            using (DatabaseEntities databaseContext = new DatabaseEntities())
            {
                    var accountInDatabase = databaseContext.DBAccounts.SingleOrDefault(x => x.Number == newAccount.Number);
                    if (accountInDatabase != null)
                    {
                        accountInDatabase.Balance = newAccount.Balance;
                        accountInDatabase.Locked = newAccount.Locked;
                        accountInDatabase.RemainingLoginAttempts = newAccount.RemainingLoginAttempts;
                    }
                databaseContext.SaveChanges();
            }
        }

        public Account GetAccount(int accountNumber)
        {
            using (DatabaseEntities databaseContext = new DatabaseEntities())
            {
                DBAccounts dbaccount = databaseContext.DBAccounts.Where((x) => x.Number == accountNumber).FirstOrDefault();
                if (dbaccount != null)
                {
                    return new Account(dbaccount.Number, dbaccount.Pin, dbaccount.Balance, dbaccount.RemainingLoginAttempts, dbaccount.Locked);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
