/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CheckZero(int size)
{
    while (size <= 0)
    {
        int correctSize = InputNum("Введите размер массива больше нуля: ");
        size = correctSize;
    }

    return size;
}

int[] ThreeDigits(int size)
{
    int[] array = new int[size];
    Random element = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = element.Next(100, 1000);
    }

    return array;
}

int NumOfEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            counter++;
    }

    return counter;
}

string PrintArray(int[] array)
{
    string arr = "[ ";
    for (int i = 0; i < array.Length - 1; i++)
        arr += array[i] + ", ";

    arr += array[array.Length - 1] + " ]";
    return arr;
}

int size = InputNum("Введите количество элементов в массиве: ");
size = CheckZero(size);
int[] array = ThreeDigits(size);
int counter = NumOfEven(array);
string arr = PrintArray(array);
Console.WriteLine(arr);
Console.WriteLine($"Количество чётных элементов: {counter}");