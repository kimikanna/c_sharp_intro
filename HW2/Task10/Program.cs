// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ShowSecond(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

int number = InputNum("Введите трёхзначное число: ");
int secondDigit = ShowSecond(number);

Console.WriteLine($"Вторая цифра числа: {secondDigit}");