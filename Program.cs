using System;

namespace Expon
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = 1290;
            int low = 0;
            bool goOn = true;
            while (goOn == true)
            {

                Console.WriteLine("Please enter an integer between 0 and 1290");
                string input = Console.ReadLine();
                int i = int.Parse(input);

                if (i > high)
                {
                    Console.WriteLine("That number is too high, Please enter a valid integer: ");
                }
                else if (i < low)
                {
                    Console.WriteLine("That number is too low, please enter a valid integer: ");
                }
                else
                {
                    Console.Write("\n\n");
                    Console.Write("Number\tSquared\t Cubed");
                    Console.Write("\n---------------------------------");
                    Console.Write("\n\n");

                    for (int c = 1; c <= i; c++)
                    {
                        Console.WriteLine($"{c}   \t{c * c}   \t{c * c * c}");

                    }
                }

                goOn = GetContinue();
            }

   
    static bool GetContinue()
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    return true;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");
                    return GetContinue();

                }
            }
        }
    }
}