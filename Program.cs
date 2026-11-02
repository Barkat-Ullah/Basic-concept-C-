//*syntax
using System;
namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Basic syntax and structure of a C# program
            /* Console.WriteLine("Hello World");
             int a = 10;
             int f = 100;
             int sum = a + f;
             Console.WriteLine("Sum: " + sum);
             double b = 20.5;
             string c = "Hello";
             bool d = true;
             float e = 30.5f;
             long g = 1000000000;

             Console.WriteLine("Integer: " + a); */
            //*type casting
            //implicit type casting
            int a = 10;
            double b = a; // Implicit casting from int to double
            // Console.WriteLine("Implicit Casting: " + b);
            //explicit type casting
            double c = 9.78;
            int d = (int)c; // Explicit casting from double to int
            // Console.WriteLine("Explicit Casting: " + d);

            //* c# string
            // user input
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age} years old.");
            double number = 3.14159;
            Console.WriteLine($"The value of pi is approximately {number:F2}."); */

            //* c# operators (+, -, *, /, %, ++, --, logical operators: &&, ||, !, comparison operators: ==, !=, >, <, >=, <=)
            int x = 10;
            int y = 3;
            int sum = x + y; // Addition
            int difference = x - y; // Subtraction
            int product = x * y; // Multiplication
            int quotient = x / y; // Division
            int remainder = x % y; // Modulus
            x++; // Increment
            y--; // Decrement
            a = +5; // Unary plus
            
            bool isGreater = x > y; // Greater than
            bool isLess = x < y; // Less than
            bool isEqual = x == y; // Equal to
            bool isNotEqual = x != y; // Not equal to
            bool isGreaterOrEqual = x >= y; // Greater than or equal to
            bool isLessOrEqual = x <= y; // Less than or equal to

            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder} Incremented x: {x}, Decremented y: {y} Unary plus a: {a} isGreater: {isGreater}, isLess: {isLess}, isEqual: {isEqual}, isNotEqual: {isNotEqual}, isGreaterOrEqual: {isGreaterOrEqual}, isLessOrEqual: {isLessOrEqual}");
        }
    }
}