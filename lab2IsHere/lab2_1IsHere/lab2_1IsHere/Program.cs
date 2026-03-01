using System;
using System.Reflection;

namespace lab2_1IsHere
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly a = Assembly.LoadFrom("lab2IsHere.dll");

                Type t = a.GetType("ArrayHelper");
                object o = a.CreateInstance("ArrayHelper");

                int[] myArr = { 5, 10, 15, 20 };

                Console.WriteLine("Вивід масиву:");
                MethodInfo printMethod = t.GetMethod("PrintArray");
                printMethod.Invoke(o, new object[] { myArr });

                string binaryString = "10100110";

                Console.WriteLine("\nПочатковий рядок:");
                Console.WriteLine(binaryString);

                MethodInfo swapMethod = t.GetMethod("SwapZeroOne");
                object result = swapMethod.Invoke(o, new object[] { binaryString });

                Console.WriteLine("\nПісля заміни 0 ↔ 1:");
                Console.WriteLine(result);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}