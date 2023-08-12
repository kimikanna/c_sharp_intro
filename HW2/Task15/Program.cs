// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CheckInput(int inputFromUser)
{
    while (inputFromUser < 1 || inputFromUser > 7)
        inputFromUser = InputNum("Введите число от 1 до 7: ");
    return inputFromUser;
}

string CheckWeekday(int num)
{
    string result = "Да, сегодня выходной";
    if (num < 6)
        result = "Нет, сегодня будний день";
    return result;
}

int numFromUser = InputNum("Введите номер дня недели: ");
int correctNum = CheckInput(numFromUser);
string result = CheckWeekday(correctNum);

Console.WriteLine(result);