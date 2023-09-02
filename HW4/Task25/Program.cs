/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FirstNumInPowOfSecondNum(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= num;
    }

    return result;
}

int num = InputNum("Введите целое число: ");
int pow = InputNum("Введите степень, в которую мы возведём это число: ");
int result = FirstNumInPowOfSecondNum(num, pow);
Console.WriteLine($"Число {num} в степени {pow}: {result}");