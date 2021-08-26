using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections

            //Array
            //Hold only one kind element/data type, fixed length
            //Not used to add or remove data, arrays are used for arithmetic computing
            string stringExample = "OneString";
            string[] stringArray = { stringExample, "TwoStrings", "ThreeStrings" };

            //birds eye view of a house and how the address is how we get to each house, not the names of people
            string thirdItemOfArray = stringArray[2];
            Console.WriteLine(thirdItemOfArray);
            stringArray[0] = "FirstString";
            Console.WriteLine(stringArray[0]);
            Console.ReadLine();

            //Lists
            //Preferable to arrays almost always, much more functionality
            //Can add/remove data
                                           //new keyword initializes a new instance of this collection

            //List of strings
            List<string> listOfStrings = new List<string>();
            //init List of strings
            List<string> initListOfString = new List<string> { "one", "two", "three" };
            listOfStrings.Add("First string in our list");
            initListOfString.Add("four");
            //Show why you can't just print a List<string>, then print at [0]
            Console.WriteLine(listOfStrings);

            //List of ints
            List<int> listOfIntegers = new List<int>();
            Console.ReadLine();
            listOfIntegers.Add(1);
            listOfIntegers.Add(2);
            Console.WriteLine(listOfIntegers[0]);

            // Queue
            // First in first out, FIFO
            // Cars in a line in a tunnel, first one in is the first one out
            // line at BMV, FIFO
            Queue<string> fifo = new Queue<string>();
            //initialized Queue, may not show this
            fifo.Enqueue("I'm first!");
            fifo.Enqueue("I am next");
            string firstItemOut = fifo.Dequeue();
            Console.WriteLine(firstItemOut);

            //Dictionaries
            //stores key value pairs
            //key cannot be null, value can be
            //keys must be unique, values can be duplicated
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(5, "Value to Key 5");
            string valueSeven = keyAndValue[5];
            Console.WriteLine(valueSeven);
            Console.ReadLine();


            // --Other Collection Examples


            //similar to dictionary, but sorted by key
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            //unordered collection of unique elements
            //used when we want to prevent duplicate elements form being stored in collection
            HashSet<int> uniqueList = new HashSet<int>();
            //LIFO
            //Pringles can
            //Dinner plates
            //use push and pop to add and remove elements from stack
            Stack<string> lastInFirstOut = new Stack<string>();
        }
    }
}
