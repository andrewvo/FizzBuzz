using System;

namespace FizzBuzz.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool inputsCorrect = false;     //These variables consists of flags, int and string versions of the upper and lower variables.
            int intLower =0;
            int intUpper =0;
            string lower = "";
            string upper= "";
            while (inputsCorrect == false) //This while loop will only exit if the lower and upper bounds entered by the user is valid.
            {
              
                Console.Write("Please enter the lower bound:");   //The console will read the values entered by the user and store them in the 
                lower = Console.ReadLine();                       //string versions of the lower and upper variables.
                Console.Write("Please enter the upper bound:");   
                upper = Console.ReadLine();                       



                if (Int32.TryParse(lower,out intLower) == false)   //The following if statements are used to verify if the string value entered                
                {                                                  //are able to be converted into integers, if not, the user is prompted to enter the values again
                    Console.WriteLine("Lower bound entered is not an integer, please try again");  
                }
                else if (Int32.TryParse(upper, out intUpper) == false)
                {
                    Console.WriteLine("Upper bound entered is not an integer, please try again");
                }
                else if (intLower > intUpper)                      //This if statement checks if the lower bound is higher that the upper bound. 
                {                                                  //User is prompted to enter values again if the If statement is true.
                    Console.WriteLine("Lower bound is higher than upper bound, please try again");
                }
                else
                {
                    inputsCorrect = true;                          //This flag is only set if the previous If statements are found to be false
                }
                
            }




            IGetOutput output = new GetOutput();

            for (var i = intLower; i <= intUpper; i++)
            {
                    Console.WriteLine(output.Get(i));
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();  //Used to keep console window open until enter key has been pressed
        }
    }
}
