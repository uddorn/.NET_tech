using System;

namespace lab4IsHere
{
    public delegate double MathFunction(double x);

    public class NameEventPublisher
    {
        public event Action OnNameKeyTriggered;

        public void ListenForKey(char targetChar)
        {
            Console.WriteLine("\nВведіть першу літеру вашого імені:");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (char.ToLower(keyInfo.KeyChar) == char.ToLower(targetChar))
                {
                    OnNameKeyTriggered();
                    break;
                }
            }
        }
    }

    class Program
    {
        static double CalculateIntegral(MathFunction f, double a, double b, int n)
        {
            double dx = (b - a) / n;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double x = a + i * dx;
                sum += f(x);
            }

            return sum * dx;
        }

        static double AnalyticalIntegral(double a, double b)
        {
            return (Math.Pow(b, 3) - Math.Pow(a, 3)) / 3.0;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a = 1.0;
            double b = 3.0;
            int n = 1000;

            Console.WriteLine("Обчислення інтегралів");
            Console.WriteLine($"Проміжок: [{a}, {b}], n = {n}\n");

            MathFunction funcX2 = x => x * x;
            double numX2 = CalculateIntegral(funcX2, a, b, n);
            double analX2 = AnalyticalIntegral(a, b);
            double errorX2 = Math.Abs(analX2 - numX2);

            Console.WriteLine("f(x) = x^2");
            Console.WriteLine($"Чисельне значення: {numX2:F6}");
            Console.WriteLine($"Аналітичне значення: {analX2:F6}");
            Console.WriteLine($"Похибка: {errorX2:F6}\n");

            Console.WriteLine("Варіант 2:");
            MathFunction f1 = x => 1.0 / Math.Pow(x, 1.0 / 3.0);
            Console.WriteLine($"f(x) = 1/cbrt(x): \t{CalculateIntegral(f1, a, b, n):F6}");

            MathFunction f2 = x => 1.0 / Math.Sqrt(x * x);
            Console.WriteLine($"f(x) = 1/sqrt(x^2): \t{CalculateIntegral(f2, a, b, n):F6}");

            MathFunction f3 = x => Math.Cos(x);
            Console.WriteLine($"f(x) = cos(x): \t\t{CalculateIntegral(f3, a, b, n):F6}");

            NameEventPublisher namePublisher = new NameEventPublisher();

            char myFirstLetter = 'д';
            string myFullName = "Дмитро";

            namePublisher.OnNameKeyTriggered += () =>
            {
                Console.WriteLine($"\nІм'я: {myFullName}");
            };

            namePublisher.ListenForKey(myFirstLetter);

            Console.ReadKey();
        }
    }
}