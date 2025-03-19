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

            Console.WriteLine("You chose option 2");
            Console.WriteLine("Hit ENTER to continue.");
            Console.Clear();

            Console.WriteLine("Your current account balance: $150 Bolorian dollars");
            Console.WriteLine();
            Console.WriteLine("You'll be charged $0.75 with each transaction");
            Console.WriteLine();
            Console.WriteLine("Hit Enter to see the available transactions ->");
            Console.ReadLine();
            Console.WriteLine("Available transactions: ");
            Console.WriteLine();
            Console.WriteLine("Desposit");
            Console.WriteLine("Withdrawal");
            Console.WriteLine("Bill payment");
            Console.WriteLine("Account balance update");
            Console.WriteLine("Q");

            bankchoice = Console.ReadLine().ToLower().Trim();
            Console.WriteLine();
            if (bankchoice == "")
            {
                
            }
            else if (choose == "2")
            {


                

            }
            // Add an else if for each valid choice...
            else
            {
                Console.WriteLine("Invalid choice, press ENTER to continue.");
                Console.ReadLine();
            }










        }
    }
}
