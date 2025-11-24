using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калкулате
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Введите оператор (+ - * /): ");
                    string op = Console.ReadLine();

                    Console.Write("Введите второе число: ");
                    double b = double.Parse(Console.ReadLine());

                    double result;

                    switch (op)
                    {
                        case "+": result = a + b; break;
                        case "-": result = a - b; break;
                        case "*": result = a * b; break;
                        case "/":
                            if (b == 0)
                                throw new DivideByZeroException();
                            result = a / b;
                            break;
                        default:
                            Console.WriteLine("Недопустимый оператор!");
                            continue;
                    }

                    Console.WriteLine($"Результат: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: неверный ввод числа!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }

                Console.Write("Продолжить? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }


        }
    }
}
