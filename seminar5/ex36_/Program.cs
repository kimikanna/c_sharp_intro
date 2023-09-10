/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        array[i] = element.Next(-100, 101); // [-100, 100]
    }

    return array;
}

int SumOfOddIndexes(int[] array)
{
    int sumOfOddIndexes = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOfOddIndexes += array[i];
    }

    return sumOfOddIndexes;
}

string PrintArray(int[] array)
{
    string arr = "[ ";
    for (int i = 0; i < array.Length - 1; i++)
        arr += array[i] + ", ";

    arr += array[array.Length - 1] + " ]";
    Console.WriteLine();
    return arr;
}

string PrintArrayOfOddIndexes(int[] array)
{
    string arr = "Элементы массива с нечётными индексами: ";
    if (array.Length == 1)
    {
        arr = "Нет ни одного элемента с нечётным индексом";
        return arr;
    }
    for (int i = 1; i < array.Length; i += 2)
        arr += "[" + i + "] " + array[i] + " ";

    return arr;
}

int size = InputNum("Введите количество элементов в массиве: ");
size = CheckZero(size);
int[] array = ThreeDigits(size);
int sumOfOddIndexes = SumOfOddIndexes(array);
string arr = PrintArray(array);
Console.WriteLine(arr);
string arrOdd = PrintArrayOfOddIndexes(array);
Console.WriteLine(arrOdd);
Console.WriteLine($"Сумма элементов с нечётными индексами: {sumOfOddIndexes}");