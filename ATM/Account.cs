namespace ATM
{
    public class Account
    {
        public readonly uint Number;
        public ushort Pin {get; private set;}
        public double Balance {get; private set;}
        public uint RemainingLoginAttempts {get; private set;}
        public bool Locked { get; private set;}

        public Account(uint number, ushort pin, double balance, uint remainingLoginAttempts, bool locked)
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