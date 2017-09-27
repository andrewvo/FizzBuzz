using System;

namespace FizzBuzz.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool inputsCorrect = false;
            int intLower =0;
            int intUpper =0;
            string lower = "";
            string upper= "";
            while (inputsCorrect == false)
            {
                while (inputsCorrect == false)
                {
                    Console.Write("Please enter the lower bound:");
                    lower = Console.ReadLine();
                    Console.Write("Please enter the upper bound:");
                    upper = Console.ReadLine();



                    if (Int32.TryParse(lower,out intLower) == false)
                    {
                        Console.WriteLine("Lower bound entered is not an integer, please try again");
                    }
                    else if (Int32.TryParse(upper, out intUpper) == false)
                    {
                        Console.WriteLine("Upper bound entered is not an integer, please try again");
                    }
                    else if (intLower > intUpper)
                    {
                        Console.WriteLine("Lower bound is higher than upper bound, please try again");
                    }
                    else
                    {
                        inputsCorrect = true;
                    }
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
