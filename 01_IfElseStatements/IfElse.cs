using System;

namespace _01_IfElseStatements
{
    class IfElse
    {
        static void Main(string[] args)
        {
            bool userIsHappy = true;
            //if the condition is met, perform the code within the body of the if statement
            if (userIsHappy)
            {
                //do something here
                Console.WriteLine("I am happy");
            }

            //use comparison operator to show if number compares to another and assesses to true
            int hoursStudyingPerWeek = 5;
            if (hoursStudyingPerWeek < 40)
            {
                Console.WriteLine("Are you trying to fail?");
            }

            ////use false boolean to show how it wouldn't ever asses to true
            bool tookTrashOut = false;

            if (tookTrashOut)
            // try ! bang operator to show them it will make bool opposite
            {
                Console.WriteLine("You get $5");
            }
            else
            {
                Console.WriteLine("You owe me $10, I don't make the rules I just code them");
            }

            //Taking in user input about how many hours they sleep

            Console.WriteLine("How many hours do you sleep on avg /night?: ");
            string rating = Console.ReadLine();
            //int numberRating = int.Parse(Console.ReadLine());
            //int numberratintg = Convert.ToInt32(rating);
            int numberRating = int.Parse(rating);

            if (numberRating >= 8)
            {
                Console.WriteLine("Living the dream");
            }
            else if (numberRating >= 5)
            {
                Console.WriteLine("Could be better, could be worse");
            }
            else
            {
                Console.WriteLine("Night time is the right time to fight crime");
                if (numberRating <= 2)
                {
                    Console.WriteLine("I am batman");
                }
            }

            //Maybe do this one as a CHALLENGE??

            //Get users age, if they are older than 17, tell them congrats for being an adult, otherwise if they are older than 6 tell them they are still a child, and if they are older than 0, tell them to grow up. if they don't give a proper number, tell them to kcik rocks silly user

            Console.WriteLine("How old are you?: ");

            int age = int.Parse(Console.ReadLine());
            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult...NOT!");
            }
            else if (age > 8)
            {
                Console.WriteLine("You are still a kid, kiddo");
            }
            else if(age > 0)
            {
                Console.WriteLine("oh grow up");
            }
            else
            {
                Console.WriteLine("Kick rocks");
            }
            if(age >= 42 || age <= 40)
            {
                Console.WriteLine("well we know you are not 41 years old");
            }
            if(age < 42 && age > 40)
            {
                Console.WriteLine("Well, you must be 41");
            }
            Console.ReadLine();
        
        }
    }
}
