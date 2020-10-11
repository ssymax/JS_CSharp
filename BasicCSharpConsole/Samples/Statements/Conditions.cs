﻿using System;

namespace BasicCSharpConsole.Samples.Statements
{
    class Conditions
    {
        public static void IfStatement(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("One or more arguments");
            }
        }

        public static void TernaryIfStatement(string[] args)
        {
            string message = args.Length == 0 ? "No arguments" : "One or more arguments";
            Console.WriteLine(message);
        }

        public static void SwitchStatement(string[] args)
        {
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
    }
}
