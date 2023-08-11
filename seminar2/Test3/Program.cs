int MaxDigit(int num)
{
    int secondDigit = num % 10;
    int firstDigit = num / 10;
    int max = secondDigit;

    if (firstDigit > secondDigit)
        max = firstDigit;

    return max;
}

int number = new Random().Next(10, 100); // [10, 100)
int maxDigit = MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {maxDigit}");