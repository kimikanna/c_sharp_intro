// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int j = -1; 

for (int i = 2; i < number - 1; i += 2)
{
    Console.Write($"{i}, ");
    j = i;
}

if ( j == -1)
{
    Console.WriteLine("Чётных чисел от 1 до N не существует");
}
else
{
    j += 2;
    Console.WriteLine(j);
}
