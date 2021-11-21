namespace ATM
{
    public class Account
    {
        public readonly int Number;

        public int Pin {get; private set;}
        public double Balance {get; private set;}
        public int RemainingLoginAttempts {get; private set;}
        public bool Locked { get; private set;}

        public Account(int number, int pin, double balance, int remainingLoginAttempts, bool locked)
        {
            Number = number;
            Pin = pin;
            Balance = balance;
            RemainingLoginAttempts = remainingLoginAttempts;
            Locked = locked;
        }

        public void AddToBalance(double balanceChange)
        {
            Balance += balanceChange;
        }

        public bool TrySubtractFromBalance(double balanceChange)
        {
            if (Balance >= balanceChange)
            {
                Balance -= balanceChange;
                return true;
            }

            return false;
        }

        public void SubtractLoginAttempts()
        {
            if (RemainingLoginAttempts > 0)
            {
                RemainingLoginAttempts -= 1;
            }
            else 
            {
                RemainingLoginAttempts = 0;
            }
        }

        public void ResetLoginAttempts()
        {
            RemainingLoginAttempts = 3;
        }

        public void LockAccount()
        {
            Locked = true;
        }
    }
}