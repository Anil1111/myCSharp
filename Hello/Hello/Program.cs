﻿using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args) // args is an array of strings
        {
            Console.WriteLine("Your name is:");
            
            string name = Console.ReadLine(); // typed-lang. must declare its a string. This holds the input in a var

            Console.WriteLine("Hello, " + name); //strings need double quotes
            Console.WriteLine("How much sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine()); // int.parse will convert the number to a string


           
            if ( hoursOfSleep > 8 )
            {
                Console.WriteLine("You are well rested!");
            }
            else
            {
                Console.WriteLine("Dude, you need more sleep :(");
            }
            

        }
    }
}