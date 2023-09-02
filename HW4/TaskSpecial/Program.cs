/* С помощью ряда Нилаканта вычислить значение числа пи.
Решение должно быть оформлено в виде функции. Функция должна принимать
точность – количество знаков после запятой, которое указал пользователь. 
Точность расчета не должна сравниваться с уже известным значением числа.
Программа должна сама оценить, когда точность достигнута. */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double CalcTargetAcc(int len)
{
    double targetAcc = 0.1;
    for (int i = 0; i < len; i++)
    {
        targetAcc *= 0.1;
    }

    return targetAcc;
}

double CalcPi(double targetAcc)
{
    double pi = 3;
    double nextPi = pi;
    double accuracy = 999;
    for (int i = 2; accuracy > 1 + targetAcc; i += 2)
    {
        nextPi += (double)4 / (i * (i + 1) * (i + 2));
        accuracy = (double)pi / nextPi;
        pi = nextPi;
        i += 2;
        nextPi -= (double)4 / (i * (i + 1) * (i + 2));
        accuracy = (double)pi / nextPi;
        pi = nextPi;
    }

    return pi;
}

int len = InputNum("Введите количество знаков после запятой: ");
double targetAcc = CalcTargetAcc(len);
double pi = CalcPi(targetAcc);
pi = Math.Round(pi, len);
Console.WriteLine($"Число pi с точностью {len} знаков после запятой: {pi}");
