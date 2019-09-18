using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculations
{
    class SimpleCalculations
    {
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

            /************************************************
            |                  Variables                    |
            ************************************************/

            int currentAge;
            int retireAge;
            int currentSaved;
            int investmentReturn;
            int annualIncome;
            int financialNeed;
            string userResp;

            GenerateConsole();

            Console.ReadLine(); 

        }

        // Generate the console screen
        private static void GenerateConsole()
        {
            // Setup box for main game frame
            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, 0);
                Console.Write("-");
            }


            for (int i = 0; i < 118; i++)
            {
                Console.SetCursorPosition(1 + i, 4);
                Console.Write("-");
            }


            for (int i = 0; i < 27; i++)
            {
                Console.SetCursorPosition(0, 1 + i);
                Console.WriteLine("|");
            }


            for (int i = 0; i < 27; i++)
            {
                Console.SetCursorPosition(119, 1 + i);
                Console.WriteLine("|");
            }


            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, 28);
                Console.Write("-");
            }
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Retirement Calculator v1.0");
            Console.SetCursorPosition(1, 5);
        }

        // Menu
        private static void GenerateMenu() {

        }
    }
}
