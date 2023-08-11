// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите три числа, через запятую или пробел: ");
char[] separators = { ' ', ',', '.' };
string[] allNumbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

int num1 = int.Parse(allNumbers[0].Trim());
int num2 = int.Parse(allNumbers[1].Trim());
int num3 = int.Parse(allNumbers[2].Trim());

int max = num1;
if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine($"Максимальное число из трёх введённых: {max}");