/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задачу решал при помощи поисковика, где искал правила Рандома с вещественными 
// числами.  
 
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
*/


// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int FindElementValue(int[,] array, int rows, int columns)
{
    int element = 0;
    if (rows < 0 | columns < 0) return element = rows + columns;
    if (array.GetLength(0) < rows + 1 | array.GetLength(1) < columns + 1)
        return element = rows + columns;
    else return element = array[rows, columns];       
    
}
int[,] myArray = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }
}

Show2dArray(myArray);
Console.Write("Введи номер строки искомого элемента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи номер столбца искомого элемента: ");
int j = Convert.ToInt32(Console.ReadLine());
i--;
j--;

int number = FindElementValue(myArray, i, j);
if (number == (i + j)) Console.WriteLine($"Такого числа с индексом [{i + 1}, {j + 1}] в массиве нет");
else Console.WriteLine($"Искомый элемент это: {number}");
*/

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
double[,] myArray = new double[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
void Show2dArray(double[,] array) // Вывод вещественного 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    Console.WriteLine();
    }
}
void ShowArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    if (i == array.Length -1) Console.Write($"{Math.Round(array[i],2)}");
    else Console.Write($"{Math.Round(array[i],2)} ");
    Console.Write("]");
    Console.WriteLine();    
}
double[] AverageColumns(double[,] array)
{
    double[] newArray = new double[array.GetLength(1)];   
    for (int j = 0; j < array.GetLength(1); j++)
        {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array [i,j];
        newArray[j] = sum / array.GetLength(0);
        }

    return newArray;
}
Show2dArray(myArray);
double[] newMyArray = AverageColumns (myArray);
Console.WriteLine();
Console.Write("Cреднее арифметическое элементов в каждом столбце: ");  
ShowArray(newMyArray);
*/
