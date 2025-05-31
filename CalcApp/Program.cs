using CalcApp;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Операция (+ - * /):");
        string op = Console.ReadLine();

        double result = op switch
        {
            "+" => Calculator.Add(a, b),
            "-" => Calculator.Subtract(a, b),
            "*" => Calculator.Multiply(a, b),
            "/" => Calculator.Divide(a, b),
            _ => throw new Exception("Неизвестная операция")
        };

        Console.WriteLine($"Результат: {result}");
    }
}