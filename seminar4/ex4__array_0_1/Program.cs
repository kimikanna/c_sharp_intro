// Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayOfNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(2);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int size = InputNum("Введите размер массива: ");
int[] result = ArrayOfNumbers(size);
PrintArray(result);