using System;

namespace FizzBuzz.App
{
    public class GetOutput : IGetOutput
    {
        public string Get(int value)
        {
            if (((value % 3) == 0) && ((value % 5) == 0))   //The FizzBuzz if Condition is implemented first to ensure no conflicts with
            {                                               // the "Fizz" and "buzz" if statements.  
                return "FizzBuzz";                          //If either of them were implemented before the "FizzBuzz" condition, "FizzBuzz"
            }                                               //would not output as either "Fizz" or "Buzz" would take precedence in the If else statement.
            else if ((value % 3) == 0)
            {
                return "Fizz";
            }
            else if ((value % 5) == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}