using System;

namespace LambdaOperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оголошення лямбда-функцій для арифметичних операцій
            Func<int, int, int> Add = (x, y) => x + y;
            Func<int, int, int> Sub = (x, y) => x - y;
            Func<int, int, int> Mul = (x, y) => x * y;
            Func<int, int, double> Div = (x, y) => y == 0 ? throw new DivideByZeroException() : (double)x / y;

            // Приклад використання лямбда-функцій
            int a = 10;
            int b = 5;

            Console.WriteLine($"a + b = {Add(a, b)}");
            Console.WriteLine($"a - b = {Sub(a, b)}");
            Console.WriteLine($"a * b = {Mul(a, b)}");

            try
            {
                Console.WriteLine($"a / b = {Div(a, b)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Помилка: Ділення на нуль.");
            }

            Console.ReadLine();
        }
    }
}
