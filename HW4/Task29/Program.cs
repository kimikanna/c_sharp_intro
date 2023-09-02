/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ConvertToArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }

    return arr;
}

string ConvertArrayToString(int[] arr)
{
    string array = Convert.ToString(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        array += ", ";
        array += arr[i];
    }

    return array;
}

int len = InputNum("Введите количество элементов массива: ");
if (len == 0)
{
    len = InputNum("Введите число больше нуля: ");
}

int[] arr = ConvertToArray(len);
string result = ConvertArrayToString(arr);
Console.Write(result);