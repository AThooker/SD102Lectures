using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ternaries
{
    class Ternaries
    {
        static void Main(string[] args)
        {

            // type variableName = condition ? trueResult : falseResult
            bool isHappy = false;
            bool isAngry = isHappy ? true : false;
            Console.WriteLine(isAngry);

            //Get input from user about their favorite weather temp
            Console.WriteLine("what is your ideal outside temp?");
            int degrees = int.Parse(Console.ReadLine());
            string perfectWeather = degrees > 40 && degrees < 70 ? "My kind of weather" : "Not my vibe man";
            Console.WriteLine(perfectWeather);
            //ternaries can get nasty really quick
            //just to show how capable ternaries are
            //can be simplified because they both have to be true to be true...&& would work
            int age = 18;
            bool isAdult = age > 17 ? (age < 25 ? true : false) : false;
            Console.WriteLine(isAdult);
            Console.ReadLine();
        }
            //ternaries are for simplifying if else statements, and checking post data authorization
    }
}
