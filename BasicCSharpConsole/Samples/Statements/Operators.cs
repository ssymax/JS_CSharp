﻿using System;
using System.IO;
using System.Text;

namespace BasicCSharpConsole.Samples.Statements
{
    public class Operators
    {
        public void SimpleArithmeticOperations()
        {
            int a = 3;
            int b = 5;

            int sum = a + b; // adding
            int substract = b - a; // subjecting
            int multiply = a * b; // multiplying
            int div = b / a; // Dividing integers !!!

            double x = 5.12;
            double y = 8.5;

            double sumD = x + y; // adding
            double substractD = y - x; // subjecting
            double multiplyD = x * y; // multiplying
            double divD = x / y; // Dividing integers


            double expression = a + b / x;
            double expression2 = (a + b) / x;

            int c = 1;
            c++; // c = c + 1;
            c += 2; // c = c + 2
            var value2 = ++c;


            int num = 3_000_000; //real literal
            float num1 = 30f; // or 30F - represents a value of 3.0
            double num2 = 30d; // or 30D - represents a value of 3.0
            decimal num3 = 30m; // or 30M - represents a value of 3.0
        }

        public void ArithmeticComparers()
        {
            int a = 2;
            int b = 3;
            double c = 4.0;

            bool result = a > b; //<
            result = a >= b; // <=
            result = a == b; // !=

            var mod = b % a; // modulo
        }

        public void BooleanOperations()
        {

            bool and = true && false; //and
            bool or = true || false;
            bool negation = !true;
        }

        public void StringOperations()
        {
            string name = "John";

            string message = "My name is " + name + ".";
            string message1 = $"My name is {name}."; //string interpolation
            string message2 = string.Format("My name is {0}.", name);
            string message3 = string.Concat("My name is ", name, ".");
            string filePath = @"C:\Temp\File.txt";
            string multiLineString = @"First line of text,
                                       second line of text,
                                       third line of text";
            Console.WriteLine(multiLineString);
            string textWithWhiteCharacters = "First\tline of text,\nsecond\tline of text,\nthird\tline of text";
            Console.WriteLine(textWithWhiteCharacters);

            StringBuilder stringBuilder = new StringBuilder("My name is ");
            stringBuilder.Append(name);
            stringBuilder.Append(".");
            string message4 = stringBuilder.ToString();
        }



        public void CastOperations()
        {
            int i = (int)5d; //explicit cast
            double d = 5; //implicit cast

            Stream s = new FileStream("", FileMode.OpenOrCreate);
            bool isFileStream = s is FileStream; //true

            FileStream fs = s as FileStream; // ok
            //FileStream fs = (FileStream) s; // only if we are sure it works, exception otherwise

            s = new MemoryStream();
            fs = s as FileStream; // returns null, but does not throw an exception
        }

        public void DynamicOperations()
        {
            dynamic someVariable = 5;
            Console.WriteLine($"{nameof(someVariable)}\t{someVariable.GetType().Name}\t{someVariable}");

            someVariable = "message";
            Console.WriteLine($"{nameof(someVariable)}\t{someVariable.GetType().Name}\t{someVariable}");

            someVariable = new Operators();
            someVariable.BooleanOperations();
            Console.WriteLine($"{nameof(someVariable)}\t{someVariable.GetType().Name}\t{someVariable}");
            try
            {
                someVariable.YouCanUseAnyMethodYouLikeHere(someVariable); //this will throw exception on runtime
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
