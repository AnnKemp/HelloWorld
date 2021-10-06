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

        }
    }
}
