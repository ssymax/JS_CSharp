using System;
using System.Collections.Generic;

namespace BasicCSharpConsole.Samples.Statements
{
    class Jumps
    {

        public static void ReturnStatement(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            return;
        }

        public static void TryCatch(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Two numbers required");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

        public static void YieldStatement(string[] args)
        {
            foreach (int i in Range(-10, 10))
            {
                Console.WriteLine(i);
            }
        }


        private static IEnumerable<int> Range(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                yield return i;
            }
            yield break;
        }

        private static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
