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

            //logical operators
            bool logicalAnd = isGreater && isLess; // Logical AND
            bool logicalOr = isGreater || isLess; // Logical OR
            bool logicalNot = !isGreater; // Logical NOT

            // Console.WriteLine($"Logical AND: {logicalAnd}, Logical OR: {logicalOr}, Logical NOT: {logicalNot}");

            // Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder} Incremented x: {x}, Decremented y: {y} Unary plus a: {a} isGreater: {isGreater}, isLess: {isLess}, isEqual: {isEqual}, isNotEqual: {isNotEqual}, isGreaterOrEqual: {isGreaterOrEqual}, isLessOrEqual: {isLessOrEqual}");

            /*Console.WriteLine(Math.Max(10, 20)); // Output: 20
            Console.WriteLine(Math.Min(10, 20)); // Output: 10
            Console.WriteLine(Math.Abs(-5)); // Output: 5
            Console.WriteLine(Math.Round(3.7)); // Output: 4
            Console.WriteLine(Math.Ceiling(3.2)); // Output: 4
            Console.WriteLine(Math.Floor(3.8)); // Output: 3
            Console.WriteLine(Math.PI); // Output: 3.141592653589793
            Console.WriteLine(Math.Pow(2, 3)); // Output: 8 (power of 2 raised to 3)
            Console.WriteLine(Math.Sqrt(16)); // Output: 4 (square root of 16)
            Console.WriteLine(Math.Sin(Math.PI / 2)); // Output: 1 (sine of 90 degrees)
            Console.WriteLine(Math.Cos(0)); // Output: 1 (cosine of 0 degrees)
            Console.WriteLine(Math.Log(10)); // Output: 2.302585092994046 (natural logarithm of 10 )
            Console.WriteLine(Math.Truncate(3.9)); // Output: 3 (truncates the decimal part)

            */

            //* if, else, switch case, loop (for, foreach, while, do while)
            int ac = 30;
            int bc = 20;

            int[] numbers = { 1, 2, 3, 4, 5 };

            // for loop
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"for: {numbers[index]}");
            }

            // foreach loop
            foreach (int number in numbers)
            {
                Console.WriteLine($"foreach: {number}");
            }

            // while loop
            int whileIndex = 0;
            while (whileIndex < numbers.Length)
            {
                Console.WriteLine($"while: {numbers[whileIndex]}");
                whileIndex++;
            }

            // do while loop
            int doWhileIndex = 0;
            do
            {
                Console.WriteLine($"do while: {numbers[doWhileIndex]}");
                doWhileIndex++;
            }
            while (doWhileIndex < numbers.Length);

            //   if (ac > bc)
            //   {
            //       Console.WriteLine("Ac is greater than bc");
            //   }
            //   else if (ac == bc)
            //   {
            //       Console.WriteLine("Ac and Bc are equal");
            //   }
            //   else
            //   {
            //       Console.WriteLine("invalid");
            //   }

        //     switch (ac)
        //     {
        //         case 10:
        //             Console.WriteLine("Ac is 10");
        //             break;
        //         case 20:
        //             Console.WriteLine("Ac is 20");
        //             break;
        //         case 30:
        //             Console.WriteLine("Ac is 30");
        //             break;
        //         default:
        //             Console.WriteLine("Ac is not 10, 20 or 30");
        //             break;
        //     }
         }
    }
}
