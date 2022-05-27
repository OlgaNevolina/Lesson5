Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int count = 0;
var newRnd = new Random();
Console.Write($"Массив: ");
for (int i = 0; i < size; i++)
{
array[i] = newRnd.Next(-100, 100);
Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) count = count + array[i];

}

Console.Write("Сумма элементов, стоящих на нечетной позиции в массиве = ");
Console.Write(count);
