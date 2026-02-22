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
        Console.WriteLine(string.Join(", ", array));
    }

    public int RemoveAndReturn(ref int[] array, int index)
    {
        if (array == null || index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Некоректний індекс.");
        }

        int removedElement = array[index];
        int[] newArray = new int[array.Length - 1];

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == index) continue;
            newArray[j++] = array[i];
        }

        array = newArray;
        return removedElement;
    }
}