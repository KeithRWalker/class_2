using System;
using System.Collections.Generic;

namespace Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            //string
            var myString = "Keith";
            //int
            var myInt = 28;
            //decimal
            var myDecimal = 666.666m;
            //bool
            var myBool = false;
            // Object
            var myObject = new
            {
                Name = myString,
                age = myInt,
                favNum = myDecimal,
            };

            List<string> myStrings = new List<string>();
            myStrings.Add("Add");
            myStrings.Insert(1, "insert");
            myStrings.Insert(2, "remove Me");
            myStrings.Insert(1, "remove me with remove");
            myStrings.Remove("remove me with remove");
            myStrings.RemoveAt(2);

            foreach (var forEachItem in myStrings)
            {
                Console.WriteLine(forEachItem);
            }

            if (myBool)
            {
                Console.WriteLine("This shouldn't be seen!");
            }
            else
            {
                Console.WriteLine($"myBool = {myBool.ToString()}");
            }

            switch (myInt)
            {
                case 1:
                    Console.WriteLine("never");
                    break;
                case 28:
                    Console.WriteLine("well see this");
                    break;
                default:
                    Console.WriteLine("We'll never hit this line");
                    break;
            }

            var iCombo = 0;
            // Console.WriteLine($"iCombo = {iCombo}");
            Console.WriteLine(" starting loop...");

            for (var i = 0; i <= 5; i++)
            {
                
                Console.WriteLine($"STARTING LOOP #{i.ToString()}:");
                Console.WriteLine($"i = {i.ToString()}");
                Console.WriteLine($"iCombo = {iCombo.ToString()}");
                Console.WriteLine($"{iCombo.ToString()} + {i.ToString()}");
                iCombo += i;

                Console.WriteLine($"iCombo = {iCombo.ToString()}");
                Console.WriteLine($"ENDING LOOP #{i.ToString()}:");
            }

            var myAnonObj = new {Stuff = "Stuff", OtherStuff = 123,};

            Console.WriteLine("end");

        }
    }
}
