﻿using System;
using System.Diagnostics;
using System.Text;

namespace BasicCSharpConsole.Exercises.String
{
    public class StringConcat
    {
        static void Main()
        {
            var test = new StringConcat();
            var loopCount = 100_000;
            var timer = Stopwatch.StartNew();

            test.ConcatUsingString(loopCount);
            Console.WriteLine($"Concatenating strings took {timer.ElapsedMilliseconds} ms.");
            timer.Restart();
            test.ConcatWithStringBuilder(loopCount);
            Console.WriteLine($"Concatenating StringBuilder took {timer.ElapsedMilliseconds} ms.");
            timer.Reset();
            Console.ReadKey();

        }

        public void ConcatUsingString(int count)
        {
            var str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += " ";
            }
        }

        public void ConcatWithStringBuilder(int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(" ");
            }
        }
    }
}
