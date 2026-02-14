using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
        public static void Run()
        {
              double bal = 1000.00

            Console.WriteLine ("Gigi Urot");
            Console.WriteLine ("=== Simple ATM System ===");
            Console.WriteLine("Initial Balance = " + bal);

            while(true)
        {
            Console.WriteLine("\n1:Check Balance");
            Console.WriteLine("2:Deposit Money");
            Console.WriteLine("3:Withdraw Money");
            Console.WriteLine("4:Print Mini Statement");
            Console.WriteLine("5.Exit");
            Console.Write("Choose Option: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    CheckBalance(bal);
                break;
                
                case 2:
                    Console.Write("Enter amount to deposit:" );
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                
                if(depositAmount <=0)
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                    continue;
                    }
                
                Deposit(ref bal, depositAmount);
                lastTransaction = depositAmount;
                
                Console.WriteLine("Deposit Successful");
                Console.WriteLine("Updated Balance: ₱ " + bal);
                break;
                
                case 3:
                    Console.Write("Enter amount to Withdraw");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                
                if(withdrawAmount <=0)
                    {
                        Console.WriteLine("Invalid withdraw amount. Please enter a positive value.");
                    continue;
                    }
                    
                    bool status;
                    Withdraw(ref bal, withdrawAmount, out status);
                    
                    if (status)
                    {
                        lastTransaction = withdrawAmount;
                        Console.WriteLine("Withdrawal Successful.");
                        Console.WriteLine("Updated Balance: ₱" + bal);
                    }
                    else
                    {
                        Console.WriteLine("Withdrawal Failed. Insufficient Balance.");
                    }
                break;
                
                case 4:
                    PrintMiniStatement(bal, lastTransaction);
                break;
                
                case 5:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                return;
                
                default:
                Console.WriteLine("Invalid option selected. Please try again.");
                break;
            }
        }
        }
    }
}
