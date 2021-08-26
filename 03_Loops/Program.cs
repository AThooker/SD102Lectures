﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE LOOP


            //spotify repeating song while rpeating song button is pressed
            //while (repeatSong)
            //{
            //    repeat song;
            //}



            //executes a block of code as long as a specified condition is reached
            // * Used when the number of loops is unsure * When you want the loop to break based on the condition, use while loop
            int number = 0;
            while (number != 10)
            {
                Console.WriteLine(number);
                //show infinite loop without total++ first
                //nubmer = number + 1;
                number++;
            }

            //show that loop doesn't have to depend on a number, but a condition
            int newNumber = 0;
            while(true)
            {
                if(newNumber == 10)
                {
                    Console.WriteLine("You did it, give yourself a cookie");
                    break;
                }
                newNumber++;
            }


            //give conceptual example of gong to movie menu screen on dvd player and going through options


            //while (watchingMovie)
            //{
            //play movie
            //select chapter
            //deleted scenes
            //stop (break while loop, done watching movie)
            //}

            //while with switch case in it
            bool looptyLoop = true;
            while(looptyLoop)
            {
                Console.WriteLine("Welcome to my store, what would you like to buy?: \n" +
                    "1. Car\n" +
                    "2. House\n" +
                    "3. Boat");
                int userInput = int.Parse(Console.ReadLine());
                switch(userInput)
                {
                    case 1:
                        Console.WriteLine($"You've bought a brand new car");
                        break;
                    case 2:
                        Console.WriteLine("You've bought a brand new house");
                        break;
                    case 3:
                        Console.WriteLine("You've bought a brand new boat");
                        break;
                    default:
                        Console.WriteLine("You have bought nothing you fool");
                        break;
                }
            }

            //Bring in Random object
            //get random number and if it equals a certain number break the loop
            //Random rand = new Random();
            //bool loop = true;
            //while(loop)
            //{
            //    int randCount = rand.Next(0, 10);
            //    if(randCount % 2 == 0)
            //    {
            //        Console.WriteLine($"we have an even number, {randCount} ");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"We have an odd number, {randCount}");
            //    }
            //    if(randCount == 7)
            //    {
            //        Console.WriteLine("unlucky 7, get me out of this loop");
            //        loop = false;
            //    }
            //}

            //Do while loops
            //Always execute at least once
            //do
            //{
            //   washHands;
            //}
            //while (HandsAreDirty);
            int iterator = 0;
            do
            {
                Console.WriteLine("Hi there");
                iterator++;
            }
            while (iterator < 1);
            Console.ReadKey();

            // FOR LOOPS

            // **Used when you know exactly how many times you want to loop through**when you want loop to break after a certain number of times, use for loop

            //Software that gives a person a certain number of times to enter password before locking them out

            // A lot of the time, the computer will know how many times it will loop while the programmer doesn't

            //3 expressions inside parentheses

            //for(1st; 2nd; 3rd)
            //{
            //    body;
            //}

            //1st expression declares and initializes our variable, always "i"...basically means index or iterable

            //for(int i = 1; 2nd; 3rd)
            //{
            //    body;
            //}

            // each expression is separated by ";"

            // 2nd expression is a conditional, as long as the expression evaluates to true, the loop continues

            //for(int i = 1; i <= 100; 3rd)
            //{
            //    body;
            //}

            // 3rd expression is used to alter or update your variable, typically "i"

            //for(int i = 1; i <= 100; i++)
            //{
            //    body;
            //}




            //Example


            int count = 3;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("I am the number 3"); 
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            string[] classList = { "Rob", "Ahmad", "Austin" };

            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine($"Hi there, {classList[i]}");
            }
            //Mention shortcut for tab tab

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
            string[] classListTwo = { "Ashley", "Ahmad", "Austin" };

            //foreach loops
            //Used whenever you iterate over the elements of a collection

            //foreach(type variable in collection)
            //{
            //    bodyOfCode;
            //}

            foreach(string student in classListTwo)
            {
                Console.WriteLine($"{student} is in class today");
            }


            int[] listOfNumbers = { 1, 2, 3 };

            foreach(int myVariable in listOfNumbers)
            {
                int myNewVariable = myVariable + 5;
                Console.WriteLine(myNewVariable);
            }

            string name = "Tony Stark";
            foreach(char letter in name)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
            Console.ReadLine();
        }
    }
}
