/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

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

double[] ArrayOfDoubles(int size)
{
    double[] array = new double[size];
    Random element = new Random();
    int deviation = 100;
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((element.NextDouble() - 0.5) * 2 * deviation, 2); // [-100, 100]
    }

    return array;
}

string PrintArray(double[] array)
{
    string arr = "[ ";
    for (int i = 0; i < array.Length - 1; i++)
        arr += array[i] + ", ";

    arr += array[array.Length - 1] + " ]";
    Console.WriteLine();
    return arr;
}

double DiffBetweenMinAndMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }

    double diff = max - min;
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Максимальный элемент массива: {max}");
    return diff;
}

int size = InputNum("Введите количество элементов в массиве: ");
size = CheckZero(size);
double[] array = ArrayOfDoubles(size);
string arr = PrintArray(array);
Console.WriteLine(arr);
double diff = DiffBetweenMinAndMax(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");