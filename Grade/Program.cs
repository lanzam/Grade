/* Name: Mariel Lanza
   Date: 1/20/2019
   Comments: This C# Console application code demonstrates on 
   how to declare a method and called in the main. For this project it will ask
   the user to input their name and will be called by calling a method.
 */ 
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Welcome! Please enter your first and last name...");

            /* The TRY + CATCH block will verify user input
               CATCH will handle bad input and will display an error message
            */
            try
            {   // Call the method Hello_User to respond back the user name 
                Hello_User();
                Console.ReadKey(true); // Pause 
            }
            catch
            {
                Console.WriteLine("Please enter valid characters.");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);  // Pause 
            } // End of catch
        } // End of Main
        private static void Hello_User()
        {
            string input; // This variable will gather the user input 
            input = Console.ReadLine(); 
            Console.WriteLine("Hello " + input + "!");
            return;
        } // End of methods 
    }  // End of class
} // End of namespace 
