using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Transactions;

namespace Topic_6_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Die die1;

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Bank of Blorb");
                Console.WriteLine("3 - Doubles Roller");
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
                else if (choice == "3")
                {
                    DoublesRoller();

                }
                
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }



        }
        public static void DoublesRoller()
        {
            Die die1, die2;
            int rolls = 0;
            
            Console.WriteLine("Hit ENTER!");
            Console.Clear();
            Console.WriteLine("Let's see if you have doubles");
            die1 = new Die();
            System.Threading.Thread.Sleep(10);
            die2 = new Die();
            die1.DrawDie();
            die2.DrawDie();
            rolls++;
          
            while (die1.Roll != die2.Roll)
            {
                die1.RollDie();
                die2.RollDie();
                die1.DrawDie();
                die2.DrawDie();
                Console.WriteLine("=================");
            }
            Console.WriteLine("Doubles!");
           
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            

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
            double balance = 150, depositAmount, transactionfee = 0.75, withdrawalAmount, billAmount;


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
                    balance -= transactionfee;
                    {
                        Console.WriteLine("Enter the amount you wish to withdraw");
                        if (!double.TryParse(Console.ReadLine(), out withdrawalAmount))
                            Console.WriteLine("Invalid number");

                        if (withdrawalAmount < 0 || withdrawalAmount > balance)
                        {
                            Console.WriteLine("That is an invalid withdrawal amount");
                            withdrawalAmount = 0;
                        }

                        else
                        {
                            balance -= withdrawalAmount;
                        }

                        Console.WriteLine($"Your withdrawal amount {withdrawalAmount:C} and your current balance {balance:C}. ");
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using BOB bank. Hit Enter to return back to menu");
                        Console.ReadLine();


                        Console.Clear();

                    }


                }
                else if (bankchoice == "bill payment")
                {

                    balance -= transactionfee;

                    Console.WriteLine("Enter the amount you have to pay for bills");
                    if (!double.TryParse(Console.ReadLine(), out billAmount))
                        Console.WriteLine("Invalid number");
                    if (billAmount < 0 || billAmount > balance)
                    {
                        Console.WriteLine("Invalid amount");
                        billAmount = 0;
                    }
                    else
                    {
                        billAmount -= balance;

                    }

                    Console.WriteLine($"You paid {billAmount:C} and your current balance is {balance:c}. ");
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using BOB bank. Hit Enter to return back to menu");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (bankchoice == "account balance update")
                {
                    Console.WriteLine("Please hit ENTER to check your account balance");

                    Console.ReadLine();

                    balance = balance - transactionfee;
                    Console.WriteLine();
                    Console.WriteLine($"Your account balance is: {balance} ");
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using BOB bank. Hit Enter to return back to menu");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

             
               

            }

            

         }
         

        

        
    }
    

}
