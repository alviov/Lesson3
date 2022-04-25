using System;

namespace Lesson3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please, insert first argument");
            double x = Double.Parse(Console.ReadLine());
       
            Console.WriteLine("please, insert second argument");
            double y = Double.Parse(Console.ReadLine());

            Console.WriteLine("please, insert operation (*,/,+,-)");
            string operation = Console.ReadLine().ToString();

            if (operation == "*" || operation == "/" || operation == "+" || operation == "-")
            switch (operation)
            {
                case "*":
                    Console.WriteLine($"{x} {operation} {y} = {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"{x} {operation} {y} = {x / y}");
                    break;
                case "+":
                    Console.WriteLine($"{x} {operation} {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"{x} {operation} {y} = {x - y}");
                    break;
                default:
                    Console.WriteLine("Error. One or both arguments are wrong");
                    break;
            }
            else { Console.WriteLine("Error. Wrong operation"); }
            Console.ReadKey();
        }
    }
}
