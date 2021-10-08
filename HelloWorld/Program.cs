﻿using System;

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
            /* INT */
            int myNum;
            myNum = 10;
            myNum = 20;
            Console.WriteLine(myNum);
            /* STRING */
            string name = "John";
            Console.WriteLine(name);
            /* CONST */
            // constants are read only after they've initialised
            const int TheNum = 50;
            Console.WriteLine(TheNum);
            /* CHAR */
            char myLetter = 'A'; // always with single quotes!
            double doubleInt = 12.55D; // you must add a 'D' at the eind of the number, the float
            Console.WriteLine(doubleInt);
            /* combined */
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Hello " + firstName + " " + lastName);
            int x = 50, y = 30, z = 70;
            Console.WriteLine(x + y + z);
            /* LONG integer */
            long aNum = 15000000000L; // you must write an 'L' after the long number!
            Console.WriteLine(aNum);
            /* FLOAT */
            float flInt = 15.6F;
            Console.WriteLine(flInt);
            /* float and double with e */
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            /* BOOL */
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False
            /* implicit CASTING */
            int getal = 9;
            Console.WriteLine(getal);
            double puntkomma = getal; // int wordt omgezet naar double
            Console.WriteLine(puntkomma);
            /* explicit CASTING */
            double mijnkommaGetal = 9.78;
            Console.WriteLine(mijnkommaGetal);
            int mijnGetal = (int) mijnkommaGetal; // explicit casting via (int)
            Console.WriteLine(mijnGetal);
            /* convert to */
            int theInt = 10;
            double theDouble = 5.25;
            bool theBool = true;
            Console.WriteLine(Convert.ToString(theInt));
            Console.WriteLine(Convert.ToDouble(theInt));
            Console.WriteLine(Convert.ToInt32(theDouble));
            Console.WriteLine(Convert.ToString(theBool));
            /*-------------------------------------------------------------------*/
            /* get user input */
            Console.WriteLine("Enter Username"); 
            string UserName = Console.ReadLine();
            Console.WriteLine("Username is: " + UserName);
            /*-----------------------------------------------------------------------*/
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            /* OPERATORS */
            int getal1 = 40 + 100;
            int getal2 = getal1 + 60;
            int getal3 = getal2 + getal1;
            Console.WriteLine(getal3);
            /* CONCATENATION */
            string voorName = "John ";
            string achterName = "Doe";
            string naam = string.Concat(voorName, achterName);
            Console.WriteLine(naam);

        }
    }
}
