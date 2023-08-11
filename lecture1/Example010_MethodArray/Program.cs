int[] array = { 92, 68, 23, 22, 84, 15, 22, 97, 66 };

int n = array.Length;
int find = 23;

int index = 0;
int exist = 0;

while (index < n)
{
    if (array[index] == find) {
        Console.WriteLine(index);
        exist = 1;
        break;
    }
    index++;
}

if (exist == 0) {
    Console.WriteLine("Искомое число не найдено");
}