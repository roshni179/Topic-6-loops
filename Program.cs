using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Topic_6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Bank of Blorb");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {
                    Prompter();
                }
                else if (choice == "2")
                {
                    

                   BankOfBlorb();

                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            

        }
        public static void Prompter()
        {
            //Do option 1
            Console.WriteLine("You chose option 1");
            Console.WriteLine("Hit ENTER to continue.");
            Console.Clear();
            int max, min, userInput;

            Console.WriteLine("[You chose 'PROMPTER'] ");

            Console.WriteLine(" Enter a minimum value: ");
            while (!int.TryParse(Console.ReadLine(), out min))

                Console.WriteLine("Invalid number, try again");
            Console.WriteLine("Enter a maximum value: ");
            while (!int.TryParse(Console.ReadLine(), out max))
                Console.WriteLine("Invalid number, try again");

            Console.Write($"Choose a number between {min} & {max}:  ");
            while (!int.TryParse(Console.ReadLine(), out userInput) || (userInput > max || userInput < min))
                Console.WriteLine("Invalid number, try again");
            
            Console.WriteLine("Thank you");

            Console.ReadLine();
        }

        public static void BankOfBlorb()
        {
            string bankchoice;
            double balance = 150, depositAmount, transactionfee = 0.75, withdrawalAmount;


            Console.WriteLine("You chose option 2");
            Console.WriteLine("Hit ENTER to continue.");
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Welcome to the Bank of Blorb");
                Console.WriteLine();
                Console.WriteLine("You'll be charged $0.75 with each transaction");
                Console.WriteLine();
                Console.WriteLine("Hit Enter to see the available transactions ->");
                Console.ReadLine();
                Console.WriteLine("Available transactions: ");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawal");
                Console.WriteLine("Bill payment");
                Console.WriteLine("Account balance update");
                Console.WriteLine("Quit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Please type in the transactions you wish to proceed with: ");
                bankchoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                Console.Clear();
                if (bankchoice == "deposit")
                {
                    Console.WriteLine("Enter the amount you wish to deposit: ");
                    while (!double.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
                        Console.WriteLine("Invalid number: you have $150 in your account");
                    if (depositAmount >= 0)
                        balance += depositAmount;
                    balance -= transactionfee;

                    Console.WriteLine(value: $"your deposit amount: {depositAmount:C} and your current balance: {balance:C}.");
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using BOB bank. Hit Enter to return back to menu");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                
                // Add an else if for each valid choice...
                else if (bankchoice == "withdrawal")
                {
                   
                    {
                        Console.WriteLine("Enter the amount you wish to withdraw");
                        while (!double.TryParse(Console.ReadLine(), out withdrawalAmount) && withdrawalAmount > 0)
                            Console.WriteLine("Invalid number");
                        if (withdrawalAmount >= 0 && balance >= 150)
                            withdrawalAmount -= balance;
                            balance = withdrawalAmount - transactionfee;
                        Console.WriteLine($"Your withdrawal amount {withdrawalAmount:C} and your current balance {balance:C}. ");
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using BOB bank. Hit Enter to return back to menu");
                        Console.ReadLine();
                        Console.Clear();
                       
                    }
              
                }
            }
        }

        
        
            
            








        
    }
}
