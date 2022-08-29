// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows, int columns, int minVolume, int maxVolume)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().NextDouble() * (new Random().Next(minVolume, maxVolume + 1));

    return newArray;
}
void Show2dArray(double[,] Array) // вывод массива с двумя знаками после запятой
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            if (Array[i,j] < 0) Console.Write("{0}\t",Math.Round(Array[i, j], 2));
            else Console.Write("{0}\t"," " + Math.Round(Array[i, j], 2));
        Console.WriteLine();
    }
}

Console.Write("Введи количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine()); 

double[,] MyArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(MyArray);




// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет






// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.