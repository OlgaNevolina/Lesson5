Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int count = 0;
var newRnd = new Random();
Console.Write($"Массив: ");
for (int i = 0; i < size; i++)
{
array[i] = newRnd.Next(100, 1000);
Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count+=1;
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");
