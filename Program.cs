using System;

namespace SumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int userNumber;             //Holds the number entered by the user and is used in calculations
            int finalDigit;             //Holds the last digit of the user number on each iteration of the while loop
            int sum = 0;                //Holds the sum of each of the digits in the number entered by the user
            bool mathDone = false;      //Used to verify that the math required to get the sum of the digits in the user number has been completed
            bool validEntry = false;    //Used to verify that the user has entered a whole number and nothing else

            //Loops as long as the user has not entered a valid whole number
            while (validEntry == false)
            {
                //Clears the console and prompts the user to enter a number
                Console.Clear();
                Console.Write("Enter a number to calculate the sum of its digits: ");

                /**
                 * Attempts to convert the user entry to an integer
                 * Program carries on if successful and prompts the user to try again if not successful
                 */
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {
                    //Sets validEntry boolean to true
                    validEntry = true;

                    //loops as long as the calculations have not been completed
                    while (mathDone == false)
                    {
                        /**
                         * Checks if userNumber has decreased to 9 or less
                         * Sets mathDone boolean to true if it has
                         */
                        if (userNumber <= 9)
                            mathDone = true;

                        /**
                         * Retrieves the final digit of the user number by dividing it by 10 and keeping the remainder
                         * Divides the user number by 10 to remove the last digit after it has been retrieved
                         * Adds the last digit of the user number that was previously retrieved to the sum
                         */
                        finalDigit = userNumber % 10;
                        userNumber = userNumber / 10;
                        sum = sum + finalDigit;
                    }
                }
                /**
                 * Clears the console
                 * Prompts user for another entry in the event that their previous entry was not a valid whole number
                 */
                else
                {
                    Console.Clear();
                    Console.Write("Entry must be a whole number, please try again: ");
                }
            }

            //Prints the sum of the user's number to the console before awaiting a key press to close the console
            Console.WriteLine("The sum of your number's 5 digits is: {0}", sum);
            Console.ReadKey();
        }
    }
}
