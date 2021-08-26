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
                    //code executed if age is 25
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
            //string input = Console.ReadLine();
            int input = int.Parse(Console.ReadLine());
            switch (input)
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


            // **Challenge** switch case asking the user for their favorite color from a selection of blue, red, green, or black. Convert the users' input to lowercase and write back to the console the color that the user chose. If they don't choose a color tell them to come back and try again

            Console.WriteLine("what is your favorite color between blue, red, green, and black?: ");
            string colorInput = Console.ReadLine().ToLower();

            switch(colorInput)
            {
                case "blue":
                    Console.WriteLine($"You chose the color {colorInput}");
                    break;
                case "red":
                    Console.WriteLine($"You chose the color {colorInput}");
                    break;
                case "green":
                    Console.WriteLine($"You chose the color {colorInput}");
                    break;
                case "black":
                    Console.WriteLine($"You chose the color {colorInput}");
                    break;
                default:
                    Console.WriteLine("that's not in our list of colors, come back and try again");
                    break;
            }

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
