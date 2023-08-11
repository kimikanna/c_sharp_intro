// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine());
}

bool Square(int num1, int num2) 
{
    if (num2 == num1 * num1)
        return true;
    else
        return false;
}
void PrintResult(bool res)
{  
    if (res == true)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}

int number1 =  InputNum("Введите первое целое число: ");
int number2 =  InputNum("Введите второе целое число: ");

bool result = Square(number1, number2); 

PrintResult(result);