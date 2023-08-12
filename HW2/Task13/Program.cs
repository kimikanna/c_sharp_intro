// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int MakeTriple(int numFromUser)
{
    if (numFromUser < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        Environment.Exit(1);  // завершаем выполнение программы
    }
    else
    {
        while (numFromUser >= 1000)
        {
            numFromUser /= 10;
        }
    }
    return numFromUser;
}

int ShowThird(int tripleNum)
{
    tripleNum %= 10;
    return tripleNum;
}

int numFromUser = InputNum("Введите число: ");
int tripleNum = MakeTriple(Math.Abs(numFromUser));  // чтобы работало и для отрицательных чисел
int thirdDigit = ShowThird(tripleNum);

Console.WriteLine($"Третья цифра введённого числа: {thirdDigit}");