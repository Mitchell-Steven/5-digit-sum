using System;

namespace SumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int userNumber;
            int finalDigit;
            int sum = 0;
            int min = 10000;
            int max = 99999;
            bool mathDone = false;

            //Prompts user for 5 digit number and converts it to an integer
            Console.Write("Enter a five digit number to calculate the sum of its 5 digits: ");
            userNumber = int.Parse(Console.ReadLine());

            //Loops as long as user enters a number smaller or larger than 5 digits
            while (userNumber < min || userNumber > max)
            {
                //Clears Console and prompts user to retry entering a 5 digits number and then converts it to an integer
                Console.Clear();
                Console.Write("Number must be 5 digits in length, please try again: ");
                userNumber = int.Parse(Console.ReadLine());
            }

            /*
             * Gets the last digit of the number by placing the remainder of the user entered number divided by 10 into the finalDigit variable
             * Places the remaining digits into the userNumber variable by dividing the user entered number by 10
             * Adds the last digit of the number to the sum variable
             * Repeats these steps until all 5 numbers have been added to the sum
             */
            while(mathDone == false)
            {
                if (userNumber <= 9)
                    mathDone = true;

                finalDigit = userNumber % 10;
                userNumber = userNumber / 10;
                sum = sum + finalDigit;
            }

            //Prints the sum of the user's 5 digit number to the console before awaiting a key press to close the console
            Console.WriteLine("The sum of your number's 5 digits is: {0}", sum);
            Console.ReadKey();
        }
    }
}
