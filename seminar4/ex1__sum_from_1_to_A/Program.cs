// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int inputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumFrom1ToNum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
        sum += i;
    return sum;
}

int number = inputNum("Введите число: ");
int sum = SumFrom1ToNum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна: {sum}");