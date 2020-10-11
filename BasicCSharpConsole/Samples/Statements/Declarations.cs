using System;

namespace BasicCSharpConsole.Samples.Statements
{
    class Declarations
    {
        public static void VariableDeclarations(string[] args)
        {
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine(a + b + c);
        }

        public static void ConstantDeclarations(string[] args)
        {
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine(pi * r * r);
        }
    }
}
