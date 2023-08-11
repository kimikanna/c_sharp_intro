﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool Multiplicity(int num1, int num2)
{
    // if (num1 % num2 == 0)
    //     return true;
    // return false;

    return num1 % num2 == 0;
}

void CheckResult(bool mult, int firstNum, int secondNum)
{
    // if (mult == true)
    if (mult)
    {
        System.Console.WriteLine("Второе число кратно первому");
    }
    else
        System.Console.WriteLine($"Второе число не кратно первому, остаток от деления: {firstNum % secondNum}");
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool result = Multiplicity(firstNum, secondNum);
CheckResult(result, firstNum, secondNum);
