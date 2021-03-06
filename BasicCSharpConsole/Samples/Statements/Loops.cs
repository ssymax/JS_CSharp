﻿using System;

namespace BasicCSharpConsole.Samples.Statements
{
    class Loops
    {
        public static void ForStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        public static void ForEachStatement(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        public static void WhileStatement(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        public static void DoStatement(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }

        public static void BreakStatement(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }

        public static void ContinueStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }
    }
}
