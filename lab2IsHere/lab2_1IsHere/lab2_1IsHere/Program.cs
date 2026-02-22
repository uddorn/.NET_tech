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

                int[] myArr = { 10, 20, 30, 40, 50 };

                Console.WriteLine("Початковий масив:");
                MethodInfo printMethod = t.GetMethod("PrintArray");
                object[] printArgs = new object[] { myArr };
                printMethod.Invoke(o, printArgs);

                Console.WriteLine("\nВидаляємо елемент за індексом 2 (значення 30)...");
                MethodInfo removeMethod = t.GetMethod("RemoveAndReturn");
                object[] removeArgs = new object[] { myArr, 2 };
                object removedValue = removeMethod.Invoke(o, removeArgs);

                myArr = (int[])removeArgs[0];
                Console.WriteLine($"Видалений елемент: {removedValue}");

                Console.WriteLine("\nОновлений масив:");
                printArgs[0] = myArr;
                printMethod.Invoke(o, printArgs);

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