using System;
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
            //While 
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


            //Bring in Random object
            //get random number and if it equals a certain number break the loop
            Random rand = new Random();
            bool loop = true;
            while(loop)
            {
                int randCount = rand.Next(0, 10);
                if(randCount % 2 == 0)
                {
                    Console.WriteLine($"we have an even number, {randCount} ");
                    break;
                }
                else
                {
                    Console.WriteLine($"We have an odd number, {randCount}");
                }
                if(randCount == 15)
                {
                    Console.WriteLine("unlucky 13, get me out of this loop");
                    loop = false;
                }
            }

            //FOR LOOPS


            Console.ReadLine();
        }
    }
}
