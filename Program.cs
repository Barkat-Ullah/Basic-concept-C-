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
            Console.WriteLine("Implicit Casting: " + b);
            //explicit type casting
            double c = 9.78;
            int d = (int)c; // Explicit casting from double to int
            Console.WriteLine("Explicit Casting: " + d);
        }
    }
}