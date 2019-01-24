
/*
    Author: Gregory Gauthier
    Date: 1/22/2019
    Comments: This assignment shows off iterative statements.
*/

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


                // When the user inputs a value, perform this statement if the value is between 0 and 100
                while (InputValue > 0 && InputValue <= 100)
                {
                    Console.WriteLine("This will Execute a While Loop");

                    // Here I am concatenating the string and iterating InputValue. The -- will cause the value to decriment.
                    Console.WriteLine("You Have Entered " + InputValue.ToString() + ". This is the current integer value in the loop: #" + InputValue--);
                }
                // Check to see if the users input Value exceeds the stated argument values
                if (InputValue > 100 && InputValue < 0)
                {
                    Console.WriteLine("Please Enter a Different Number that Falls Between 0 - 100");
                }

                Console.WriteLine("Press any key to exit the program...");
                // When the user presses a key, close the program
                Console.ReadKey(true);
            } // End of Try

            catch
            {
                Console.WriteLine("Please enter an Integer Value and Try again"); 
                // If the User entered a bad value non-integer, have them try again.
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);



            }

        }
    }
}
