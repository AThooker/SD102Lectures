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
            int randCount = rand.Next(0, 20);
            bool loop = true;
            while(loop)
            {
                if(randCount == 6 || randCount == 12)
                {
                    continue;
                }
                Console.WriteLine(randCount);
                if(randCount == 15)
                {
                    Console.WriteLine("uh oh it's 15");
                    loop = false;
                }
            }
            Console.ReadLine();
        }
    }
}
