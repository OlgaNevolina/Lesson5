Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

var newRnd = new Random();
Console.Write($"Массив: ");
for (int i = 0; i < size; i++)
{
array[i] = newRnd.Next(0, 20);
Console.Write(array[i] + " ");
}
Console.WriteLine();

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.Write("Разница между максимальным и минимальным элементом = ");
Console.Write(max - min);
