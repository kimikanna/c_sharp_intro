// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int inputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int NumOfDigits(int num)
{
    int digitCount = 0;
    if (num == 0)
        return digitCount;
    digitCount = (int)Math.Log10(num) + 1;
    return digitCount;
}

int number = inputNum("Введите число: ");
int amount = NumOfDigits(number);
Console.WriteLine($"Количество цифр в вашем числе: {amount}");