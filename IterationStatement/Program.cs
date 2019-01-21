using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer Value Between 1 and 100 ");
            /* Using the Try-catch Block To Validate UserInput
             * If the user provides bad input, the catch block 
             * will handle the error and amessage will be displayed.
             */

            try
            {
                string input = Console.ReadLine();

                int InputValue = int.Parse(input);

                while (InputValue > 0 && InputValue <= 100)
                {
                    Console.WriteLine("This will Execute a While Loop");

                    Console.WriteLine("You Have Entered " + InputValue.ToString() + ". This is the current integer value in the loop: #" + InputValue--);
                }

                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            } // End of Try

            catch
            {
                Console.WriteLine("Please enter an Integer Value and Try again");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);



            }

        }
    }
}
