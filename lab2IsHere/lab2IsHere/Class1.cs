using System;

public class ArrayHelper
{
    public void PrintArray(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Масив порожній.");
            return;
        }

        Console.WriteLine("Елементи масиву:");
        Console.WriteLine(string.Join(", ", array));
    }

    public string SwapZeroOne(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '0')
                chars[i] = '1';
            else if (chars[i] == '1')
                chars[i] = '0';
        }

        return new string(chars);
    }
}