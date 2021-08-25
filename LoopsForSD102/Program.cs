using System;

namespace LoopsForSD102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //WHILE LOOP

            //executes a block of code as long as a specified condition is reached
            // * Used when the number of loops is unsure * When you want the loop to break based on the condition, use while loop

            int tired = 0; //always

            while (true)
            {
                if (tired == 2)
                {
                    tired++;
                    continue;
                }
                Console.WriteLine($"tired = {tired}");
                tired++;
                if (tired == 6)
                    break;

            }


            while(true)
            {
                if(false)
                {
                    Console.WriteLine("Not this one");
                }
                else
                {
                    Console.WriteLine("Hazaa, you chose wisely");
                    break;
                }
            }



            while (tired < 5)
            {
                Console.WriteLine("How tired are you on a scale 1-5?: ");
                int tiredRating = Int32.Parse(Console.ReadLine());

                if (tiredRating >= 1 && tiredRating <= 4)
                {
                    Console.WriteLine("You must sleep a lot");
                }
                else
                {
                    Console.WriteLine("bedtime is the right time to fight crime");
                }

            }

            // FOR LOOPS


            // **Used when you know exactly how many times you want to loop through**when you want loop to break after a certain number of times, use for loop

            //3 expressions inside parentheses


            //1st expression declares and initialized our variable, typically "i"
            //(int i = 1; 2nd; 3rd)

            // each expression is separated by ";"

            // 2nd expression is a conditional, as long as the expression evaluates to true, the loop continues
            // (int i = 1; i <= 100; 3rd)

            // 3rd expression is used to alter or update your variable, typically "i"
            // (int i = 1; i <= 100; i++)

            // Next we give the program the code we want to run at each value until we hit the number 100




            for(int i = 100; i < 200; i++)
            {
                Console.WriteLine(i);
            }





            //string number = "While my variable is number, I am actually of type string";



            //Example


            int count = 3;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }


            string[] cities = { "Indy", "Chicago", "Fort Wayne", "Nashville" };

            for(int i = 0; i < cities.Length - 1; i++)
            {
                Console.WriteLine(cities[i]);
            }


            string[] classList = { "Rob", "Ahmad", "Austin" };

            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine($"Hi there, {classList[i]}");
            }

            int cardDeck = 52;
            for (int i = 0; i < cardDeck; i++)
            {
                Console.WriteLine("Buzz");
            }
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Challenge
            //Bronze
            for (int i = 500; i <= 525; i++)
            {
                Console.WriteLine(i);
            }

            //Silver
            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }
            //Gold
            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            int[] listOfNumbers = { 1, 2, 3 };



            //FOREACH LOOPS


            //used to loop through elements in a collection
            //syntax is the type, variableName in collectionName
            //type      variableName        in      collectionName
            foreach (int num in listOfNumbers)
            {
                Console.WriteLine(num + 5);
            }
            foreach (string student in classList)
            {
                Console.WriteLine($"{student} is here today");
            }

            string myName = "Austin Hooker";
            string upperName = myName.ToUpper();
            foreach (char lettersInAustinsName in upperName)
            {
                if (lettersInAustinsName != ' ')
                {
                    Console.WriteLine(lettersInAustinsName);
                }
            }



            //DO WHILE LOOPS

            //** Used when you want to execute the body of the code at least once** when input from the user or statement of code is needed before the condition can be evaluated

            //int number = 0;

            //do
            //{
            //    Console.WriteLine("I am the body of the do-while loop");
            //    number += 100;
            //} while (number <= 200);

        }
    }
}
