/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
(1,7) -> такого числа в массиве нет */

Console.Write("Введите количество строк в матрице: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какой строке будет цифра: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в каком столбце будет цифра: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(-100, 101);
}
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t");
    Console.WriteLine("\t");
}
if (x <= array.GetLength(0) && y <= array.GetLength(1))
    Console.WriteLine("На данном месте находится число " + array[x - 1, y - 1]);
else
    Console.WriteLine("Данного числа нет");
