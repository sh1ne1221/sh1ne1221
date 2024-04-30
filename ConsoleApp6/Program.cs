using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp6.Class1;
using static ConsoleApp6.Class10;
using static ConsoleApp6.Class2;
using static ConsoleApp6.Class3;
using static ConsoleApp6.Class4;
using static ConsoleApp6.Class5;
using static ConsoleApp6.Class6;
using static ConsoleApp6.Class7;
using static ConsoleApp6.Class8;
using static ConsoleApp6.Class9;

namespace EngineeringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение (+)");
                Console.WriteLine("2. Вычитание (-)");
                Console.WriteLine("3. Умножение (*)");
                Console.WriteLine("4. Деление (/)");
                Console.WriteLine("5. Синус (sin)");
                Console.WriteLine("6. Косинус (cos)");
                Console.WriteLine("7. Тангенс (tan)");
                Console.WriteLine("8. Котангенс (cot)");
                Console.WriteLine("9. Возведение в степень (^)");
                Console.WriteLine("10. Квадратный корень (√)");
                Console.WriteLine("11. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation(Addition.Calculate);
                        break;
                    case "2":
                        PerformOperation(Subtraction.Calculate);
                        break;
                    case "3":
                        PerformOperation(Multiplication.Calculate);
                        break;
                    case "4":
                        PerformOperation(Division.Calculate);
                        break;
                    case "5":
                        PerformTrigonometricOperation(Sine.Calculate, "синус");
                        break;
                    case "6":
                        PerformTrigonometricOperation(Cosine.Calculate, "косинус");
                        break;
                    case "7":
                        PerformTrigonometricOperation(Tangent.Calculate, "тангенс");
                        break;
                    case "8":
                        PerformTrigonometricOperation(Cotangent.Calculate, "котангенс");
                        break;
                    case "9":
                        PerformExponentiation();
                        break;
                    case "10":
                        PerformSquareRoot();
                        break;
                    case "11":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверная операция. Попробуйте снова.");
                        break;
                }
            }
        }

        static void PerformOperation(Func<double, double, double> operation)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {operation(num1, num2)}");
        }

        static void PerformTrigonometricOperation(Func<double, double> operation, string operationName)
        {
            Console.WriteLine("Введите угол в градусах:");
            double angleDegrees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат {operationName} угла {angleDegrees} градусов: {operation(angleDegrees)}");
        }

        static void PerformExponentiation()
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            double exponent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {Exponentiation.Calculate(num, exponent)}");
        }

        static void PerformSquareRoot()
        {
            Console.WriteLine("Введите число:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат квадратного корня из {num}: {SquareRoot.Calculate(num)}");
        }
    }
}







