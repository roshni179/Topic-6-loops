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
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
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
                    while (!int.TryParse(Console.ReadLine(), out userInput) && userInput <= max && userInput >= min)
                         Console.WriteLine("Invalid number, try again");
                   Console.WriteLine("Thank you");
                    
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();








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
}
