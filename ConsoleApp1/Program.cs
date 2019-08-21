using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVariable = "Hello World!";
            DateTime myDateTime = new DateTime();

            string myStringVariable;
            myStringVariable = "steve";

            int myIntVariable;
            myIntVariable = 29384723;

            decimal myDecimalVariable;
            myDecimalVariable = 12345.3434m;

            bool myBool = false;

            if (myBool) {
                Console.WriteLine("We will never hit htis code");
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"we're on iteration {i}");
            }



            var myThing = new { Stuff = "steve" };

            List<string> myStrings = new List<string>();
            myStrings.Add("blerg");
            myStrings.Add("blarg");
            myStrings.Add("blirg");

            foreach(var myString in myStrings)
            {
                Console.WriteLine(myString);
            }

            Console.WriteLine();
        }
    }
}
