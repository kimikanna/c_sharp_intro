/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumOfDigits(int num)
{
    int sum = 0;
    for (int i = 0; num != 0; i++)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

int num = InputNum("Введите целое число: ");
int result = SumOfDigits(num);
Console.WriteLine($"Сумма всех цифр введённого числа: {result}");