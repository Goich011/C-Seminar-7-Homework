/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Введите количество строк в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());
double sum = 0;

int[,] array = new int[n, m];
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(0, 10);
}
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t");
    Console.WriteLine("\t");
}

Console.WriteLine("Среднее арифметическое в столбце");
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
        sum = sum + array[i, j];
    Console.Write(Math.Round((sum / n), 2) + "\t");
    sum = 0;
}
Console.WriteLine();
