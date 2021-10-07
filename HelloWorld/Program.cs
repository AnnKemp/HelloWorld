using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I will print on a new line.");
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
            // This is a comment! 
            /* variables have types: int, bool, double, char and string */
            int myNum;
            myNum = 10;
            myNum = 20;
            Console.WriteLine(myNum);
            string name = "John";
            Console.WriteLine(name);
            // constants are read only after they've initialised
            const int TheNum = 50;
            Console.WriteLine(TheNum);
            char myLetter = 'A'; // always with single quotes!
            double doubleInt = 12.55D; // you must add a 'D' at the eind of the number, the float
            Console.WriteLine(doubleInt);
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Hello " + firstName + " " + lastName);
            int x = 50, y = 30, z = 70;
            Console.WriteLine(x + y + z);
            long aNum = 15000000000L; // you must write an 'L' after the long number!
            Console.WriteLine(aNum); 
        }
    }
}
