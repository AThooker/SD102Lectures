using System;

namespace ConditionalsForSD102
{
    public class Conditionals
    {
        static void Main(string[] args)
        {

            
            //bool is true/false statement
            //has to be a boolean value
            bool isGreater = 17 > 15;
            //variable holds the value we tell it to. 
            bool isFalse = 17 > 15;
            Console.WriteLine(isFalse);

            bool condition = false;
            if(condition)
            {
                //do something
                //since we have set condition = to false, this code will be unreachable
                Console.WriteLine("Hey there");
            }

            //use integers to assess if statements and show how to use within if else if else statements
            int number = 20;
            if(number > 20)
            {
                Console.WriteLine("whoa, big number");
            }
            else if (number > 10)
            {
                Console.WriteLine("Whoa, medium number");
            }
            else if (number > 0)
            {
                Console.WriteLine("Small number");
            }
            else
            {
                Console.WriteLine("Can't do that skip");
            }


            if(number > 20 && number < 100)
            {
                //and comparison
                //both conditions must be ture
            }

            if(number <= 100 || number >= 80)
            {
                //or comparison
                //only one condition must be true
            }

            if(number == 25)
            {
                //is equal to
            }
            if(number != 25)
            {
                //Not equal to
                //! bang operator
            }
        }

        private void SwitchCases()
        {
            int age = 42;

            //switch cases are used for case by case, not a range. single cases handled. if range is needed, then if else statements would be used
            switch(age)
            {
                case 20:
                    //code executed if age is 18
                    break;
                case 15:
                    break;
                case 5:
                    break;
                case 40:
                case 42:
                    //code goes here for stacked cases
                    break;
                default:
                    //catch all, similar to else with if statements
                    Console.WriteLine("you are not any of the ages within our switch case example");
                    break;
            }

        }

        public void Ternaries()
        {
            int age = 40;
            //bool variable = (boolean statment) ? trueValue : falseValue;

            bool isAge = (age == 40) ? true : false;
        }
    }
}
