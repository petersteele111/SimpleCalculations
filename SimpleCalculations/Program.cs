using System;

namespace SimpleCalculations
{
    class SimpleCalculations
    {
        // Enum for Menu
        public enum Menu : byte {
            simpleRetirement = 1,
            advancedRetirement,
            Quit
        }

        static void Main(string[] args)
        {
            /************************************************
            | Title: Retirement Calculator                  |
            | Application Type: Console                     |
            | Description: Calculate your retirement needs  |
            | Author: Peter Steele                          |
            | Date Created: 9/17/2019                       |
            | Last Modified:                                |
            ***********************************************/

            // Instantiate type as menu
            SimpleCalculations menu = new SimpleCalculations();

            // Generate the Menu and respond to user's request
            while (true)
            {
                GenerateConsole();
                menu.getMenu();
            }
        }

        // Method to generate the console screen
        private static void GenerateConsole()
        {
            // Setup UI for application
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, 0);
                Console.Write("-");
            }


            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, 4);
                Console.Write("-");
            }

            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, 28);
                Console.Write("-");
            }

            // Setup program name and colors
            Console.SetCursorPosition(45, 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Retirement Calculator v1.0");
            Console.ResetColor();
            Console.SetCursorPosition(1, 5);
        }
        
        // Method to generate the menu
        public void getMenu() {

            // Setup menu screen and colors
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"
              Menu

  1. Calculate Simple Retirement
  
  2. Calculate Advanced Retirement
  
  3. Quit Application
  


  








  Option (1-5): ");

            // Set cursor to visible, since a method below hides it
            // This resets it to being visible on the menu screen
            Console.CursorVisible = true;
            string userResponse = Console.ReadLine();
            int.TryParse(userResponse, out int option);

            // Cast option(int) to Menu enum type
            Menu menuChoice = (Menu)option;

            // Switch statement based on user input
            switch (menuChoice)
            {
                case Menu.simpleRetirement:
                    simpleRetirement();
                    break;
                case Menu.advancedRetirement:
                    advancedRetirement();
                    break;
                case Menu.Quit:

                    // Generate the exit screen and prompt user to quit
                    Console.Clear();
                    GenerateConsole();
                    Console.Write("Are you sure you want to quit? (Y)es or (N)o: ");
                    userResponse = Console.ReadLine().ToLower(); 
                    if (userResponse == "y" || userResponse == "yes")
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    break;
            }

        }
        
        // Method to calculate simple retirement
        public void simpleRetirement() {

            // Generate new screen and display rules
            GenerateConsole();
            Console.WriteLine(@"
  Ok, lets calculate a simple retirement amount. You'll need a couple peices of information.

  1. Current Age
  2. Retirement Age
  3. Annual Savings");

            // Prompt user to input required information
            Console.SetCursorPosition(2, 12);
            Console.Write("Current Age: ");
            double.TryParse(Console.ReadLine(), out double currentAge); 
            Console.SetCursorPosition(2, 13);
            Console.Write("Retirement Age: ");
            double.TryParse(Console.ReadLine(), out double retireAge);
            Console.SetCursorPosition(2, 14);
            Console.Write("Planned Annual Savings: ");
            double.TryParse(Console.ReadLine(), out double annualSavings);
            Console.WriteLine();

            // Perform the required calculations 
            double yearsRemaining = retireAge - currentAge;
            double retirementAmount = yearsRemaining * annualSavings;

            // Creates the results screen, and displays the user info in a table
            GenerateConsole();
            Console.SetCursorPosition(46, 6);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Simple Retirement Results");
            Console.ResetColor();
            Console.SetCursorPosition(37, 8);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 9);
            Console.WriteLine(String.Format("|{0,11}|{1,14}|{2,14}|", "Current Age", "Retirement Age", "Annual Savings"));
            Console.SetCursorPosition(37, 10);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 11);
            Console.WriteLine(String.Format("|{0,11}|{1,14}|{2,14:c}|", currentAge, retireAge, annualSavings));
            Console.SetCursorPosition(37, 12);
            Console.WriteLine("-------------------------------------------");

            // Displays the actual results table
            Console.SetCursorPosition(37, 15);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 16);
            Console.WriteLine(String.Format("|{0,15}|{1,25}|", "Years Remaining", "Amount at Retirement"));
            Console.SetCursorPosition(37, 17);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 18);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("|{0,15}|{1,25:c}|", yearsRemaining, retirementAmount));
            Console.ResetColor();
            Console.SetCursorPosition(37, 19);
            Console.WriteLine("-------------------------------------------");

            // Displays a generated date and time for the user
            Console.SetCursorPosition(37, 21);
            Console.WriteLine($"Report generated on {DateTime.Now.ToString("MM/dd/yyyy")} at {DateTime.Now.ToString("h:mm tt")}");

            // Pause for the user and ask them to press a key to return to the menu
            Console.SetCursorPosition(38, 27);
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.CursorVisible = false;
            Console.ReadKey(); 
        }

        // Calculate advanced retirement
        public void advancedRetirement() {

            // Generate new screen and display rules
            GenerateConsole();
            Console.WriteLine(@"
  Ok, lets calculate an advanced retirement amount. You'll need a couple peices of information.

  1. Current Age
  2. Retirement Age
  3. Annual Savings
  4. Current Retirement Savings
  5. Investment Amount
  6. APR on Investments");

            // Prompt the user for the required information
            Console.SetCursorPosition(2, 15);
            Console.Write("Current Age: ");
            double.TryParse(Console.ReadLine(), out double currentAge);
            Console.SetCursorPosition(2, 16);
            Console.Write("Retirement Age: ");
            double.TryParse(Console.ReadLine(), out double retireAge);
            Console.SetCursorPosition(2, 17);
            Console.Write("Planned Annual Savings: ");
            double.TryParse(Console.ReadLine(), out double annualSavings);
            Console.SetCursorPosition(2, 18);
            Console.Write("Current Retirement Savings: ");
            double.TryParse(Console.ReadLine(), out double currentSavings);
            Console.SetCursorPosition(2, 19);
            Console.Write("Current Investment Amount: ");
            double.TryParse(Console.ReadLine(), out double investment);
            Console.SetCursorPosition(2, 20);
            Console.Write("APR on Investments (i.e 20 = 20%): ");
            double.TryParse(Console.ReadLine(), out double apr);
            Console.WriteLine();

            // Convert the apr to a percentage
            apr /= 100;

            // Perform the required math
            double yearsRemaining = retireAge - currentAge;
            double investmentTotal = (investment * apr) * yearsRemaining;
            double retirementAmount = investmentTotal + currentSavings + (yearsRemaining * annualSavings);

            // Generates the results screen, and displays the user info in a table
            GenerateConsole();
            Console.SetCursorPosition(45, 6);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Advanced Retirement Results");
            Console.ResetColor();
            Console.SetCursorPosition(14, 8);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(14, 9);
            Console.WriteLine(String.Format("|{0,11}|{1,14}|{2,14}|{3,26}|{4,11}|{5,8}|", "Current Age", "Retirement Age", "Annual Savings", "Current Retirement Savings", "Investments", "APR %"));
            Console.SetCursorPosition(14, 10);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(14, 11);
            Console.WriteLine(String.Format("|{0,11}|{1,14}|{2,14:c}|{3,26:c}|{4,11:c}|{5,8:P}|", currentAge, retireAge, annualSavings, currentSavings, investment, apr));
            Console.SetCursorPosition(14, 12);
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            // Displays the actual results table
            Console.SetCursorPosition(37, 15);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 16);
            Console.WriteLine(String.Format("|{0,15}|{1,25}|", "Years Remaining", "Amount at Retirement"));
            Console.SetCursorPosition(37, 17);
            Console.WriteLine("-------------------------------------------");
            Console.SetCursorPosition(37, 18);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("|{0,15}|{1,25:c}|", yearsRemaining, retirementAmount));
            Console.ResetColor();
            Console.SetCursorPosition(37, 19);
            Console.WriteLine("-------------------------------------------");

            // Displays a generated date and time for the user
            Console.SetCursorPosition(37, 21);
            Console.WriteLine($"Report generated on {DateTime.Now.ToString("MM/dd/yyyy")} at {DateTime.Now.ToString("h:mm tt")}");


            // Pause for the user and ask them to press a key to return to the menu
            Console.SetCursorPosition(38, 27);
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
