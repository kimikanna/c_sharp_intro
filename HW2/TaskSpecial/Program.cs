// Программа на вход получает натуральное число. Необходимо его преобразовать таким образом,
// чтобы все нечетные числа стояли впереди, а все четные позади. Использовать можно только
// арифметические действия без работы со строкой.
// 12345 -> 13524
// 3658563 -> 3553686
// 48 -> 48
// 5497 -> 5974

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SortNumber(int number)
{
    int oddNumbers = 0;
    int evenNumbers = 0;
    int oddsLength = 0;
    int evensLength = 0;

    while (number > 0)
    {
        int x = number % 10;
        if (x % 2 == 0)
        {
            evenNumbers = x * (int)Math.Pow(10, evensLength) + evenNumbers;
            evensLength += 1;
        }
        else
        {
            oddNumbers = x * (int)Math.Pow(10, oddsLength) + oddNumbers;
            oddsLength += 1;
        }
        number /= 10;
    }

    int result = 0;

    if (oddsLength > 0)
    {
        result = oddNumbers * (int)Math.Pow(10, evensLength) + evenNumbers;
    }
    else
    {
        result = evenNumbers;
    }

    return result;
}

int number = InputNum("Введите число: ");
int result = SortNumber(number);

Console.WriteLine($"Результат: {result}");