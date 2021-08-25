using System;

namespace _02_SwitchCase
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            int age = 40;

            //switch cases are used for case by case, not a range. single cases handled. if range is needed, then if else statements would be used
            switch (age)
            {
                case 20:
                    //code executed if age is 20
                    Console.WriteLine("20");
                    break;
                case 25:
                    //code executed if age is 15
                    Console.WriteLine("25");
                    break;
                case 5:
                    //code executed if age is 5
                    Console.WriteLine("you are 5 and coding? wow");
                    break;
                case 40:
                case 42:
                    //code goes here for stacked cases 40,42
                    Console.WriteLine("So are you 40 or 42?");
                    break;
                default:
                    //catch all, similar to else with if statements
                    Console.WriteLine("you are not any of the ages within our switch case example");
                    break;
            }

            //Switch case with user input return that they chose their number
            //show difference between case being number or string

            Console.WriteLine("Give me a number between 1 and 5: ");
            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Console.WriteLine("You chose the number " + input);
                    break;
                case 2:
                    Console.WriteLine($"You chose the number {input}");
                    break;
                case 3:
                    Console.WriteLine("You chose the number " + input);
                    break;
                case 4:
                    Console.WriteLine("You chose the number {0}" , input);
                    break;
                case 5:
                    Console.WriteLine("You chose the number " + input);
                    break;

            }
            Console.ReadLine();

            //Show if we have time
            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch(today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Garfield hates these");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Stacked cases y'all, days that end in y other than the Mon one");
                    Console.WriteLine($"Today is {today}");
                    break;



            }

        }
    }
}
