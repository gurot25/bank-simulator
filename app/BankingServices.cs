namespace ATMApp.Services
{
    public static class BankingServices
    {
        // Store last transaction
        private static double lastTransactionAmount = 0;

        // Option 1: Pass-by-value (Check Balance)
        public static double GetBalance(double balance)
        {
            return balance;
        }

        // Option 2: ref (Deposit)
        public static bool Deposit(ref double balance, double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                lastTransactionAmount = amount;
                return true;
            }

            return false;
        }

        // Option 3: ref + out (Withdraw)
        public static void Withdraw(
            ref double balance,
            double amount,
            out bool isSuccessful)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                lastTransactionAmount = amount;
                isSuccessful = true;
            }
            else
            {
                isSuccessful = false;
            }
        }

        // Option 4: Get Last Transaction (Pass-by-value)
        public static double GetLastTransaction()
        {
            return lastTransactionAmount;
        }
    }
}

